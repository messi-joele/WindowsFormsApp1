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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }
        string[] lista = new string[1000];
        public void Scrivi(string x)
        {
            using (StreamWriter sw = File.AppendText("./ordine.txt"))
            {
                sw.WriteLine(x);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menu.txt"); ;
            string y = sr.ReadLine();
            int count = 0;
            while (y != null)
            {
                if (y.Split(';')[7] == "True")
                {
                    lista[count] = $"Nome: {y.Split(';')[0]}Prezzo:{y.Split(';')[1]}Portata: {y.Split(';')[2]}Ingredienti: {y.Split(';')[3]}- {y.Split(';')[4]}-{y.Split(';')[5]} -{y.Split(';')[6]}";
                    listBox1.Items.Add(lista[count]);
                }
                y = sr.ReadLine();
                count++;
            }
            sr.Close();
        }

        private void cliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x;
            string sep = ";";
            x = primo.Text + sep + secondo.Text + sep + dolce.Text;
            Scrivi(x);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dolce_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
