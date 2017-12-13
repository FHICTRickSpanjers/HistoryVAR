using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace History_VAR.Classes
{
    class Teacher
    {
        private int TeacherID;
        private string TeacherName;
        private string SchoolName;

        public Teacher()
        {

        }

        public Teacher(string name)
        {
            this.TeacherName = name;
        }
        public string GetTeacherName()
        {
            return this.TeacherName;
        }

        public int TeacherIdentification
        {
            get
            {
                return this.TeacherID;
            }
            set
            {
                this.TeacherID = value;
            }
        }
    }
}
