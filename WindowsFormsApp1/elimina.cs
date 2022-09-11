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
    public partial class elimina : Form
    {
        public elimina()
        {
            InitializeComponent();
        }

        private void elimina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                StreamReader sr1 = new StreamReader("./menu.txt");
                string x = textBox1.Text;
                string stampatutto = null;
                string y = "negri";
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
                    }
                }
                sr1.Close();
                File.WriteAllText("./menu.txt", stampatutto);
                this.Close();
            }
            else
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
                            stampatutto += y.Split(';')[0] + sep + y.Split(';')[1] + sep + y.Split(';')[2] + sep + y.Split(';')[3] + sep + y.Split(';')[4] + sep + y.Split(';')[5] + sep + "False" + "\n";
                        }
                    }
                }
                sr1.Close();
                File.WriteAllText("./menu.txt", stampatutto);
                this.Close();
            }
        }
    }
}
