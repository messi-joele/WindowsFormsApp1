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
    public partial class ricerca : Form
    {
        public ricerca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menu.txt");
            string x = textBox1.Text;
            string y = sr.ReadLine();
            while (y != null)
            {
                string nome = y.Split(';')[0];
                if (nome == x && y.Split(';')[7] == "True")
                {
                    string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\nPortata: {y.Split(';')[2]}\nIngredienti: {y.Split(';')[3]}-{y.Split(';')[4]}-{y.Split(';')[5]}-{y.Split(';')[6]} ";
                    MessageBox.Show(n);
                }
                y = sr.ReadLine();
            }
        }
    }
}
