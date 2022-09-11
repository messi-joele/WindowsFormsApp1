namespace WindowsFormsApp1
{
    partial class modifica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ciboscelto = new System.Windows.Forms.TextBox();
            this.ing1 = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.portata = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ing2 = new System.Windows.Forms.TextBox();
            this.ing3 = new System.Windows.Forms.TextBox();
            this.ing4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFICA CIBO";
            // 
            // ciboscelto
            // 
            this.ciboscelto.Location = new System.Drawing.Point(64, 81);
            this.ciboscelto.Name = "ciboscelto";
            this.ciboscelto.Size = new System.Drawing.Size(100, 20);
            this.ciboscelto.TabIndex = 1;
            // 
            // ing1
            // 
            this.ing1.Location = new System.Drawing.Point(228, 168);
            this.ing1.Name = "ing1";
            this.ing1.Size = new System.Drawing.Size(100, 20);
            this.ing1.TabIndex = 2;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(64, 168);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 3;
            // 
            // portata
            // 
            this.portata.Location = new System.Drawing.Point(64, 327);
            this.portata.Name = "portata";
            this.portata.Size = new System.Drawing.Size(100, 20);
            this.portata.TabIndex = 4;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(64, 249);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(100, 20);
            this.prezzo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "INGREDIENTI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PORTATA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PREZZO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "MODIFICA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ing2
            // 
            this.ing2.Location = new System.Drawing.Point(228, 212);
            this.ing2.Name = "ing2";
            this.ing2.Size = new System.Drawing.Size(100, 20);
            this.ing2.TabIndex = 11;
            // 
            // ing3
            // 
            this.ing3.Location = new System.Drawing.Point(228, 249);
            this.ing3.Name = "ing3";
            this.ing3.Size = new System.Drawing.Size(100, 20);
            this.ing3.TabIndex = 12;
            // 
            // ing4
            // 
            this.ing4.Location = new System.Drawing.Point(228, 287);
            this.ing4.Name = "ing4";
            this.ing4.Size = new System.Drawing.Size(100, 20);
            this.ing4.TabIndex = 13;
            // 
            // modifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 378);
            this.Controls.Add(this.ing4);
            this.Controls.Add(this.ing3);
            this.Controls.Add(this.ing2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.portata);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.ing1);
            this.Controls.Add(this.ciboscelto);
            this.Controls.Add(this.label1);
            this.Name = "modifica";
            this.Text = "modifica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ciboscelto;
        private System.Windows.Forms.TextBox ing1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox portata;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ing2;
        private System.Windows.Forms.TextBox ing3;
        private System.Windows.Forms.TextBox ing4;
    }
}