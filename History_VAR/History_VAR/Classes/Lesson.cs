using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History_VAR.Classes
{
    class Lesson
    {
        private string Lesson_subject;
        private int LessonID;
        private string Lesson_name;
        private string Lesson_status;
        private string Lesson_desc;
        private List<ArtObject> ListofArtObjects = new List<ArtObject>();

        public Lesson(string LName, int LessonID, string lessonstatus, string lessondesc, string lessonsubject)
        {
            this.Lesson_name = LName;
            this.LessonID = LessonID;
            this.Lesson_status = lessonstatus;
            this.Lesson_desc = lessondesc;
            this.Lesson_subject = lessonsubject;
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

        public string GetLessonDesc()
        {
            return Lesson_desc;
        }

        public string GetLessonSubject()
        {
            return Lesson_subject;
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
