using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class TheModelRead : Model
    {
        private string fileName;

        public TheModelRead(string File)
        {
            fileName = File;
        }


        public string Read()
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(stream);
            string res = r.ReadToEnd();
            r.Close();
            return res;
        }
    }
}

