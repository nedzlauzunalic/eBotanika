namespace eBotanika.WinUI.Dostava
{
    partial class frmDostava
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
            this.datumPreuzimanja = new System.Windows.Forms.TextBox();
            this.datumSlanja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRezervacije = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // datumPreuzimanja
            // 
            this.datumPreuzimanja.Location = new System.Drawing.Point(214, 152);
            this.datumPreuzimanja.Name = "datumPreuzimanja";
            this.datumPreuzimanja.Size = new System.Drawing.Size(100, 20);
            this.datumPreuzimanja.TabIndex = 12;
            // 
            // datumSlanja
            // 
            this.datumSlanja.Location = new System.Drawing.Point(214, 112);
            this.datumSlanja.Name = "datumSlanja";
            this.datumSlanja.Size = new System.Drawing.Size(100, 20);
            this.datumSlanja.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Datum preuzimanja";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(111, 115);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(68, 13);
            this.Ime.TabIndex = 9;
            this.Ime.Text = "Datum slanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nova dostava";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(214, 191);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(100, 20);
            this.txtLokacija.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Trenutna lokacija";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(214, 228);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(100, 20);
            this.txtNapomena.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Napomena";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikazi.Location = new System.Drawing.Point(271, 297);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(80, 37);
            this.btnPrikazi.TabIndex = 18;
            this.btnPrikazi.Text = "Dodaj";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rezervacija";
            // 
            // comboBoxRezervacije
            // 
            this.comboBoxRezervacije.FormattingEnabled = true;
            this.comboBoxRezervacije.Location = new System.Drawing.Point(214, 260);
            this.comboBoxRezervacije.Name = "comboBoxRezervacije";
            this.comboBoxRezervacije.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRezervacije.TabIndex = 27;
            // 
            // frmDostava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 368);
            this.Controls.Add(this.comboBoxRezervacije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datumPreuzimanja);
            this.Controls.Add(this.datumSlanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ime);
            this.Name = "frmDostava";
            this.Text = "frmDostava";
            this.Load += new System.EventHandler(this.LoadRezervacije);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox datumPreuzimanja;
        private System.Windows.Forms.TextBox datumSlanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRezervacije;
    }
}