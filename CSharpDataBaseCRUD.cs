using System;
using System.ComponentModel.Design;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CSharpDataBase
{
    internal static class CSharpDataBaseCRUD
    {
        static void Main(string[] args)
        {
            #region Kategori ekleme işlemi 
            /*
            Console.WriteLine("********** Menü Sipariş İşlem Paneli **********");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");

            string CategoryName = Console.ReadLine();
            SqlConnection connection = new SqlConnection(
                   @"Server=localhost; 
                    Database=master; 
                    Integrated Security=True; 
                    TrustServerCertificate=True;" 
               );
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into CategoryTable (category_name) values (@p1)", connection);
            sqlCommand.Parameters.AddWithValue("@p1", CategoryName);//Kullanıcıdan Aldığımız Veriyi @P1 E yani category name e atıyoruz
            sqlCommand.ExecuteNonQuery();//İstisnasız sql e yansıtan kod
            connection.Close();
            Console.WriteLine("Kategori Başarıyla Eklendi");
              */

            #endregion
            #region Ürün ekleme işlemi
            /*
            string productnames;
            decimal productprice;
            //  bool productstatus;
            Console.WriteLine("Ürün Adı: ");
            productnames = Console.ReadLine();
            Console.WriteLine("Ürün Fiyatı: ");
            productprice = Decimal.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection(
              @"Server=localhost;
                Database=master;
                Integrated Security=True;
                TrustServerCertificate=True;
              ");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Producttab (Product_Name,Product_Price,Product_Status)values(@productName,@productPrice,@productStatus)", connection);
            command.Parameters.AddWithValue("@productName", productnames);
            command.Parameters.AddWithValue("@productPrice", productprice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Kaydetme Başarılı: ");
            Console.ReadKey();
            */
            #endregion

            #region  data çekme
            /*
             SqlConnection connection = new SqlConnection(
              @"Server=localhost;
                Database=master;
                Integrated Security=True;
                TrustServerCertificate=True;
              ");
              connection.Open();
              SqlCommand command1 =new SqlCommand("Select * From Producttab",connection);
              SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(command1);
              DataTable dataTable=new DataTable();
              sqlDataAdapter.Fill(dataTable);
              foreach(DataRow row in  dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            connection.Close();
            */
            #endregion

            #region silme
            /*
            Console.WriteLine("Silinecek İd giriniz: ");
            int ProId = int.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection(
             @"Server=localhost;
                Database=master;
                Integrated Security=True;
                TrustServerCertificate=True;
              ");
            connection.Open();
            SqlCommand command1 = new SqlCommand("Delete From Producttab Where Product_id = @productId", connection);
            command1.Parameters.AddWithValue("@productId", ProId);
            command1.ExecuteNonQuery();
            Console.WriteLine("Silme İşlemi Başarılı");
            */
            #endregion
            #region  Güncelleme
            Console.WriteLine("Güncellenecek Ürün İd: ");
            int Product_idd = int.Parse(Console.ReadLine());
            Console.WriteLine("Güncellenecek Ürün Adı: ");
            string Product_Namee = Console.ReadLine();
            Console.WriteLine("Güncellenecek Ürün Fiyatı: ");
            decimal Product_Pricee = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection(
            @"Server=localhost;
                Database=master;
                Integrated Security=True;
                TrustServerCertificate=True;
              ");
            connection.Open();
            SqlCommand command1 = new SqlCommand("Update Producttab Set Product_Name = @productName,Product_Price=@productPrice where Product_id=@productId", connection);
            command1.Parameters.AddWithValue("@productName", Product_Namee);
            command1.Parameters.AddWithValue("@productId", Product_idd);
            command1.Parameters.AddWithValue("@productPrice", Product_Pricee);
            command1.ExecuteNonQuery();
            connection.Close();
            Console.Write("Güncelleme Başarılı");
            #endregion

        }

    }
}
