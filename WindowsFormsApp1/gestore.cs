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

namespace WindowsFormsApp1
{
    public partial class gestore : Form
    {
        public gestore()
        {
            InitializeComponent();
        }

        private void AGGIUNTA_Click(object sender, EventArgs e)
        {
            aggiunta form4 = new aggiunta();
            this.Visible = false;
            form4.ShowDialog();
            this.Visible = true;
        }

        private void gestore_Load(object sender, EventArgs e)
        {

        }

        private void VISUALIZZA_Click(object sender, EventArgs e)
        {
            visualizza form5 = new visualizza();
            this.Visible = false;
            form5.ShowDialog();
            this.Visible = true;
        }

        private void RICERCA_Click(object sender, EventArgs e)
        {
            ricerca form6 = new ricerca();
            this.Visible = false;
            form6.ShowDialog();
            this.Visible = true;
        }

        private void ELIMINA_Click(object sender, EventArgs e)
        {
            elimina form7 = new elimina();
            this.Visible = false;
            form7.ShowDialog();
            this.Visible = true;
        }

        private void MODIFICA_Click(object sender, EventArgs e)
        {
            modifica form8 = new modifica();
            this.Visible = false;
            form8.ShowDialog();
            this.Visible = true;
        }

        private void recupera_Click(object sender, EventArgs e)
        {
            recupera form9 = new recupera();
            this.Visible = false;
            form9.ShowDialog();
            this.Visible = true;
        }
    }
}
