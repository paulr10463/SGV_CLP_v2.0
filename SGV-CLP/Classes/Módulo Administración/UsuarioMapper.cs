using Npgsql;
using SGV_CLP.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Módulo_Administración
{
    internal class UsuarioMapper
    {
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";
        
        public static void IngresarUsuario(Usuario usuario)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Usuario\"(\"cc_Usuario\", \"userName\",\"contrasenia\",\"primer_Nombre\", \"segundo_Nombre\", \"primer_Apellido\", \"segundo_Apellido\", \"cargo\") VALUES (@cc_Usuario, @userName,@contrasenia, @primer_Nombre, @segundo_Nombre, @primer_Apellido, @segundo_Apellido, @cargo)", connection))
            {
                cmd.Parameters.AddWithValue("@cc_Usuario", usuario.cc_Usuario);
                cmd.Parameters.AddWithValue("@userName", usuario.userName);
                cmd.Parameters.AddWithValue("@contrasenia", usuario.contrasenia);
                cmd.Parameters.AddWithValue("@primer_Nombre", usuario.primer_Nombre);
                cmd.Parameters.AddWithValue("@segundo_Nombre", usuario.segundo_Nombre);
                cmd.Parameters.AddWithValue("@primer_Apellido", usuario.primer_Apellido);
                cmd.Parameters.AddWithValue("@segundo_Apellido", usuario.segundo_Apellido);
                cmd.Parameters.AddWithValue("@cargo", usuario.cargo);
                cmd.ExecuteNonQuery();
            }
        }

        //READ
        public static Usuario getUser(string userName, string contrasenia)
        {
            using NpgsqlConnection connection = new(_connectionString);
            connection.Open();
            using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  \"primer_Nombre\",\"cargo\" FROM public.\"Usuario\" WHERE \"userName\" = @UserName and \"contrasenia\" = @Contrasenia ;";
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Contrasenia", contrasenia);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string primerNombre = (string)reader["primer_Nombre"];
                string cargo = (string)reader["cargo"];
                return new Usuario(null, userName, contrasenia, primerNombre, null, cargo);
            }
            return null;
        }

        //READ --- NO SE USA
        /*public static async Task<Cliente> getUserData(string CC_Cliente)
        {
            await using NpgsqlConnection connection = new(_connectionString);
            connection.Open();
            await using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  \"primer_Nombre\" FROM public.\"Cliente\" WHERE \"cc_Cliente\" = @ccCliente limit 1;";
            command.Parameters.AddWithValue("@ccCliente", CC_Cliente);
            NpgsqlDataReader reader = await command.ExecuteReaderAsync();
            if (reader.HasRows)
            {
                reader.Read();
                string primerNombre = (string)reader["primer_Nombre"];
                string segundoNombre = (string)reader["segundo_Nombre"];
                string primerApellido = (string)reader["primer_Apellido"];
                string segundoApellido = (string)reader["segundo_Apellido"];
                string direccionDomicilio = (string)reader["direccion_Domicilio"];
                string telefono = (string)reader["telefono"];
                string correoElectronico = (string)reader["correo_Electronico"];
                string ccCLiente = (string)reader["cc_Cliente"];
                return new Cliente(ccCLiente, primerNombre, segundoNombre, primerApellido, segundoApellido, direccionDomicilio, telefono, correoElectronico);
            }
            return null;
        }*/

        // ###########################################################################
        // Eliminar Usuario
        public static void EliminarUsuario(string cc_User)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Usuario\" WHERE \"cc_Usuario\" = @cc_Usuario", connection))
            {
                cmd.Parameters.AddWithValue("@cc_Usuario", cc_User);
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Usuario 
        public static void EditarUsuario(string cc_User, string userName, string passw, string primerNomb, 
            string primerApell, string cargo)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Usuario\" SET \"userName\" = @username, \"contrasenia\" = @passw, \"primer_Nombre\" = @primerNomb, " +
                "\"segundo_Nombre\" = @segNomb, \"primer_Apellido\" = @primerApell, \"segundo_Apellido\" = @segApell, \"cargo\" = @cargo " +
                "WHERE \"cc_Usuario\" = @cc_Usuario", connection))
            {
                cmd.Parameters.AddWithValue("@cc_Usuario", cc_User);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@passw", passw);
                cmd.Parameters.AddWithValue("@primerNomb", primerNomb);
                cmd.Parameters.AddWithValue("@primerApell", primerApell);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Usuarios (PARA LLENAR DATAGRID)
        public static List<Usuario> ConsultarUsuarios()
        {
            List<Usuario> usuariosRegistrados = new List<Usuario>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Usuario\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuariosRegistrados.Add(new Usuario(
                            reader.GetString(0), 
                            reader.GetString(1), 
                            reader.GetString(2), 
                            reader.GetString(3),
                            reader.GetString(5),
                            reader.GetString(7)));
                    }
                }
            }
            return usuariosRegistrados;
        }

        // Consultar un atributo de un Usuario (PARA LLENAR CAMPOS EN PANTALLA EDITAR)
        public static string ConsultarAtributoUsuario(string cc_User, string atributo)
        {
            string valorAtributo = string.Empty;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{atributo}\" FROM \"Usuario\" WHERE \"cc_Usuario\" = @cc_Usuario", connection))
                {
                    cmd.Parameters.AddWithValue("@cc_Usuario", cc_User);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            valorAtributo = reader.GetValue(0).ToString();
                        }
                    }
                }
            }
            return valorAtributo;
        }

        // Verificar existencia de un Usuario con un cc_Usuario (PARA MOSTRAR LABEL DE QUE EL USUARIO YA EXISTE)
        public static bool UsernameExiste(string userName)
        {
            bool existe = false;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM public.\"Usuario\" WHERE \"userName\" ILIKE @userName", connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            existe = true;
                        }
                    }
                }
            }
            return existe;
        }

        public static bool ccUserExiste(string cc)
        {
            bool existe = false;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM public.\"Usuario\" WHERE \"cc_Usuario\" ILIKE @cc", connection))
                {
                    command.Parameters.AddWithValue("@cc", cc);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            existe = true;
                        }
                    }
                }
            }
            return existe;
        }

    }
}
