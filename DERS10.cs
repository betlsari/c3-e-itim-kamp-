using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud -->Create-Read-Update-Delete
            Console.WriteLine("********Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= BETÜL\\SQLEXPRESS; initial catalog= eigitimkampi9; integrated security= true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Table_cat (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori Başareıyla Eklendi");
            #endregion
            #region Ürün Ekeleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;
            //Console.WriteLine( "Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.WriteLine("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=BETÜL\\SQLEXPRESS; initial catalog=eigitimkampi9; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into tableProdcut (ProductName,ProductPrice,ProductStatus) values (@ProductName,@ProductPrice,@ProductStatus)",connection);

            //command.Parameters.AddWithValue("@ProductName",productName);
            //command.Parameters.AddWithValue("@ProductPrice",productPrice);
            //command.Parameters.AddWithValue("@ProductStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ekleme Başarılı");













            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=BETÜL\\SQLEXPRESS; initial catalog=eigitimkampi9; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From tableProdcut",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();

            //connection.Close();

            //}



            #endregion

            #region Ürün Silme İşlemi
            //Console.WriteLine("Silinecek Ürün ID: ");
            //int productID=int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=BETÜL\\SQLEXPRESS; initial catalog=eigitimkampi9; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From tableProdcut Where ProductID=@productID",connection);  
            //command.Parameters.AddWithValue("@productID",productID);
            //command.ExecuteNonQuery();
            //Console.WriteLine("Silme İşlemi Yapıldı");











            /*connection.Close()*/;




            #endregion

            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncellenecek Üürn ID: ");
            //int productID = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı : ");
            //string productName = Console.ReadLine();

            //Console.Write( "Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice= decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=BETÜL\\SQLEXPRESS; initial catalog=eigitimkampi9; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update tableProdcut Set ProductName=@productName, ProductPrice=@productPrice where ProductID=@productID",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();




            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı");
            #endregion
            Console.Read();
        }
    }
}
