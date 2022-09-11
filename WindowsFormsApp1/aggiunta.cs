using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class aggiunta : Form
    {
        
        public aggiunta()
        {
            InitializeComponent();
        }

       
        private void aggiunta_Load(object sender, EventArgs e)
        {

        }
        public void Scrivi(string x)
        {
            using (StreamWriter sw = File.AppendText("./menu.txt"))
            {
                sw.WriteLine(x);
            }
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
           
                string x;
                string sep = ";";
                x = nome.Text + sep + prezzo.Text + sep + portata.Text + sep + Ingrediente1.Text + sep + Ingrediente2.Text + sep + Ingrediente3.Text + sep + Ingrediente4.Text + sep +"True";
                Scrivi(x);
                this.Close();                    
        }
    }
}
