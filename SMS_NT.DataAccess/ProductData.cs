using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SMS_NT.Entities;
using SMS_NT.Framework;

namespace SMS_NT.DataAccess
{
    public class ProductData
    {
        public List<ProductInfo> GetProductInfo()
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Product");

            List<ProductInfo> productList = GetData(cmd);
            return productList;
        }

        public DataTable GetProductInfoTable()
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Product");
            var dt = new SqlDataAdapter(cmd);

            cmd.Connection.Open();
            var tbl = new DataTable();
            dt.Fill(tbl);
            cmd.Connection.Close();
            return tbl;
        }

        public List<ProductInfo> GetProductInfoByName(String Pname)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * FROM Product WHERE Pname =@Pname ");

            var p1 = new SqlParameter("@Pname", SqlDbType.VarChar, 50) {Value = Pname};

            cmd.Parameters.Add(p1);

            List<ProductInfo> productList = GetData(cmd);
            return productList;
        }

        public bool Insert(ProductInfo obj)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd =
                da.GetCommand(
                    "INSERT INTO [dbo].[Product] ([Pname],[price],[quan],[unit]) VALUES (@pname,  @price, @quan,@unit)");

            var p1 = new SqlParameter("@Pname", SqlDbType.VarChar, 50) {Value = obj.Pname};

            var p2 = new SqlParameter("@price", SqlDbType.VarChar, 50) {Value = obj.Price};

            var p3 = new SqlParameter("@quan", SqlDbType.Int) {Value = obj.Quan};

            var p4 = new SqlParameter("@unit", SqlDbType.VarChar) {Value = obj.Unit};

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }

        public bool Delete(int id)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd =
                da.GetCommand("DELETE FROM [dbo].[Product] WHERE id=@id");

            var p1 = new SqlParameter("@id", SqlDbType.VarChar, 50) {Value = id};


            cmd.Parameters.Add(p1);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }

        public bool UpdateQuan(string price, int id, int quan, String unit)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd =
                da.GetCommand("update [dbo].[Product] SET quan = @quan,price=@price,unit=@unit WHERE  id = @id");

            var p1 = new SqlParameter("@price", SqlDbType.VarChar, 50) {Value = price};
            var p2 = new SqlParameter("@quan", SqlDbType.Int) {Value = quan};
            var p3 = new SqlParameter("@id", SqlDbType.Int) {Value = id};
            var p4 = new SqlParameter("@unit", SqlDbType.VarChar, 50) {Value = unit};

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }

        private List<ProductInfo> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            var list = new List<ProductInfo>();


            while (reader.Read())
            {
                var obj = new ProductInfo
                {
                    Id = reader.GetInt32(0),
                    Pname = reader.GetString(1),
                    Price = reader.GetString(2),
                    Quan = reader.GetInt32(3),
                    Unit = reader.GetString(4)
                };
                list.Add(obj);
            }
            reader.Close();

            cmd.Connection.Close();

            return list;
        }
    }
}