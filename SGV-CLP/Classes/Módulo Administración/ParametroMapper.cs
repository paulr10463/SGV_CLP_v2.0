using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Módulo_Administración
{
    internal class ParametroMapper
    {
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        public static void IngresarParametro(ParametroPorUnidad parametro)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"ParametroPorUnidad\"(\"unidadBase\",\"unidadExtra\",\"nombre_Producto\") VALUES (@UBase, @UExtra, @nomProd)", connection))
            {
                cmd.Parameters.AddWithValue("@UBase", int.Parse(parametro.UnidadBase));
                cmd.Parameters.AddWithValue("@UExtra", int.Parse(parametro.UnidadExtra));
                cmd.Parameters.AddWithValue("@nomProd", parametro.Producto);
                cmd.ExecuteNonQuery();
            }
        }

        // ###########################################################################
        // Eliminar Usuario
        public static void EliminarParametro(string codParam)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"ParametroPorUnidad\" WHERE \"cod_ParametroPorUnidad\" = @codParam", connection))
            {
                cmd.Parameters.AddWithValue("@codParam", int.Parse(codParam));
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Usuario 
        public static void EditarParametro(string cod_Param, string UnidadBase, string UnidadExtra, string Producto)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"ParametroPorUnidad\" SET \"unidadBase\" = @UnidadBase, \"unidadExtra\" = @UnidadExtra, \"nombre_Producto\" = @Producto " +
                "WHERE \"cod_ParametroPorUnidad\" = @cod_Param", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Param", int.Parse(cod_Param));
                cmd.Parameters.AddWithValue("@UnidadBase", int.Parse(UnidadBase));
                cmd.Parameters.AddWithValue("@UnidadExtra", int.Parse(UnidadExtra));
                cmd.Parameters.AddWithValue("@Producto", Producto);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Parametros (PARA LLENAR DATAGRID)
        public static List<ParametroPorUnidad> ConsultarParametros()
        {
            List<ParametroPorUnidad> paramRegistrados = new List<ParametroPorUnidad>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"ParametroPorUnidad\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        paramRegistrados.Add(new ParametroPorUnidad(reader.GetInt32(0).ToString(), reader.GetInt32(1).ToString(), reader.GetInt32(2).ToString(), reader.GetString(3)));
                    }
                }
            }
            return paramRegistrados;
        }

        // Consultar un atributo de un Parametro (PARA LLENAR CAMPOS EN PANTALLA EDITAR)
        public static string ConsultarAtributoParametro(string codParam, string atributo)
        {
            string valorAtributo = string.Empty;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{atributo}\" FROM \"ParametroPorUnidad\" WHERE \"cod_ParametroPorUnidad\" = @codParam", connection))
                {
                    cmd.Parameters.AddWithValue("@codParam", int.Parse(codParam));
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

        // NO ES NECESARIO POR QUE COD_PARAM ES IDENTITY
        /*public static bool IDproductoExiste(string id)
        {
            bool existe = false;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Producto\" WHERE \"cod_Producto\" ILIKE @cod_Producto", connection))
                {
                    command.Parameters.AddWithValue("@cod_Producto", id);
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
        }*/

        // Consultar nombres de los Productos para actualizar el Combobox de parámetros

        public static bool parametroExiste(string producto)
        {
            bool existe = false;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM public.\"ParametroPorUnidad\" WHERE \"nombre_Producto\" ILIKE @producto", connection))
                {
                    command.Parameters.AddWithValue("@producto", producto);
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
