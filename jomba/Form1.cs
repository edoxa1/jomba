using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace jomba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string[] text;
        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                s = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(s);
                text = sr.ReadToEnd().Split(' ');
                label1.Text = $"Количество пробелов: {text.Length - 1}";
                sr.Close();
            }
            
        }
    }
}
