using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("****** C# Veri Tabanalı Ürün-Kategöri Sistemi ******");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Yazınız: ");
            tableNumber= Console.ReadLine();
            Console.WriteLine("------------------------------");

            SqlConnection connection = new SqlConnection("Data Source= BETÜL\\SQLEXPRESS; initial Catalog=eigitimkampi9;integrated security= true");
            connection.Open();
            SqlCommand commant = new SqlCommand("Select *From Table_cat",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commant);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                
            }







            Console.Read();


        }
    }
}
