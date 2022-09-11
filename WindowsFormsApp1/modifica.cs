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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class modifica : Form
    {
        public modifica()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menu.txt");
            string x = ciboscelto.Text;
            string n = null;
            string y = sr.ReadLine();
            while (y != null)
            {
                if (x == y.Split(';')[0])
                {
                   
                     n += nome.Text;
                    
                    
                    n += ";";
                    
                        n += prezzo.Text;
                    
                    n += ";";
                   
                        n += portata.Text;
                    
                   
                    n += ";";
                   
                    n += ing1.Text;

                    n += ";";

                    n += ing2.Text;

                    n += ";";

                    n += ing3.Text;

                    n += ";";

                    n += ing4.Text;

                    
                    
                    n += ";" + y.Split(';')[6];

                }
                y = sr.ReadLine();
            }

            sr.Close();
            StreamReader sr1 = new StreamReader("./menu.txt");
            string stampatutto = null;
            y = "";
            while (y != null)
            {
                y = sr1.ReadLine();
                if (y != null)
                {
                    string z = y;
                    if (y.Split(';')[0] != ciboscelto.Text)
                    {
                        stampatutto += z;
                        stampatutto += "\n";
                    }
                    else
                    {
                        stampatutto += n;
                        stampatutto += "\n";
                    }
                }
            }
            sr1.Close();
            File.WriteAllText("./menu.txt", stampatutto);
            this.Close();
        }
    }
}
