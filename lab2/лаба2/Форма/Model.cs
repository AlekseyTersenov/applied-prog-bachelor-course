using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Форма
{
    interface Model
    {
        string[] Read();
        void Write(string Text);
    }
}
