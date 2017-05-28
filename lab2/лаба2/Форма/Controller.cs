using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Форма
{
    interface Controller
    {
        void SetDataToModel(string Text);
        string[] GetDataFromModel();
    }
}
