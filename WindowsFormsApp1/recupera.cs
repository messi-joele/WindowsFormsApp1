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
    public partial class recupera : Form
    {
        public recupera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr1 = new StreamReader("./menu.txt");
            string stampatutto = null;
            string y = "";
            while (y != null)
            {
                y = sr1.ReadLine();
                if (y != null)
                {
                    string z = y;
                    if (y.Split(';')[0] != textBox1.Text)
                    {
                        stampatutto += z;
                        stampatutto += "\n";
                    }
                    else
                    {
                        string sep = ";";
                        stampatutto += y.Split(';')[0] + sep + y.Split(';')[1] + sep + y.Split(';')[2] + sep + y.Split(';')[3] + sep + y.Split(';')[4] + sep + y.Split(';')[5] + sep + "True" + "\n";
                    }
                }
            }
            sr1.Close();
            File.WriteAllText("./menu.txt", stampatutto);
            this.Close();
        }

        private void recupera_Load(object sender, EventArgs e)
        {

        }
    }
}
