using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SMS_NT.Entities;
using SMS_NT.Framework;

namespace SMS_NT.DataAccess
{
    public class TransData
    {
        public List<TransInfo> GetTransInfo()
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Trans");

            List<TransInfo> transList = GetData(cmd);
            return transList;
        }

        public DataTable GetTransInfoTable()
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Trans");
            var dt = new SqlDataAdapter(cmd);

            cmd.Connection.Open();
            var tbl = new DataTable();
            dt.Fill(tbl);
            cmd.Connection.Close();
            return tbl;
        }

        public List<TransInfo> GetTransInfoByName(String pname)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * FROM Trans WHERE Pname lik '%@Pname%'");
            var p1 = new SqlParameter("@Pname", SqlDbType.VarChar, 50) {Value = pname};

            cmd.Parameters.Add(p1);

            List<TransInfo> transList = GetData(cmd);
            return transList;
        }


        public DataTable GetGpriceByDate(DateTime date)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT SUM(tprice) AS total FROM Trans WHERE date =@date");

            var p1 = new SqlParameter("@date", SqlDbType.VarChar, 50) {Value = date};

            cmd.Parameters.Add(p1);

            var dt = new SqlDataAdapter(cmd);

            cmd.Connection.Open();
            var tbl = new DataTable();
            dt.Fill(tbl);
            cmd.Connection.Close();
            return tbl;
        }

        private int GetGtotal(SqlCommand cmd)
        {
            cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            int gtotal = reader.GetInt32(1);
            reader.Close();
            cmd.Connection.Close();
            return gtotal;
        }

        public bool Insert(TransInfo obj)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd =
                da.GetCommand(
                    "INSERT INTO [dbo].[Trans] ([Pname],[quan],[tprice],[date]) VALUES (@pname, @quan,@price, @date)");

            var p1 = new SqlParameter("@Pname", SqlDbType.VarChar, 50) {Value = obj.Pname};

            var p2 = new SqlParameter("@quan", SqlDbType.Int) {Value = obj.Quan};

            var p3 = new SqlParameter("@price", SqlDbType.Float) {Value = obj.Tprice};

            var p4 = new SqlParameter("@date", SqlDbType.VarChar, 50) {Value = obj.Date};


            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }

        private List<TransInfo> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            var list = new List<TransInfo>();


            while (reader.Read())
            {
                var obj = new TransInfo
                {
                    Id = reader.GetInt32(0),
                    Pname = reader.GetString(1),
                    Quan = reader.GetInt32(2),
                    Tprice = reader.GetFloat(3),
                    Date = reader.GetString(4)
                };
                list.Add(obj);
            }
            reader.Close();

            cmd.Connection.Close();

            return list;
        }
    }
}