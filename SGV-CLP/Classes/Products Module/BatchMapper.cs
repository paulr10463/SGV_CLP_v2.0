using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Products_module
{
    public class BatchMapper
    {
        // String de conexión a la BD
        private static readonly string s_connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        // Ingresar Lote
        public static void AddBatch(Batch batch)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Lote\"(\"cod_Lote\", \"cod_Producto\", \"cantidad\", \"fecha\") VALUES (@cod_Lote, @cod_Producto, @cantidad, @fecha)", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Lote", batch.batchCode);
                cmd.Parameters.AddWithValue("@cod_Producto", batch.productCode);
                cmd.Parameters.AddWithValue("@cantidad", batch.quantity);
                cmd.Parameters.AddWithValue("@fecha", batch.manufactureDate);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar Lote
        public static void DeleteBatch(string batchCode)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Lote\" WHERE \"cod_Lote\" = @cod_Lote", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Lote", batchCode);
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Lote 
        public static void EditBatch(string batchCode, int quantity, DateTime manufactureDate)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Lote\" SET \"cantidad\" = @cantidad, \"fecha\" = @fecha WHERE \"cod_Lote\" = @cod_Lote ", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Lote", batchCode);
                cmd.Parameters.AddWithValue("@cantidad", quantity);
                cmd.Parameters.AddWithValue("@fecha", manufactureDate);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Lotes
        public static List<Batch> GetAllBatches()
        {
            List<Batch> registeredBatches = new List<Batch>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Lote\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        registeredBatches.Add(new Batch(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetDateTime(3).Date + reader.GetDateTime(3).TimeOfDay)
                            );
                    }
                }
            }
            return registeredBatches;
        }

        // Consultar un atributo de un Lote
        public static string GetBatchField(string batchCode, string field)
        {
            string fieldValue = string.Empty;
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{field}\" FROM \"Lote\" WHERE \"cod_Lote\" = @cod_Lote", connection))
                {
                    cmd.Parameters.AddWithValue("@cod_Lote", batchCode);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (field == "fecha")
                        {
                            if (reader.Read())
                            {
                                fieldValue = reader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss");
                            }
                        }
                        else
                        {
                            if (reader.Read())
                            {
                                fieldValue = reader.GetValue(0).ToString();
                            }
                        }
                    }
                }
            }
            return fieldValue;
        }

        public static string GetMostRecentBatchCodeForProduct(string productCode)
        {
            string batchCode = string.Empty;
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand($"SELECT \"cod_Lote\" FROM public.\"Lote\" WHERE \"cod_Lote\" ~* '^{productCode}[0-9]+.*$' ORDER BY \"cod_Lote\" DESC LIMIT 1", connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        batchCode = reader["cod_Lote"].ToString();
                    }
                }
            }
            return batchCode;
        }

    }
}
