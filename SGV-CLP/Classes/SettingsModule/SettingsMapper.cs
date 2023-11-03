using Npgsql;
using NpgsqlTypes;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Products_module
{
    public class SettingsMapper
    {
        // String de conexión a la BD
        private static readonly string s_connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        // Métodos en tabla Producto
        // Ingresar Producto
        public static bool GetSettingValue(string settingName)
        {
            bool settingValue = false;

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT \"SettingValue\" FROM \"Setting\" WHERE \"SettingName\" = @settingName", connection))
                {
                    command.Parameters.AddWithValue("@settingName", settingName);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            settingValue = reader.GetBoolean(0);
                        }
                    }
                }
            }
            return settingValue;
        }

        //  Sobreeescribir setting
        public static void EditSetting(string settingName, bool settingValue)
        {
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand("UPDATE \"Setting\" SET \"SettingValue\" = @settingValue WHERE \"SettingName\" = @settingName", connection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@settingValue", NpgsqlDbType.Boolean) { Value = settingValue });
                    cmd.Parameters.Add(new NpgsqlParameter("@settingName", NpgsqlDbType.Text) { Value = settingName });

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción aquí (por ejemplo, registrándola o notificándola)
                        Console.WriteLine("Error en la base de datos: " + ex.Message);
                    }
                }
            }
        }



    }
}