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
        private static readonly string s_connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        // Ingresar Cliente
        public static void AddCustomer(Customer customer)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Cliente\"(\"cc_Cliente\", \"primer_Nombre\", \"primer_Apellido\", \"direccion_Domicilio\", telefono, \"correo_Electronico\") VALUES (@CC_Cliente, @Primer_Nombre, @Primer_Apellido,@Direccion_Domicilio, @Telefono, @Correo_Electronico)", connection))
            {

                cmd.Parameters.AddWithValue("@CC_Cliente", customer.customerID);
                cmd.Parameters.AddWithValue("@Primer_Nombre", customer.firstName);
                cmd.Parameters.AddWithValue("@Primer_Apellido", customer.firstLastName);
                cmd.Parameters.AddWithValue("@Direccion_Domicilio", customer.homeAddress);
                cmd.Parameters.AddWithValue("@Telefono", customer.phoneNumber);
                cmd.Parameters.AddWithValue("@Correo_Electronico", customer.eMail);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar Cliente
        public static void DeleteCustomer(string customerID)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Cliente\" WHERE \"cc_Cliente\" = @cc_Cliente", connection))
            {
                cmd.Parameters.AddWithValue("@cc_Cliente", customerID);
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Producto 
        public static void EditCustomer(string customerID, string homeAddress, string eMail, string phoneNumber)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Cliente\" SET \"direccion_Domicilio\" = @direccion_Domicilio, \"correo_Electronico\" = @correo_Electronico, \"telefono\" = @telefono WHERE \"cc_Cliente\" = @cc_Cliente", connection))
            {
                cmd.Parameters.AddWithValue("@cc_Cliente", customerID);
                cmd.Parameters.AddWithValue("@direccion_Domicilio", homeAddress);
                cmd.Parameters.AddWithValue("@correo_Electronico", eMail);
                cmd.Parameters.AddWithValue("@telefono", phoneNumber);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Clientes
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> registeredCustomers = new List<Customer>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Cliente\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        registeredCustomers.Add(
                            new Customer(
                                reader.GetString(0), 
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3), 
                                reader.GetString(4), 
                                reader.GetString(5)));
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
                using (var command = new NpgsqlCommand("SELECT * FROM \"Cliente\" WHERE \"cc_Cliente\" ILIKE @cc_Cliente", connection))
                {
                    command.Parameters.AddWithValue("@cc_Cliente", customerID);
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
                using (var cmd = new NpgsqlCommand($"SELECT \"{field}\" FROM \"Cliente\" WHERE \"cc_Cliente\" = @cc_Cliente", connection))
                {
                    cmd.Parameters.AddWithValue("@cc_Cliente", customerID);
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
                command.CommandText = "UPDATE public.\"CLiente\" SET  \"cc_Cliente\"=@CC_Cliente, \"primer_Nombre\"=@Primer_Nombre, \"primer_Apellido\"=@Primer_Apellido, \"direccion_Domicilio\"=@Direccion_Domicilio, telefono=@Telefono, \"correo_Electronico\"=@Correo_Electronico WHERE \"cc_Cliente\" = @CC_Cliente;";
                command.Parameters.AddWithValue("@CC_Cliente", customer.customerID);
                command.Parameters.AddWithValue("@Primer_Nombre", customer.firstName);
                command.Parameters.AddWithValue("@Primer_Apellido", customer.firstLastName);
                command.Parameters.AddWithValue("@Direccion_Domicilio", customer.homeAddress);
                command.Parameters.AddWithValue("@Telefono", customer.phoneNumber);
                command.Parameters.AddWithValue("@Correo_Electronico", customer.eMail);
                command.Parameters.AddWithValue("@CC_Cliente", customer.customerID);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }
    }
}