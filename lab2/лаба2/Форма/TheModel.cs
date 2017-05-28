using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Форма
{
    class TheModel : Model
    {
        private string fileName;

        public TheModel(string File)
        {
            fileName = File;
        }

        public string[] Read()
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(stream);

            List<string> array = new List<string>();

            while(!r.EndOfStream)
            {
                array.Add(r.ReadLine());
            }

            r.Close();
            return array.ToArray();
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
