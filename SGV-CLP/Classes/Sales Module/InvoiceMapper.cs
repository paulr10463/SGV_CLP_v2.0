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

        public static List<Invoice> GetAllInvoices(string parameter, string value)
        {
            List<Invoice> invoices = new List<Invoice>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                var queryString = "SELECT * FROM \"NotaVenta\" JOIN \"Cliente\" ON \"NotaVenta\".\"cc_Cliente\" = \"Cliente\".\"cc_Cliente\" WHERE \"" + parameter + "\" ILIKE '%" + value + "%'";
                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int invoiceCode = (int)reader["cod_NotaVenta"];
                        string customerID = (string)reader["cc_Cliente"];
                        string firstName = (string)reader["primer_Nombre"];
                        string firstLastName = (string)reader["primer_Apellido"];
                        string phoneNumber = (string)reader["telefono"];
                        double totalSale = (double)reader["total_Venta"];
                        DateTime issuedDate = (DateTime)reader["fecha_emision"];
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

        public static List<Invoice> GetAllInvoices(string value)
        {
            List<Invoice> invoices = new List<Invoice>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                var queryString = "SELECT * FROM \"NotaVenta\" JOIN \"Cliente\" ON \"NotaVenta\".\"cc_Cliente\" = \"Cliente\".\"cc_Cliente\" WHERE \"NotaVenta\".\"cc_Cliente\" ILIKE '%" + value + "%'";
                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int invoiceCode = (int)reader["cod_NotaVenta"];
                        string customerID = (string)reader["cc_Cliente"];
                        string firstName = (string)reader["primer_Nombre"];
                        string firstLastName = (string)reader["primer_Apellido"];
                        string phoneNumber = (string)reader["telefono"];
                        double totalSale = (double)reader["total_Venta"];
                        DateTime issuedDate = (DateTime)reader["fecha_emision"];
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


        public static List<Invoice> GetAllInvoicesByDate(string value)
        {
            List<Invoice> invoices = new List<Invoice>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                var queryString = "SELECT * FROM \"NotaVenta\" JOIN \"Cliente\" ON \"NotaVenta\".\"cc_Cliente\" = \"Cliente\".\"cc_Cliente\" WHERE \"fecha_emision\" = '" + value + "'";
                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int invoiceCode = (int)reader["cod_NotaVenta"];
                        string customerID = (string)reader["cc_Cliente"];
                        string firstName = (string)reader["primer_Nombre"];
                        string firstLastName = (string)reader["primer_Apellido"];
                        string phoneNumber = (string)reader["telefono"];
                        double totalSale = (double)reader["total_Venta"];
                        DateTime issuedDate = (DateTime)reader["fecha_emision"];
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

       public static List<Invoice> GetAllInvoicesByCode(int invoiceCode)
        {
            using NpgsqlConnection connection = new(s_connectionString);
            connection.Open();
            using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM \"NotaVenta\" JOIN \"Cliente\" ON \"NotaVenta\".\"cc_Cliente\" = \"Cliente\".\"cc_Cliente\" WHERE \"cod_NotaVenta\" = @CodNotaVenta limit 1;";
            command.Parameters.AddWithValue("@CodNotaVenta", invoiceCode);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int auxInvoiceCode = (int)reader["cod_NotaVenta"];
                string customerID = (string)reader["cc_Cliente"];
                string firstName = (string)reader["primer_Nombre"];
                string firstLastName = (string)reader["primer_Apellido"];
                string phoneNumber = (string)reader["telefono"];
                double totalSale = (double)reader["total_Venta"];
                DateTime issuedDate = (DateTime)reader["fecha_emision"];
                return new List<Invoice> {
                    new Invoice(
                    auxInvoiceCode,
                    new Customer(customerID, firstName, firstLastName, null, phoneNumber, null),
                    totalSale,
                    issuedDate)};
            }
            return null;
        }


        public static void AddInvoice(Invoice invoice)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"NotaVenta\"(\"cc_Cliente\", \"userName\", \"total_Venta\", \"fecha_emision\") VALUES (@Cc_Cliente, @UserName, @Total_Venta, @Fecha_emision)", connection))
            {
                cmd.Parameters.AddWithValue("@Cc_Cliente", invoice.customer.customerID);
                cmd.Parameters.AddWithValue("@UserName", invoice.user.userName);
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
            using (var cmd = new NpgsqlCommand("SELECT \"cod_NotaVenta\" FROM public.\"NotaVenta\" ORDER BY \"cod_NotaVenta\" DESC LIMIT 1", connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        codVenta = (int)reader["cod_NotaVenta"];
                    }
                }
            }
            return codVenta;
        }
    }
}
