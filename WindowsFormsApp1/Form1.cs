using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VERIFICA_Click(object sender, EventArgs e)
        {
            if(utente.Text == "gestore" && password.Text == "gestore")
            {
                gestore form2 = new gestore();
                this.Visible = false;
                form2.ShowDialog();
                this.Visible=true;
            }
            else
            {
                cliente form3 = new cliente();
                this.Visible = false;
                form3.ShowDialog();
                this.Visible = true;

            }
        }
    }
}
