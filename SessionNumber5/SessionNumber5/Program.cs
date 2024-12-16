using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SessionNumber5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();


            Employee employee = new Employee
            {
                Id = 1,
                Name = "Ahmed",
                Department = "Information Technology"
            };

            //string json = JsonConvert.SerializeObject(employee);

            //string path = "E:\\Courses\\MyCoursesMaterials\\DigitalEgypt\\Round 2\\file.txt";
            //File.WriteAllText(path, json);

            //string jsonData = File.ReadAllText(path);

            //Employee employee = JsonConvert.DeserializeObject<Employee>(jsonData);

            //Console.WriteLine(employee.Id);
            //Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.Department);

            //XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            //using(StringWriter sw = new StringWriter())
            //{
            //    serializer.Serialize(sw, employee);
            //    string xml = sw.ToString(); 

            //    File.WriteAllText(path, xml);   
            //}


            //string xmlString = File.ReadAllText(path);
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));  
            //using(StringReader  sr = new StringReader(xmlString))
            //{
            //    Employee emp = (Employee)xmlSerializer.Deserialize(sr);
            //    Console.WriteLine(emp.Id);
            //    Console.WriteLine(emp.Name);
            //    Console.WriteLine(emp.Department);
            //}
            /*
             * REST API
            {
              "Id": 1,
              "Name": "Ahmed",
              "Department" : "Information Technology"
            }

            SOAP
            <xml>
                <Id>1</Id>
                <Name>Ahmed</Name>
                <Department>Information Technology</Department>
            </xml>
            */
            //Serilization  Data  Deserilization    
            //Application A ====> Application B
            //

            //1- JSON -> javascript object notation
            //2- XML
            //3- Binary

            //Employee employee1 = new Employee
            //{
            //    Id = 1,
            //    Name = "tst",
            //    Department = "Information Technology",
            //    Status = EmployeeStatus.Retired
            //};

            //if (employee1.Status != EmployeeStatus.Active)
            //{
            //    Console.WriteLine("Employee is not one of our employee anymore");
            //}

            //"Employed",
            //"Terminated",
            //"Resigned",
            //"retired"

            //ADO.net
            //activex Data Object
            // sql server,mysql ,oracle database

            //1- to open a connection with the database
            //2- to execute scripts on the database
            //3- to read data from the database
            //4- close the connection with the database
            //try
            //{
            //    string connectionString = "Data Source=DESKTOP-TDIEBBV\\SQLEXPRESS01;Initial Catalog=OnlineStoreDb;Integrated Security=True;Trust Server Certificate=True";
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();

            //        SqlCommand sqlCommand = connection.CreateCommand();
            //        sqlCommand.CommandText = "update production.products set model_year = 1999 where sdfsdf product_id < 9";
            //        sqlCommand.CommandType = CommandType.Text;

            //        int rowsEffected = sqlCommand.ExecuteNonQuery();
            //        if (rowsEffected > 0)
            //        {
            //            Console.WriteLine("data updated successfuly");
            //        }
            //    }

            //}
            //catch (SqlException ex)
            //{
            //    Console.WriteLine("Exception while excuting query => " + ex.Message.ToString());
            //}

            CategoryList categoryList = new CategoryList();
            categoryList.SaveCategoriesToFile();

            foreach(Category category in categoryList.GetCategories()) {
                Console.WriteLine(category.Category_id);
                Console.WriteLine(category.Category_name);
                Console.WriteLine("====================================");
            }
            
            static void ReadUsingStoredProc()
            {
                string connectionString = "Data Source=DESKTOP-TDIEBBV\\SQLEXPRESS01;Initial Catalog=OnlineStoreDb;Integrated Security=True;Trust Server Certificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //string query = "select * from production.products;";

                    SqlCommand sqlCommand = connection.CreateCommand();
                    sqlCommand.CommandText = "GetAllProducts";
                    sqlCommand.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Category_id",
                        Direction = ParameterDirection.Input,
                        Value = 5
                    });
                    sqlCommand.CommandType = CommandType.StoredProcedure;


                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                    //SqlCommandBuilder sqlCommandBuilder =
                    //                    new SqlCommandBuilder(adapter);

                    DataSet dbSet = new DataSet();
                    adapter.Fill(dbSet);

                    DataTable tableProducts = dbSet.Tables[0];
                    //DataRow dataRow = tableProducts.Rows[0];

                    //dataRow["product_name"] = "Test test";
                    //dataRow["model_year"] = "2025";
                    //adapter.Update(dbSet);
                    foreach (DataRow dbRow in tableProducts.Rows)
                    {
                        Console.WriteLine($"ProductId => {dbRow["product_id"]}, " +
                                              $"ProductName => {dbRow["product_name"]}");
                    }

                }
            }

            static void ReadUsingDataAdapter()
            {
                string connectionString = "Data Source=DESKTOP-TDIEBBV\\SQLEXPRESS01;Initial Catalog=OnlineStoreDb;Integrated Security=True;Trust Server Certificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "select * from production.products;" +
                                   "select * from production.categories;";

                    SqlCommand sqlCommand = connection.CreateCommand();
                    sqlCommand.CommandText = query;


                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    DataSet dbSet = new DataSet();
                    adapter.Fill(dbSet);

                    DataTable tableProducts = dbSet.Tables[0];
                    DataTable tableCategories = dbSet.Tables[1];
                    foreach (DataRow dbRow in tableProducts.Rows)
                    {
                        Console.WriteLine($"ProductId => {dbRow["product_id"]}, " +
                                              $"ProductName => {dbRow["product_name"]}");
                    }
                    Console.WriteLine("===========================================================");
                    foreach (DataRow dbRow in tableCategories.Rows)
                    {
                        Console.WriteLine($"category_id => {dbRow["category_id"]}," +
                                          $"category_name => {dbRow["category_name"]}");
                    }
                }
            }

            static void ReadUsingDataReader()
            {
                string connectionString = "Data Source=DESKTOP-TDIEBBV\\SQLEXPRESS01;Initial Catalog=OnlineStoreDb;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //2- Command
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "Select * from production.products";
                    sqlCommand.Connection = connection;

                    //3- DataReader

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Console.WriteLine($"ProductId => {dataReader["product_id"]}, " +
                                              $"ProductName => {dataReader["product_name"]}");
                        }
                    }

                    //4- DataAdapter (DataSet,DataTable)
                }
            }
        }
    }
}
