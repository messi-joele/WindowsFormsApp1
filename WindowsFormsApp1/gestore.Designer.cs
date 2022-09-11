namespace WindowsFormsApp1
{
    partial class gestore
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
            this.AGGIUNTA = new System.Windows.Forms.Button();
            this.RICERCA = new System.Windows.Forms.Button();
            this.VISUALIZZA = new System.Windows.Forms.Button();
            this.ELIMINA = new System.Windows.Forms.Button();
            this.MODIFICA = new System.Windows.Forms.Button();
            this.recupera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AGGIUNTA
            // 
            this.AGGIUNTA.Location = new System.Drawing.Point(38, 36);
            this.AGGIUNTA.Name = "AGGIUNTA";
            this.AGGIUNTA.Size = new System.Drawing.Size(85, 23);
            this.AGGIUNTA.TabIndex = 0;
            this.AGGIUNTA.Text = "AGGIUNTA CIBO";
            this.AGGIUNTA.UseVisualStyleBackColor = true;
            this.AGGIUNTA.Click += new System.EventHandler(this.AGGIUNTA_Click);
            // 
            // RICERCA
            // 
            this.RICERCA.Location = new System.Drawing.Point(161, 36);
            this.RICERCA.Name = "RICERCA";
            this.RICERCA.Size = new System.Drawing.Size(85, 23);
            this.RICERCA.TabIndex = 1;
            this.RICERCA.Text = "RICERCA";
            this.RICERCA.UseVisualStyleBackColor = true;
            this.RICERCA.Click += new System.EventHandler(this.RICERCA_Click);
            // 
            // VISUALIZZA
            // 
            this.VISUALIZZA.Location = new System.Drawing.Point(161, 108);
            this.VISUALIZZA.Name = "VISUALIZZA";
            this.VISUALIZZA.Size = new System.Drawing.Size(85, 23);
            this.VISUALIZZA.TabIndex = 2;
            this.VISUALIZZA.Text = "VISUALIZZA";
            this.VISUALIZZA.UseVisualStyleBackColor = true;
            this.VISUALIZZA.Click += new System.EventHandler(this.VISUALIZZA_Click);
            // 
            // ELIMINA
            // 
            this.ELIMINA.Location = new System.Drawing.Point(38, 164);
            this.ELIMINA.Name = "ELIMINA";
            this.ELIMINA.Size = new System.Drawing.Size(81, 23);
            this.ELIMINA.TabIndex = 3;
            this.ELIMINA.Text = "ELIMINA";
            this.ELIMINA.UseVisualStyleBackColor = true;
            this.ELIMINA.Click += new System.EventHandler(this.ELIMINA_Click);
            // 
            // MODIFICA
            // 
            this.MODIFICA.Location = new System.Drawing.Point(38, 108);
            this.MODIFICA.Name = "MODIFICA";
            this.MODIFICA.Size = new System.Drawing.Size(85, 23);
            this.MODIFICA.TabIndex = 4;
            this.MODIFICA.Text = "MODIFICA";
            this.MODIFICA.UseVisualStyleBackColor = true;
            this.MODIFICA.Click += new System.EventHandler(this.MODIFICA_Click);
            // 
            // recupera
            // 
            this.recupera.Location = new System.Drawing.Point(161, 164);
            this.recupera.Name = "recupera";
            this.recupera.Size = new System.Drawing.Size(85, 23);
            this.recupera.TabIndex = 5;
            this.recupera.Text = "RECUPERA";
            this.recupera.UseVisualStyleBackColor = true;
            this.recupera.Click += new System.EventHandler(this.recupera_Click);
            // 
            // gestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 226);
            this.Controls.Add(this.recupera);
            this.Controls.Add(this.MODIFICA);
            this.Controls.Add(this.ELIMINA);
            this.Controls.Add(this.VISUALIZZA);
            this.Controls.Add(this.RICERCA);
            this.Controls.Add(this.AGGIUNTA);
            this.Name = "gestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestore";
            this.Load += new System.EventHandler(this.gestore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AGGIUNTA;
        private System.Windows.Forms.Button RICERCA;
        private System.Windows.Forms.Button VISUALIZZA;
        private System.Windows.Forms.Button ELIMINA;
        private System.Windows.Forms.Button MODIFICA;
        private System.Windows.Forms.Button recupera;
    }
}