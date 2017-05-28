using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class TheModelWrite : ModelWrite 
    {
        private string fileName;

        public TheModelWrite(string File)
        {
            fileName = File;
        }

        
        
        public void Write(string Text)
        {
            FileStream stream = new FileStream(fileName, FileMode.Append);
            StreamWriter w = new StreamWriter(stream);
            w.Write(Text);
            w.Close();
        }
    }
}
