using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History_VAR.Classes
{
    class Lesson
    {
        private string Subject;
        private int LessonID;
        private string Lesson_name;
        private string Lesson_status;
        private string Course;
        private List<ArtObject> ListofArtObjects = new List<ArtObject>();

        public Lesson(string LName)
        {
            Lesson_name = LName;
        }

        public Lesson(int ID)
        {
            LessonID = ID;
        }

        public Lesson()
        {

        }

        public string LessonStatus
        {
            get
            {
                return this.Lesson_status;
            }
            set
            {
                this.Lesson_status = value;
            }
        }
 

        public string GetLessonName()
        {
            return Lesson_name;
        }

        public int GetLessonID()
        {
            return LessonID;
        }

        public void Add_Object(ArtObject obj)
        {
            ListofArtObjects.Add(obj);
        }

        public void Delete_Object(ArtObject Obj)
        {
            
        }
    }
}
