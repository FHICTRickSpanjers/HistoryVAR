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
        private string Course;
        private List<ArtObject> ListofArtObjects = new List<ArtObject>();


        public Lesson()
        {

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
