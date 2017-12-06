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
                            ResultQuery = dr["Teacher_password"].ToString();
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



        //Make new Lesson (set)
        public void CreateNewLesson(string lesson_subject, int teacherid, string lesson_name, string lesson_status, string lesson_desc)
        {

            try
            {

                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }

                    SqlCommand NewCmd = cnn.CreateCommand();
                    NewCmd.Connection = cnn;
                    NewCmd.CommandType = CommandType.Text;
                    NewCmd.CommandText = "INSERT INTO Lesson (Lesson_subject, Teacher_ID, Lesson_Name, Lesson_Status, Lesson_Description) VALUES (@Lesson_Subject, @Teacher_ID, @Lesson_Name, @Lesson_Status, @Lesson_Description)";

                    NewCmd.Parameters.AddWithValue("@Lesson_Subject", lesson_subject);
                    NewCmd.Parameters.AddWithValue("@Teacher_ID", teacherid);
                    NewCmd.Parameters.AddWithValue("@Lesson_Name", lesson_name);
                    NewCmd.Parameters.AddWithValue("@Lesson_Status", lesson_status);
                    NewCmd.Parameters.AddWithValue("@Lesson_Description", lesson_desc);

                    NewCmd.ExecuteNonQuery();

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        //Insert Artobjects per lesson
        public void Insert_Artobjects_In_lessons(int lessonid, int artobjid)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    SqlCommand NewCmd = cnn.CreateCommand();
                    NewCmd.Connection = cnn;
                    NewCmd.CommandType = CommandType.Text;
                    NewCmd.CommandText = "INSERT INTO LessonObj (Lesson_ID, Art_ID) VALUES (@Lesson_ID, @Art_ID)";

                    NewCmd.Parameters.AddWithValue("@Lesson_ID", lessonid);
                    NewCmd.Parameters.AddWithValue("@Art_ID", artobjid);
                    NewCmd.ExecuteNonQuery();

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        //Insert ArtObjects into Database
        public void Insert_Artobjects(string title, string type, string creator, string movement, int YearMade, string periode, string city, 
            string country,  decimal width, decimal height, decimal length,  string material, string original_located, string description)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    SqlCommand NewCmd = cnn.CreateCommand();
                    NewCmd.Connection = cnn;
                    NewCmd.CommandType = CommandType.Text;
                    NewCmd.CommandText = "INSERT INTO ArtObj (Art_title, Art_type, Art_movement, Art_year, Art_periode, Art_city, " +
                        "Art_country, Art_width, Art_height, Art_length, Art_material, Art_where_is_original_located, Art_description) " +
                        "VALUES " +
                        "(@Art_title, @Art_type, @Art_movement, @Art_year, @Art_periode, @Art_city, " +
                        "@Art_country, @Art_width, @Art_height, @Art_length, @Art_material, @Art_where_is_original_located, @Art_description)";

                    NewCmd.Parameters.AddWithValue("@Art_title", title);
                    NewCmd.Parameters.AddWithValue("@Art_type", type);
                    NewCmd.Parameters.AddWithValue("@Art_movement", movement);
                    NewCmd.Parameters.AddWithValue("@Art_year", YearMade);
                    NewCmd.Parameters.AddWithValue("@Art_periode", periode);
                    NewCmd.Parameters.AddWithValue("@Art_city", city);
                    NewCmd.Parameters.AddWithValue("@Art_country", country);
                    NewCmd.Parameters.AddWithValue("@Art_width", width);
                    NewCmd.Parameters.AddWithValue("@Art_height", height);
                    NewCmd.Parameters.AddWithValue("@Art_length", length);
                    NewCmd.Parameters.AddWithValue("@Art_material", material);
                    NewCmd.Parameters.AddWithValue("@Art_where_is_original_located", original_located);
                    NewCmd.Parameters.AddWithValue("@Art_description", description);
                    NewCmd.ExecuteNonQuery();

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        //Select all lessons
        public List<string> Get_Lessons_Data()
        {
            List<string> listOfLessons = new List<string>();

            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    string query = "SELECT * FROM Lesson";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lesson L = new Lesson(dr["Lesson_name"].ToString());
                            listOfLessons.Add(L.GetLessonName());
                        }
                    }

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return listOfLessons;
        }


        public int GetLessonID(string name)
        {

            int LessonID = 0;

            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    string query = "SELECT Lesson_ID FROM Lesson WHERE Lesson_name = @Lesson_Name";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@Lesson_Name", name);
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lesson L = new Lesson(Convert.ToInt32(dr["Lesson_ID"]));
                            LessonID = L.GetLessonID();
                        }
                    }

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return LessonID;
        }


        public void Delete_Lesson_By_ID(int Lesson_ID)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    string query = "DELETE FROM Lesson WHERE Lesson_ID = @Lesson_ID";
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Lesson_ID", Lesson_ID);
                    cnn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //Select Lesson status
        public string Get_Lesson_Status(int lessonid)
        {
            string status = "";

            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    string query = "SELECT * FROM Lesson";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lesson L = new Lesson();
                            L.SetLessonStatus(dr["Lesson_status"].ToString());
                            status =  L.GetLessonStatus();
                        }
                    }

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return status;
        }


        //Update lesson status
        public void Update_Lesson_Status_By_ID(int Lesson_ID, string status)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    string query = "UPDATE Lesson SET Lesson_status=@Lesson_status WHERE Lesson_ID = @Lesson_ID";

                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Lesson_ID", Lesson_ID);
                    cmd.Parameters.AddWithValue("@Lesson_status", status);

                    cnn.Open();

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }


        //Select necessary data from lesson to udpate

        public string Get_Lesson_Data_By_ID(int Lesson_ID, string searchinfo)
        {
            string required_data = "";

            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    string query = "SELECT * FROM Lesson WHERE Lesson_ID = @Lesson_ID";
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Lesson_ID", Lesson_ID);
                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            required_data = dr[searchinfo].ToString();
                        }
                    }


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return required_data;
        }


        //Make new Lesson (set)
        public void UpdateLesson(int Lesson_ID, string lesson_subject, string lesson_name, string lesson_status, string lesson_desc)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Server=mssql.fhict.local;Database=dbi367493;User Id=dbi367493;Password=$5esa8);"))
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }

                    SqlCommand NewCmd = cnn.CreateCommand();
                    NewCmd.Connection = cnn;
                    NewCmd.CommandType = CommandType.Text;
                    NewCmd.CommandText = "UPDATE Lesson SET Lesson_subject=@Lesson_Subject, Lesson_name=@Lesson_Name, Lesson_status=@Lesson_Status, Lesson_description=@Lesson_Description WHERE Lesson_ID = @Lesson_ID";

                    NewCmd.Parameters.AddWithValue("@Lesson_Subject", lesson_subject);
                    NewCmd.Parameters.AddWithValue("@Lesson_Name", lesson_name);
                    NewCmd.Parameters.AddWithValue("@Lesson_Status", lesson_status);
                    NewCmd.Parameters.AddWithValue("@Lesson_Description", lesson_desc);
                    NewCmd.Parameters.AddWithValue("@Lesson_ID", Lesson_ID);

                    NewCmd.ExecuteNonQuery();

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
