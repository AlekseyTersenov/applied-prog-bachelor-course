using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// richTextBox1.Clear();
namespace Форма
{
    public partial class Form1 : Form
    {
        private TheControler contr = new TheControler();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox1.Clear();
            string text;
            text = textBox1.Text;
            contr.SetDataToModel(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(string line in contr.GetDataFromModel())
            {
                richTextBox1.AppendText(line);
            }
           
        }

    }
}
