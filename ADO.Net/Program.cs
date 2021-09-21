using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADO.Net
{
    class Program
    {
        static string constr = "Data Source=DESKTOP-R51IBF6;Initial Catalog=KKTextiles;User ID=superadmin;Password=admin@KK;Pooling=False";
        static void Main(string[] args)
        {
            Console.WriteLine("Items are: \n");
            
            foreach(var item in GetItems())
            {
                Console.WriteLine($"{item.Id}, {item.ItemName}, {item.UOM}, {item.Value}");
            }
              


        }
        // Connected Orientature
        public static List<Items> GetItems()
        {
            List<Items> items = new List<Items>();
            string qry = "select * from Item.Items";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                items.Add(new Items
                {
                    Id = reader[0].ToString(),
                    ItemName = reader[1].ToString(),
                    Value = reader[2].ToString(),
                    UOM = reader[3].ToString()
                });
            }
            connection.Close();
            return items;
        }
        /// <summary>
        ///     disconnected orientature
        /// </summary>
        /// <returns>EMployee List</returns>
        public static List<Employee> GetEmployees()
        {
            List<Employee> emps = new List<Employee>();
            string qry = "select * from Security.Employee";
            SqlConnection connection = new SqlConnection(constr);
            
            SqlDataAdapter adapter = new SqlDataAdapter(qry, connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            for(int i=0; i < data.Tables[0].Rows.Count;)
            {
                emps.Add(new Employee
                {
                    EmpId = data.Tables[0].Rows[i][0].ToString(),
                    EmpName = data.Tables[0].Rows[i][1].ToString(),
                    Designation = data.Tables[0].Rows[i][2].ToString(),
                    Salary = data.Tables[0].Rows[i][3].ToString()
                }) ;
            }
            return emps;
        }
        public static void InsertEmployee()
        {
            List<Items> items = new List<Items>();
            string qry = "insert into Security.Employee select '101','Krishna','Developer','100000'";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand command = new SqlCommand(qry, connection);
            int i = command.ExecuteNonQuery();
            connection.Close();
            if(i==1)
            {
                Console.WriteLine("Inserted Successfully");
            }
        }
    }

    class Items
    {
        public string Id { get; set; }
        public string ItemName { get; set; }
        public string Value { get; set; }
        public string UOM { get; set; }
    }
    class Employee
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public string Salary { get; set; }
    }
}

