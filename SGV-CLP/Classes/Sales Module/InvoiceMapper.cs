using Npgsql;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SGV_CLP.Classes.Sales_Module
{
    internal class InvoiceMapper
    {
        private static readonly string s_connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        public static async Task<List<Invoice>> GetAllInvoices(string parameter, string value)
        {
            List<Invoice> invoices = new List<Invoice>();

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                await connection.OpenAsync();

                var queryString = "SELECT * FROM \"Order\" JOIN \"Customer\" ON \"Order\".\"ccCustomer\" = \"Customer\".\"ccCustomer\" WHERE \"" + parameter + "\" ILIKE '%" + value + "%'";

                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        int invoiceCode = (int)reader["orderID"];
                        string customerID = (string)reader["ccCustomer"];
                        string firstName = (string)reader["name"];
                        string firstLastName = (string)reader["lastName"];
                        string phoneNumber = (string)reader["phone"];
                        double totalSale = (double)reader["total"];
                        DateTime issuedDate = (DateTime)reader["issueDate"];

                        invoices.Add(new Invoice(
                            invoiceCode,
                            new Customer(customerID, firstName, firstLastName, null, phoneNumber, null),
                            totalSale,
                            issuedDate));
                    }
                }
            }

            return invoices;
        }

        public static async Task<List<Invoice>> GetAllInvoicesByCode(int invoiceCode)
        {
            using NpgsqlConnection connection = new(s_connectionString);
            await connection.OpenAsync();

            using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM \"Order\" JOIN \"Customer\" ON \"Order\".\"ccCustomer\" = \"Customer\".\"ccCustomer\" WHERE \"orderID\" = @CodNotaVenta limit 1;";
            command.Parameters.AddWithValue("@CodNotaVenta", invoiceCode);

            using NpgsqlDataReader reader = await command.ExecuteReaderAsync();
            if (reader.HasRows)
            {
                await reader.ReadAsync();
                int auxInvoiceCode = (int)reader["orderID"];
                string customerID = (string)reader["ccCustomer"];
                string firstName = (string)reader["name"];
                string firstLastName = (string)reader["lastName"];
                string phoneNumber = (string)reader["phone"];
                double totalSale = (double)reader["total"];
                DateTime issuedDate = (DateTime)reader["issueDate"];

                List<Invoice> result = new List<Invoice>
        {
            new Invoice(
                auxInvoiceCode,
                new Customer(customerID, firstName, firstLastName, null, phoneNumber, null),
                totalSale,
                issuedDate)
        };

                return result;
            }

            return null;
        }


        public static async Task<List<Invoice>> GetAllInvoices(string value)
        {
            List<Invoice> invoices = new List<Invoice>();

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                await connection.OpenAsync();

                var queryString = "SELECT * FROM \"Order\" JOIN \"Customer\" ON \"Order\".\"ccCustomer\" = \"Customer\".\"ccCustomer\" WHERE \"Order\".\"ccCustomer\" ILIKE '%" + value + "%'";

                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        int invoiceCode = (int)reader["orderID"];
                        string customerID = (string)reader["ccCustomer"];
                        string firstName = (string)reader["name"];
                        string firstLastName = (string)reader["lastName"];
                        string phoneNumber = (string)reader["phone"];
                        double totalSale = (double)reader["total"];
                        DateTime issuedDate = (DateTime)reader["issueDate"];

                        invoices.Add(new Invoice(
                            invoiceCode,
                            new Customer(customerID, firstName, firstLastName, null, phoneNumber, null),
                            totalSale,
                            issuedDate));
                    }
                }
            }

            return invoices;
        }

    


        public static async Task<List<Invoice>> GetAllInvoicesByDate(string value)
        {
            List<Invoice> invoices = new();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                await connection.OpenAsync(); // Abre la conexión de forma asíncrona
                var queryString = "SELECT * FROM \"Order\" JOIN \"Customer\" ON \"Order\".\"ccCustomer\" = \"Customer\".\"ccCustomer\" WHERE \"issueDate\" = @value";
                using var command = new NpgsqlCommand(queryString, connection);
                // Utiliza parámetros en lugar de concatenar valores para evitar SQL Injection
                // Convierte el valor de texto a un objeto DateTime
                if (DateTime.TryParse(value, out DateTime dateValue))
                {
                    command.Parameters.AddWithValue("@value", dateValue);
                }
                else
                {
                    // Maneja el caso en el que el valor de texto no es una fecha válida
                    throw new ArgumentException("El valor proporcionado no es una fecha válida.");
                }
                using var reader = await command.ExecuteReaderAsync(); // Ejecuta la consulta de forma asíncrona
                while (await reader.ReadAsync()) // Lee el resultado de forma asíncrona
                {
                    int invoiceCode = (int)reader["orderID"];
                    string customerID = (string)reader["ccCustomer"];
                    string firstName = (string)reader["name"];
                    string firstLastName = (string)reader["lastName"];
                    string phoneNumber = (string)reader["phone"];
                    double totalSale = (double)reader["total"];
                    DateTime issuedDate = (DateTime)reader["issueDate"];
                    invoices.Add(new Invoice(
                        invoiceCode,
                        new Customer(customerID, firstName, firstLastName, null, phoneNumber, null),
                        totalSale,
                        issuedDate));
                }
            }
            return invoices;
        }

        public static void AddInvoice(Invoice invoice)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Order\"(\"ccCustomer\", \"total\", \"issueDate\") VALUES (@ccCustomer, @Total_Venta, @Fecha_emision)", connection))
            {
                cmd.Parameters.AddWithValue("@ccCustomer", invoice.customer.customerID);
                cmd.Parameters.AddWithValue("@Total_Venta", invoice.totalSales);
                cmd.Parameters.AddWithValue("@Fecha_emision", invoice.issuedDate);
                cmd.ExecuteNonQuery();
            }

        }

        public static int ConsultarUltimoID()
        {
            int codVenta = -1;
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand("SELECT \"orderID\" FROM public.\"Order\" ORDER BY \"orderID\" DESC LIMIT 1", connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        codVenta = (int)reader["orderID"];
                    }
                }
            }
            return codVenta;
        }
    }
}
