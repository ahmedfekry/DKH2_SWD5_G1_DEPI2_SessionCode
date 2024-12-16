using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber5
{
    internal class CategoryList
    {
        private List<Category> _categories;

        public CategoryList()
        {
            _categories = new List<Category>();

            try
            {
                string connectionString = @"Data Source=DESKTOP-TDIEBBV\SQLEXPRESS01;Initial Catalog=OnlineStoreDb;Integrated Security=True;Trust Server Certificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "select * from production.categories";
                    command.CommandType = System.Data.CommandType.Text;

                    using(SqlDataReader  reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category();
                            category.Category_id = int.Parse(reader["category_id"].ToString());
                            category.Category_name = reader["category_name"].ToString();
                            _categories.Add(category);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception in the database access");
            }
        }
        
        public List<Category> GetCategories()
        {
            return this._categories;
        }

        public void SaveCategoriesToFile()
        {
            List<Category> categories = this._categories;
            string json = JsonConvert.SerializeObject(categories);
            string path = "E:\\Courses\\MyCoursesMaterials\\DigitalEgypt\\Round 2\\file.txt";

            File.WriteAllText(path, json);
        }
    }
}
