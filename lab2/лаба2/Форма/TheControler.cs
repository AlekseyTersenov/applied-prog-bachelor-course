using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Форма
{
    class TheControler : Controller
    {
        private TheModel model = new TheModel("TestFile.txt");

        public string[] GetDataFromModel()
        {
            string[] Data=model.Read();
            return Data;
        }

        public void SetDataToModel(string Text)
        {
            model.Write(Text);
        }
    }
}
