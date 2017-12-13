using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History_VAR.Classes
{
    class Image
    {
        private string ImageFileName;
        private byte[] ImageData;


        public Image(string filename, byte[] data)
        {
            this.ImageFileName = filename;
            this.ImageData = data;
        }

        public string ReturnFileName()
        {
            return this.ImageFileName;
        }

        public byte[] ReturnImageData()
        {
            return this.ImageData;
        }
    }
}
