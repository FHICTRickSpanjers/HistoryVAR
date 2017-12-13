using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace History_VAR.Classes
{
    class Image
    {
        int Image_ID;
        private string ImageFileName;
        private byte[] ImageData;


        public Image(int ID, string filename, byte[] data)
        {
            this.ImageFileName = filename;
            this.ImageData = data;
            this.Image_ID = ID;
        }

        public string ReturnFileName()
        {
            return this.ImageFileName;
        }

        public byte[] ReturnImageData()
        {
            return this.ImageData;
        }

        public int ReturnImageID()
        {
            return this.Image_ID;
        }
    }
}
