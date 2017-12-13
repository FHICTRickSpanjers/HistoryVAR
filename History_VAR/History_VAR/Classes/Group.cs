using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace History_VAR.Classes
{
    class Group
    {
        private int GroupID;
        private string GroupName;
        private List<Teacher> ListofTeachers = new List<Teacher>();
        private List<Student> ListofStudents = new List<Student>();
        private string schoolName;


        public Group()
        {

        }

        public Group(string name)
        {
            this.GroupName = name;
        }

        public Group(int GroupID)
        {
            this.GroupID = GroupID;
        }

        public Group(int GroupID, string GroupName)
        {
            this.GroupID = GroupID;
            this.GroupName = GroupName;
        }

        public string GetGroupName()
        {
            return this.GroupName;
        }

        public List<Student> getStudents()
        {
            return ListofStudents;
        }

        public List<Teacher> getTeachers()
        {
            return ListofTeachers;
        }

        public int Get_Group_ID()
        {
            return GroupID;
        }

        public List<Student> StudentsInGroup
        {
            get{
               return this.ListofStudents;
            }
            set{
                this.ListofStudents = value;
            }
        }


    }
}
