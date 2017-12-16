using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class DB_Operation
    {
        SqlConnection conn;
        public static string connection = @"Data Source=DESKTOP-3RES620;Initial Catalog=StokDB;Integrated Security=True";
        //public static string connection = @"Data Source=TOSHIBAPC\SQLEXPRESS;Initial Catalog=StokDB;Integrated Security=True";
        public List<string[]> Select(string command, List<string> keys, List<string> values)
        {
            SqlConnection conn = new SqlConnection(connection);

                
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(command, conn);

                for (int i = 0; i < keys.Count; i++)
                    sqlCommand.Parameters.AddWithValue("@" + keys[i], values[i]);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                List<string[]> result = new List<string[]>();

                while (sqlReader.Read())
                {
                    string[] tmp = new string[sqlReader.FieldCount];
                    for (int i = 0; i < sqlReader.FieldCount; i++)
                        tmp[i] = sqlReader[i].ToString();

                    result.Add(tmp);
                }
                return result;
            
        }
        public List<string[]> Select(string command)
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(command, conn);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            List<string[]> result = new List<string[]>();

            while (sqlReader.Read())
            {
                string[] tmp = new string[sqlReader.FieldCount];
                for (int i = 0; i < sqlReader.FieldCount; i++)
                    tmp[i] = sqlReader[i].ToString();

                result.Add(tmp);
            }
            return result;

        }

        public bool Save(string command, List<string> keys, List<string> values)
        {
            using (conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand(command, conn);
                for (int i = 0; i < keys.Count; i++)
                    sqlCommand.Parameters.AddWithValue("@" + keys[i], values[i]);

                int success = sqlCommand.ExecuteNonQuery();
                if (success <= 0)
                    return false;
            }
            return true;
        }
        public bool Delete(string command, List<string> keys, List<string> values)//DÜZENLEME YAP
        {
            using (conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand(command, conn);
                for (int i = 0; i < keys.Count; i++)
                    sqlCommand.Parameters.AddWithValue("@" + keys[i], values[i]);

                int success = sqlCommand.ExecuteNonQuery();
                if (success <= 0)
                    return false;
            }
            return true;
        }
        public bool Update(string command, List<string> keys, List<string> values)
        {
            using (conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand(command, conn);
                for (int i = 0; i < keys.Count; i++)
                    sqlCommand.Parameters.AddWithValue("@" + keys[i], values[i]);

                int success = sqlCommand.ExecuteNonQuery();
                if (success <= 0)
                    return false;
            }
            return true;
        }

        public static object sonindex;
        public bool Save2(string command, List<string> keys, List<string> values)
        {
            using (conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand(command, conn);
                for (int i = 0; i < keys.Count; i++)
                    sqlCommand.Parameters.AddWithValue("@" + keys[i], values[i]);
                
                int success = sqlCommand.ExecuteNonQuery();
                
                if (success <= 0)
                    return false;

                string command2 = "Select @@Identity";
                SqlCommand sqlCommand2 = new SqlCommand(command2, conn);
                sonindex = sqlCommand2.ExecuteScalar();
            }
            
            return true;
        }
    }
}
