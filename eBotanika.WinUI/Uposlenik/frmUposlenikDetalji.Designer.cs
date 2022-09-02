
using System.Windows.Forms;

namespace eBotanika.WinUI.Uposlenik
{
    partial class frmUposlenikDetalji
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtPotvrdaPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Uloge = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxUloge = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(262, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Dodavanje novog uposlenika";
            // 
            // txtPotvrdaPass
            // 
            this.txtPotvrdaPass.Location = new System.Drawing.Point(661, 378);
            this.txtPotvrdaPass.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPotvrdaPass.Name = "txtPotvrdaPass";
            this.txtPotvrdaPass.PasswordChar = '*';
            this.txtPotvrdaPass.Size = new System.Drawing.Size(146, 22);
            this.txtPotvrdaPass.TabIndex = 35;
            this.txtPotvrdaPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtLozinkaPotvrdaValidate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 382);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Potvrda lozinke";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(375, 374);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(162, 22);
            this.txtPassword.TabIndex = 33;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtLozinkaValidate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Lozinka";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(375, 187);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(260, 22);
            this.txtPrezime.TabIndex = 31;
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(263, 187);
            this.Prezime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(56, 16);
            this.Prezime.TabIndex = 30;
            this.Prezime.Text = "Prezime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(375, 329);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(260, 22);
            this.txtKorisnickoIme.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Korisničko ime";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(375, 235);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 22);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailValidate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "E-mail";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(375, 282);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(260, 22);
            this.txtTelefon.TabIndex = 25;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefonValidate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefon";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(375, 137);
            this.txtIme.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(260, 22);
            this.txtIme.TabIndex = 23;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validate);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSacuvaj.FlatAppearance.BorderSize = 0;
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSacuvaj.Location = new System.Drawing.Point(505, 443);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(242, 49);
            this.btnSacuvaj.TabIndex = 22;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ime";
            // 
            // Uloge
            // 
            this.Uloge.AutoSize = true;
            this.Uloge.Location = new System.Drawing.Point(704, 137);
            this.Uloge.Name = "Uloge";
            this.Uloge.Size = new System.Drawing.Size(44, 16);
            this.Uloge.TabIndex = 40;
            this.Uloge.Text = "Uloge";
            this.Uloge.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxUloge
            // 
            this.comboBoxUloge.FormattingEnabled = true;
            this.comboBoxUloge.Location = new System.Drawing.Point(707, 157);
            this.comboBoxUloge.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUloge.Name = "comboBoxUloge";
            this.comboBoxUloge.Size = new System.Drawing.Size(208, 24);
            this.comboBoxUloge.TabIndex = 43;
            // 
            // frmUposlenikDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.comboBoxUloge);
            this.Controls.Add(this.Uloge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPotvrdaPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmUposlenikDetalji";
            this.Text = "frmUposlenikDetalji";
            this.Load += new System.EventHandler(this.frmUlogeLoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPotvrdaPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private Label Uloge;
        private ErrorProvider errorProvider;
        private ComboBox comboBoxUloge;
    }
}