using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History_VAR.Classes
{
    class DBRepository
    {

        //Instance always null
        private static DBRepository instance = null;

        //Empty constructor
        private DBRepository()
        {

        }

        //Create Instance
        public static DBRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new DBRepository();
            }
            return instance;
        }



        //Teacher Login
        public string Get_Login_Data_Teachers(string username)
        {
            string ResultQuery = "";

            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    string query = "SELECT Teacher_password FROM Teacher WHERE Teacher_username = @username";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ResultQuery =  dr["Teacher_password"].ToString();
                        }
                    }

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return ResultQuery;
        }


        //Student Login
        public string Get_Login_Data_Student(string username)
        {
            string ResultQuery = "";

            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    string query = "SELECT Student_password FROM Student WHERE Student_username = @username";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ResultQuery = dr["Student_password"].ToString();
                        }
                    }

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return ResultQuery;
        }


    }
}
