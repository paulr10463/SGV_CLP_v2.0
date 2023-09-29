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
    internal class CategoryMapper
    {
        private static readonly string s_connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        public static async Task<List<Category>> GetAllCategoriesAsync()
        {
            List<Category> categories = new();

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                await connection.OpenAsync();

                var queryString = "SELECT * FROM \"Category\"";

                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        int categoryID = (int)reader["categoryID"];
                        string categoryName = (string)reader["name"];
                        categories.Add(new Category(categoryID, categoryName));
                    }
                }
            }

            return categories;
        }

        public static List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();

                var queryString = "SELECT * FROM \"Category\"";

                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int categoryID = (int)reader["categoryID"];
                        string categoryName = (string)reader["name"];
                        categories.Add(new Category(categoryID, categoryName));
                    }
                }
            }

            return categories;
        }

        public static void AddCategory(string categoryName)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Category\"(\"name\") VALUES (@categoryName)", connection))
            {
                cmd.Parameters.AddWithValue("@categoryName", categoryName);
                cmd.ExecuteNonQuery();
            }

        }

        // Eliminar Cliente
        public static void DeleteCategory(int categoryID)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Category\" WHERE \"categoryID\" = @categoryID", connection))
            {
                cmd.Parameters.AddWithValue("@categoryID", categoryID);
                cmd.ExecuteNonQuery();
            }
        }

        public static async Task<bool> UpdateCategory(Category category)
        {
            int result = 0;
            if (category != null)
            {
                await using NpgsqlConnection connection = new NpgsqlConnection(s_connectionString);
                connection.Open();
                await using NpgsqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE public.\"Category\" SET  \"name\"=@categoryName WHERE \"categoryID\" = @categoryID;";
                command.Parameters.AddWithValue("@categoryName", category.categoryName);
                command.Parameters.AddWithValue("@categoryID", category.id);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }
    }
}
