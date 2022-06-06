
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(209, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezerviši";
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(213, 124);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(35, 13);
            this.Prezime.TabIndex = 23;
            this.Prezime.Text = "Svrha";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(311, 163);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(182, 20);
            this.txtNapomena.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Napomena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datum rezervacije";
            // 
            // comboBoxSvrha
            // 
            this.comboBoxSvrha.FormattingEnabled = true;
            this.comboBoxSvrha.Location = new System.Drawing.Point(311, 121);
            this.comboBoxSvrha.Name = "comboBoxSvrha";
            this.comboBoxSvrha.Size = new System.Drawing.Size(182, 21);
            this.comboBoxSvrha.TabIndex = 26;
            this.comboBoxSvrha.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSvrha_Validate);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRezervisi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRezervisi.Location = new System.Drawing.Point(480, 280);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(104, 34);
            this.btnRezervisi.TabIndex = 27;
            this.btnRezervisi.Text = "Rezerviši";
            this.btnRezervisi.UseVisualStyleBackColor = false;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // txtDatumRezervacije
            // 
            this.txtDatumRezervacije.Location = new System.Drawing.Point(311, 85);
            this.txtDatumRezervacije.Name = "txtDatumRezervacije";
            this.txtDatumRezervacije.Size = new System.Drawing.Size(182, 20);
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
            this.label5.Location = new System.Drawing.Point(213, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Korisnik";
            // 
            // comboBoxKorisnik
            // 
            this.comboBoxKorisnik.FormattingEnabled = true;
            this.comboBoxKorisnik.Location = new System.Drawing.Point(311, 202);
            this.comboBoxKorisnik.Name = "comboBoxKorisnik";
            this.comboBoxKorisnik.Size = new System.Drawing.Size(182, 21);
            this.comboBoxKorisnik.TabIndex = 26;
            this.comboBoxKorisnik.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSvrha_Validate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Grad";
            // 
            // comboBoxGrad
            // 
            this.comboBoxGrad.FormattingEnabled = true;
            this.comboBoxGrad.Location = new System.Drawing.Point(311, 242);
            this.comboBoxGrad.Name = "comboBoxGrad";
            this.comboBoxGrad.Size = new System.Drawing.Size(182, 21);
            this.comboBoxGrad.TabIndex = 26;
            this.comboBoxGrad.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSvrha_Validate);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(555, 109);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(61, 20);
            this.txtKolicina.TabIndex = 18;
            this.txtKolicina.Validating += new System.ComponentModel.CancelEventHandler(this.txtKolicina_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Biljke";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(663, -189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.txtDatumRezervacije_Validate);
            // 
            // comboBoxBiljke
            // 
            this.comboBoxBiljke.FormattingEnabled = true;
            this.comboBoxBiljke.Location = new System.Drawing.Point(555, 157);
            this.comboBoxBiljke.Name = "comboBoxBiljke";
            this.comboBoxBiljke.Size = new System.Drawing.Size(157, 21);
            this.comboBoxBiljke.TabIndex = 26;
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 430);
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
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}