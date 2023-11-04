using Npgsql;
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
    public class ProductMapper
    {
        // String de conexión a la BD
        private static readonly string s_connectionString = Constants.CONNECTION_STRING;

        // Métodos en tabla Producto
        // Ingresar Producto
        public static void AddProduct(Product product)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();
            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Product\"(\"productID\", \"name\",  \"price\", \"category\", \"imagePath\",\"parentCode\" ) VALUES (@cod_Producto, @nombre_Producto, @precio_Unitario, @categoria, @ruta_Imagen,@parentCode)", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Producto", product.productCode);
                cmd.Parameters.AddWithValue("@nombre_Producto", product.productName);
                cmd.Parameters.AddWithValue("@precio_Unitario", product.salePrice == null ? DBNull.Value : product.salePrice);
                cmd.Parameters.AddWithValue("@categoria", product.categoryID);
                cmd.Parameters.AddWithValue("@ruta_Imagen", product.imagePath);
                cmd.Parameters.AddWithValue("@parentCode", product.parentCode == null ? DBNull.Value : product.parentCode);
                cmd.ExecuteNonQuery();
            }

            transaction.Commit();

        }

        // Eliminar Producto
        public static void DeleteProduct(string productCode)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();
            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Product\" WHERE \"productID\" = @cod_Producto", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Producto", productCode);
                cmd.ExecuteNonQuery();
            }
            transaction.Commit();
        }

        //  Editar Producto 
        public static void EditProduct(Product product)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Product\" SET \"name\" = @productName, \"category\" = @categoria, \"price\" = @precio_Unitario, \"imagePath\" = @ruta_Imagen,\"parentCode\" = @parentCode  WHERE \"productID\" = @cod_Producto", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Producto", product.productCode);
                cmd.Parameters.AddWithValue("@productName", product.productName);
                cmd.Parameters.AddWithValue("@categoria", product.categoryID);
                cmd.Parameters.AddWithValue("@precio_Unitario", product.salePrice == null ? DBNull.Value : product.salePrice);
                cmd.Parameters.AddWithValue("@ruta_Imagen", product.imagePath);
                cmd.Parameters.AddWithValue("@parentCode", product.parentCode == null ? DBNull.Value : product.parentCode);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Productos
        public static List<Product> GetAllProduct()
        {
            List<Product> registeredProducts = new List<Product>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT \"Product\".*, \"Category\".name FROM \"Product\" join \"Category\" on \"Product\".\"category\" = \"Category\".\"categoryID\" ", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        double? unitPrice = reader.IsDBNull(2) ? (double?)null : reader.GetDouble(2);
                        string? parentCode = reader.IsDBNull(4) ? (string?)null : reader.GetString(4);
                        registeredProducts.Add(new Product(
                            reader.GetString(0), //codProducto
                            reader.GetString(1), //nombreProducto
                            unitPrice, //precioUnitario
                            reader.GetString(3), //rutaImagen
                            parentCode,
                            reader.GetString(6) //categoría)
                            ));
                    }
                }
            }
            return registeredProducts;
        }

        // Consultar producto por parentCode
        public static List<Product> GetProductByParentCode(string parentCode)
        {
            List<Product> registeredProducts = new List<Product>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Product\" WHERE \"parentCode\" = @parentCode", connection))
                {
                    command.Parameters.AddWithValue("@parentCode", parentCode);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double? unitPrice = reader.IsDBNull(2) ? (double?)null : reader.GetDouble(2);
                            string? parentCodeAux = reader.IsDBNull(4) ? (string?)null : reader.GetString(4);
                            registeredProducts.Add(new Product(
                                reader.GetString(0), //codProducto
                                reader.GetString(1), //nombreProducto
                                unitPrice, //precioUnitario
                                reader.GetString(3), //rutaImagen
                                parentCodeAux,
                                reader.GetInt32(5)
                                ));
                        }
                    }
                }
            }
            return registeredProducts;
        }


        // Consultar producto por id
        public static Product? GetProductByID(string codProducto)
        {
            Product productById;
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Product\" WHERE \"productID\" = @productCode", connection))
                {
                    command.Parameters.AddWithValue("@productCode", codProducto);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double? unitPrice = reader.IsDBNull(2) ? (double?)null : reader.GetDouble(2);
                            string? innerParentCode = reader.IsDBNull(4) ? (string?)null : reader.GetString(4);
                            productById = new Product(
                                reader.GetString(0), //codProducto
                                reader.GetString(1), //nombreProducto
                                unitPrice, //precioUnitario
                                reader.GetString(3), //rutaImagen
                                innerParentCode,
                                reader.GetInt32(5) //categoría
                                );
                            return productById;
                        }
                        
                    }
                }
            }
            return null;
        }

        // Consultar productos padre
        public static List<Product> GetAllParentProducts()
        {
            List<Product> registeredProducts = new List<Product>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Product\" WHERE \"price\" IS NULL", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double? unitPrice = reader.IsDBNull(2) ? (double?)null : reader.GetDouble(2);
                            string? innerParentCode = reader.IsDBNull(4) ? (string?)null : reader.GetString(4);
                            registeredProducts.Add(new Product(
                                reader.GetString(0), //codProducto
                                reader.GetString(1), //nombreProducto
                                unitPrice, //precioUnitario
                                reader.GetString(3), //rutaImagen
                                innerParentCode,
                                reader.GetInt32(5) //categoría)
                                ));
                        }
                    }
                }
            }
            return registeredProducts;
        }

        // Consultar nombres de los Productos
        public static List<string> GetProductsNames()
        {
            List<string> NombresProductosRegistrados = new List<string>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT \"name\" FROM \"Product\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NombresProductosRegistrados.Add(reader.GetString(0));
                    }
                }
            }
            return NombresProductosRegistrados;
        }


        // Consultar un atributo de un Producto
        public static string GetProductField(string productCode, string field)
        {
            string fieldValue = string.Empty;
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{field}\" FROM \"Product\" WHERE \"productID\" = @cod_Producto", connection))
                {
                    cmd.Parameters.AddWithValue("@cod_Producto", productCode);
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

        // Verificar existencia de un Producto con un id
        public static async Task<bool> ProductExistsByCode(string productCode)
        {
            bool exists = false;

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new NpgsqlCommand("SELECT * FROM \"Product\" WHERE \"productID\" ILIKE @cod_Producto", connection))
                {
                    command.Parameters.AddWithValue("@cod_Producto", productCode);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            exists = true;
                        }
                    }
                }
            }

            return exists;
        }


        // Verificar existencia de un Producto con un nombre
        public static bool ProductExistsByName(string productName)
        {
            bool exists = false;
            productName = productName.Trim();

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Product\" WHERE \"name\" ILIKE @nombre_Producto", connection))
                {
                    command.Parameters.AddWithValue("@nombre_Producto", productName);
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
    }
}