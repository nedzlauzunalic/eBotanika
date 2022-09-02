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
            this.components = new System.ComponentModel.Container();
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
            this.comboBoxKorisnik = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // datumPreuzimanja
            // 
            this.datumPreuzimanja.Location = new System.Drawing.Point(285, 187);
            this.datumPreuzimanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datumPreuzimanja.Name = "datumPreuzimanja";
            this.datumPreuzimanja.Size = new System.Drawing.Size(132, 22);
            this.datumPreuzimanja.TabIndex = 12;
            this.datumPreuzimanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtDatumPreuzimanjaValidate);
            // 
            // datumSlanja
            // 
            this.datumSlanja.Location = new System.Drawing.Point(285, 138);
            this.datumSlanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datumSlanja.Name = "datumSlanja";
            this.datumSlanja.Size = new System.Drawing.Size(132, 22);
            this.datumSlanja.TabIndex = 11;
            this.datumSlanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtDatumSlanjaValidate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Datum preuzimanja";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(148, 142);
            this.Ime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(85, 16);
            this.Ime.TabIndex = 9;
            this.Ime.Text = "Datum slanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nova dostava";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(285, 235);
            this.txtLokacija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(132, 22);
            this.txtLokacija.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Trenutna lokacija";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(285, 281);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(132, 22);
            this.txtNapomena.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Napomena";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikazi.Location = new System.Drawing.Point(357, 394);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(107, 46);
            this.btnPrikazi.TabIndex = 18;
            this.btnPrikazi.Text = "Dodaj";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rezervacija";
            // 
            // comboBoxRezervacije
            // 
            this.comboBoxRezervacije.FormattingEnabled = true;
            this.comboBoxRezervacije.Location = new System.Drawing.Point(285, 320);
            this.comboBoxRezervacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRezervacije.Name = "comboBoxRezervacije";
            this.comboBoxRezervacije.Size = new System.Drawing.Size(132, 24);
            this.comboBoxRezervacije.TabIndex = 27;
            // 
            // comboBoxKorisnik
            // 
            this.comboBoxKorisnik.FormattingEnabled = true;
            this.comboBoxKorisnik.Location = new System.Drawing.Point(285, 362);
            this.comboBoxKorisnik.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKorisnik.Name = "comboBoxKorisnik";
            this.comboBoxKorisnik.Size = new System.Drawing.Size(132, 24);
            this.comboBoxKorisnik.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Korisnik";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDostava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 453);
            this.Controls.Add(this.comboBoxKorisnik);
            this.Controls.Add(this.label6);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDostava";
            this.Text = "frmDostava";
            this.Load += new System.EventHandler(this.LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxKorisnik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}