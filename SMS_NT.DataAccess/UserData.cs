using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SMS_NT.Entities;
using SMS_NT.Framework;

namespace SMS_NT.DataAccess
{
    public class UserData
    {
        public List<UserInfo> GetuserInfo(String uname, string pass)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * FROM Userinfo WHERE uname = @uname and pass = @pass");

            var p1 = new SqlParameter("@uname", SqlDbType.VarChar, 50) {Value = uname};

            var p2 = new SqlParameter("@pass", SqlDbType.VarChar, 50) {Value = pass};

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            List<UserInfo> user = GetData(cmd);
            return user;
        }

        public DataTable GetUserInfoTable()
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Userinfo");
            var dt = new SqlDataAdapter(cmd);

            cmd.Connection.Open();
            var tbl = new DataTable();
            dt.Fill(tbl);
            cmd.Connection.Close();
            return tbl;
        }

        public bool Insert(UserInfo obj)
        {
            var da = new SqlDbDataAccess();
            SqlCommand cmd =
                da.GetCommand("INSERT INTO [dbo].[Userinfo] ([uname],[pass]) VALUES (@uname,  @pass)");

            var p1 = new SqlParameter("@uname", SqlDbType.VarChar, 50) {Value = obj.Uname};

            var p2 = new SqlParameter("@pass", SqlDbType.VarChar, 50) {Value = obj.Pass};


            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);


            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }

        private List<UserInfo> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            var list = new List<UserInfo>();


            while (reader.Read())
            {
                var obj = new UserInfo
                {
                    Uname = reader.GetString(0),
                    Pass = reader.GetString(1),
                    type = reader.GetInt32(2)
                };
                list.Add(obj);
            }
            reader.Close();

            cmd.Connection.Close();

            return list;
        }
    }
}