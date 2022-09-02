
using System.Windows.Forms;

namespace eBotanika.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.label1 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSvrha = new System.Windows.Forms.ComboBox();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.txtDatumRezervacije = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxKorisnik = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGrad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxBiljke = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresaDostave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(279, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezerviši";
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(284, 207);
            this.Prezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(42, 16);
            this.Prezime.TabIndex = 23;
            this.Prezime.Text = "Svrha";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(738, 207);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(4);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(208, 22);
            this.txtNapomena.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Napomena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datum rezervacije";
            // 
            // comboBoxSvrha
            // 
            this.comboBoxSvrha.FormattingEnabled = true;
            this.comboBoxSvrha.Location = new System.Drawing.Point(415, 203);
            this.comboBoxSvrha.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSvrha.Name = "comboBoxSvrha";
            this.comboBoxSvrha.Size = new System.Drawing.Size(241, 24);
            this.comboBoxSvrha.TabIndex = 26;
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRezervisi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRezervisi.Location = new System.Drawing.Point(651, 425);
            this.btnRezervisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(139, 42);
            this.btnRezervisi.TabIndex = 27;
            this.btnRezervisi.Text = "Rezerviši";
            this.btnRezervisi.UseVisualStyleBackColor = false;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // txtDatumRezervacije
            // 
            this.txtDatumRezervacije.Location = new System.Drawing.Point(415, 248);
            this.txtDatumRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatumRezervacije.Name = "txtDatumRezervacije";
            this.txtDatumRezervacije.Size = new System.Drawing.Size(241, 22);
            this.txtDatumRezervacije.TabIndex = 28;
            this.txtDatumRezervacije.Validating += new System.ComponentModel.CancelEventHandler(this.txtDatumRezervacije_Validate);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Korisnik";
            // 
            // comboBoxKorisnik
            // 
            this.comboBoxKorisnik.FormattingEnabled = true;
            this.comboBoxKorisnik.Location = new System.Drawing.Point(415, 294);
            this.comboBoxKorisnik.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKorisnik.Name = "comboBoxKorisnik";
            this.comboBoxKorisnik.Size = new System.Drawing.Size(241, 24);
            this.comboBoxKorisnik.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Grad";
            // 
            // comboBoxGrad
            // 
            this.comboBoxGrad.FormattingEnabled = true;
            this.comboBoxGrad.Location = new System.Drawing.Point(737, 134);
            this.comboBoxGrad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGrad.Name = "comboBoxGrad";
            this.comboBoxGrad.Size = new System.Drawing.Size(209, 24);
            this.comboBoxGrad.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(415, 158);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(241, 22);
            this.txtKolicina.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Biljke";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(884, -233);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 28;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.txtDatumRezervacije_Validate);
            // 
            // comboBoxBiljke
            // 
            this.comboBoxBiljke.FormattingEnabled = true;
            this.comboBoxBiljke.Location = new System.Drawing.Point(415, 105);
            this.comboBoxBiljke.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBiljke.Name = "comboBoxBiljke";
            this.comboBoxBiljke.Size = new System.Drawing.Size(241, 24);
            this.comboBoxBiljke.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adresa dostave";
            // 
            // txtAdresaDostave
            // 
            this.txtAdresaDostave.Location = new System.Drawing.Point(415, 346);
            this.txtAdresaDostave.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresaDostave.Name = "txtAdresaDostave";
            this.txtAdresaDostave.Size = new System.Drawing.Size(241, 22);
            this.txtAdresaDostave.TabIndex = 20;
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDatumRezervacije);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.comboBoxGrad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxKorisnik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBiljke);
            this.Controls.Add(this.comboBoxSvrha);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.txtAdresaDostave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRezervacije";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmLoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSvrha;
        private System.Windows.Forms.Button btnRezervisi;
        private TextBox txtDatumRezervacije;
        private ErrorProvider errorProvider;
        private ComboBox comboBoxGrad;
        private Label label7;
        private ComboBox comboBoxKorisnik;
        private Label label5;
        private TextBox txtKolicina;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private ComboBox comboBoxBiljke;
        private TextBox txtAdresaDostave;
        private Label label4;
    }
}