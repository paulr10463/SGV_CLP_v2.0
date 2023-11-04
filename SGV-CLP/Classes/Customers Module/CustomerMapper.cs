using Npgsql;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Customers_Module
{
    public class CustomerMapper
    {
        // String de conexión a la BD
        private static readonly string s_connectionString = Constants.CONNECTION_STRING;

        // Ingresar Cliente
        public static void AddCustomer(Customer customer)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Customer\"(\"ccCustomer\", \"name\", \"lastName\", \"address\", phone, \"email\") VALUES (@ccCustomer, @name, @lastName,@address, @phone, @email)", connection))
            {
                cmd.Parameters.AddWithValue("@ccCustomer", customer.customerID);
                cmd.Parameters.AddWithValue("@name", customer.firstName);
                cmd.Parameters.AddWithValue("@lastName", customer.firstLastName);
                cmd.Parameters.AddWithValue("@address", customer.homeAddress == null ? DBNull.Value :customer.homeAddress);
                cmd.Parameters.AddWithValue("@phone", customer.phoneNumber == null ? DBNull.Value : customer.phoneNumber);
                cmd.Parameters.AddWithValue("@email", customer.eMail == null ? DBNull.Value : customer.eMail);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar Cliente
        public static void DeleteCustomer(string customerID)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Customer\" WHERE \"ccCustomer\" = @ccCustomer", connection))
            {
                cmd.Parameters.AddWithValue("@ccCustomer", customerID);
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Producto 
        public static void EditCustomer(string customerID, string homeAddress, string eMail, string phoneNumber)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Customer\" SET \"address\" = @address, \"email\" = @email, \"phone\" = @phone WHERE \"ccCustomer\" = @ccCustomer", connection))
            {
                cmd.Parameters.AddWithValue("@ccCustomer", customerID);
                cmd.Parameters.AddWithValue("@address", homeAddress);
                cmd.Parameters.AddWithValue("@email", eMail);
                cmd.Parameters.AddWithValue("@phone", phoneNumber);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Clientes
        public static async Task<List<Customer>> GetAllCustomers()
        {
            List<Customer> registeredCustomers = new();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                await connection.OpenAsync(); // Abre la conexión de forma asíncrona
                using var command = new NpgsqlCommand("SELECT * FROM \"Customer\"", connection);
                using var reader = await command.ExecuteReaderAsync(); // Ejecuta la consulta de forma asíncrona
                while (await reader.ReadAsync()) // Lee el resultado de forma asíncrona
                {
                    string? address = reader.IsDBNull(3) ? (string?)null : reader.GetString(3);
                    string? phone = reader.IsDBNull(4) ? (string?)null : reader.GetString(4);
                    string? email = reader.IsDBNull(5) ? (string?)null : reader.GetString(5);
                    registeredCustomers.Add(
                        new Customer(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            address,
                            phone,
                            email));
                }
            }
            return registeredCustomers;
        }
        public static List<Customer> GetAllCustomersSync()
        {
            List<Customer> registeredCustomers = new List<Customer>();

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open(); // Abre la conexión de forma síncrona
                using (var command = new NpgsqlCommand("SELECT * FROM \"Customer\"", connection))
                using (var reader = command.ExecuteReader()) // Ejecuta la consulta de forma síncrona
                {
                    while (reader.Read()) // Lee el resultado de forma síncrona
                    {
                        string address = reader.IsDBNull(3) ? null : reader.GetString(3);
                        string phone = reader.IsDBNull(4) ? null : reader.GetString(4);
                        string email = reader.IsDBNull(5) ? null : reader.GetString(5);
                        registeredCustomers.Add(
                            new Customer(
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                address,
                                phone,
                                email));
                    }
                }
            }

            return registeredCustomers;
        }


        public static bool CustomerExistsByID(string customerID)
        {
            bool exists = false;
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Customer\" WHERE \"ccCustomer\" ILIKE @ccCustomer", connection))
                {
                    command.Parameters.AddWithValue("@ccCustomer", customerID);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            exists = true;
                        }
                    }
                }
            }
            return exists;
        }


        // Consultar un atributo de un Cliente
        public static string GetCustomerField(string customerID, string field)
        {
            string fieldValue = string.Empty;
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{field}\" FROM \"Customer\" WHERE \"ccCustomer\" = @ccCustomer", connection))
                {
                    cmd.Parameters.AddWithValue("@ccCustomer", customerID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fieldValue = reader.GetValue(0).ToString();
                        }
                    }
                }
            }
            return fieldValue;
        }

        public static async Task<bool> UpdateCustomer(Customer customer)
        {
            int result = 0;
            if (customer.customerID != null)
            {
                await using NpgsqlConnection connection = new NpgsqlConnection(s_connectionString);
                connection.Open();
                await using NpgsqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE public.\"Customer\" SET  \"ccCustomer\"=@ccCustomer, \"name\"=@name, \"lastName\"=@lastName, \"address\"=@address, phone=@phone, \"email\"=@email WHERE \"ccCustomer\" = @ccCustomer;";
                command.Parameters.AddWithValue("@ccCustomer", customer.customerID);
                command.Parameters.AddWithValue("@name", customer.firstName);
                command.Parameters.AddWithValue("@lastName", customer.firstLastName);
                command.Parameters.AddWithValue("@address", customer.homeAddress);
                command.Parameters.AddWithValue("@phone", customer.phoneNumber);
                command.Parameters.AddWithValue("@email", customer.eMail);
                command.Parameters.AddWithValue("@ccCustomer", customer.customerID);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }
    }
}