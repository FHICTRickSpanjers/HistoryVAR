using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History_VAR.Classes
{
    class Group
    {
        private string GroupName;
        private List<Teacher> ListofTeachers = new List<Teacher>();
        private List<Student> ListofStudents = new List<Student>();
        private string schoolName;


        public Group()
        {

        }

        public List<Student> getStudents()
        {
            return ListofStudents;
        }

        public List<Teacher> getTeachers()
        {
            return ListofTeachers;
        }


    }
}
