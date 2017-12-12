using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History_VAR.Classes
{
    class Student
    {
        private string StudentName;
        private int StudentID;
        private int SchoolID;

        public Student(int stuID, string StuName, int SchoID)
        {
            this.StudentID = stuID;
            this.StudentName = StuName;
            this.SchoolID = SchoID;
        }

        public string GetStudentName()
        {
            return StudentName;
        }

        public int GetStudentID()
        {
            return StudentID;
        }

        public int GetStudentSchoolID()
        {
            return SchoolID;
        }


     
    }
}
