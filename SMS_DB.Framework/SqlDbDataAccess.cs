using System;
using System.Data.SqlClient;

namespace SMS_NT.Framework
{
    public class SqlDbDataAccess
    {
        private const string ConnectiosnString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='G:\DEPATMENTALCOURSES\programing language\c #\Bijoy_shop_management\SMS_NT\SMS_NT.Databsae\SMS_DB.mdf';Integrated Security=True";


        public SqlCommand GetCommand(String query)
        {
            var connection = new SqlConnection(ConnectiosnString);

            var cmd = new SqlCommand(query) {Connection = connection};
            return cmd;
        }
    }
}