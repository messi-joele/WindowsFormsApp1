using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class visualizza : Form
    {
        public visualizza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"./menu.txt";
            StreamReader stream = new StreamReader(path);
            string filedata = stream.ReadToEnd();
            richTextBox1.Text = filedata.ToString();
            stream.Close();
        }
    }
}
