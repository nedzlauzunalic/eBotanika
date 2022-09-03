using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace eBotanika.WinUI.Rezervacije
{
    partial class frmRezervacijeDetalji
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.Prezime = new System.Windows.Forms.Label();
            this.Biljka = new System.Windows.Forms.Label();
            this.comboBoxBiljke = new System.Windows.Forms.ComboBox();
            this.comboBoxSvrha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKorisnik = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.RezervacijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcjenaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvrhaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaDostave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiljkeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrikazi.FlatAppearance.BorderSize = 0;
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikazi.Location = new System.Drawing.Point(483, 98);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(113, 39);
            this.btnPrikazi.TabIndex = 10;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(214, 84);
            this.Prezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(54, 16);
            this.Prezime.TabIndex = 7;
            this.Prezime.Text = "Korisnik";
            // 
            // Biljka
            // 
            this.Biljka.AutoSize = true;
            this.Biljka.Location = new System.Drawing.Point(214, 51);
            this.Biljka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Biljka.Name = "Biljka";
            this.Biljka.Size = new System.Drawing.Size(40, 16);
            this.Biljka.TabIndex = 6;
            this.Biljka.Text = "Biljka";
            // 
            // comboBoxBiljke
            // 
            this.comboBoxBiljke.FormattingEnabled = true;
            this.comboBoxBiljke.Location = new System.Drawing.Point(313, 43);
            this.comboBoxBiljke.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxBiljke.Name = "comboBoxBiljke";
            this.comboBoxBiljke.Size = new System.Drawing.Size(132, 24);
            this.comboBoxBiljke.TabIndex = 48;
            // 
            // comboBoxSvrha
            // 
            this.comboBoxSvrha.FormattingEnabled = true;
            this.comboBoxSvrha.Location = new System.Drawing.Point(531, 43);
            this.comboBoxSvrha.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxSvrha.Name = "comboBoxSvrha";
            this.comboBoxSvrha.Size = new System.Drawing.Size(184, 24);
            this.comboBoxSvrha.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Svrha";
            // 
            // comboBoxKorisnik
            // 
            this.comboBoxKorisnik.FormattingEnabled = true;
            this.comboBoxKorisnik.Location = new System.Drawing.Point(313, 84);
            this.comboBoxKorisnik.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxKorisnik.Name = "comboBoxKorisnik";
            this.comboBoxKorisnik.Size = new System.Drawing.Size(132, 24);
            this.comboBoxKorisnik.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRezervacije);
            this.groupBox1.Location = new System.Drawing.Point(75, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(736, 197);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista rezervacija";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaID,
            this.OcjenaID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Napomena,
            this.Kolicina,
            this.SvrhaID,
            this.AdresaDostave,
            this.BiljkeID});
            this.dgvRezervacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezervacije.Location = new System.Drawing.Point(4, 19);
            this.dgvRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(728, 174);
            this.dgvRezervacije.TabIndex = 0;
            this.dgvRezervacije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Rezervacije_CellDoubleClick);
            // 
            // RezervacijaID
            // 
            this.RezervacijaID.DataPropertyName = "RezervacijaID";
            this.RezervacijaID.HeaderText = "RezervacijaID";
            this.RezervacijaID.MinimumWidth = 6;
            this.RezervacijaID.Name = "RezervacijaID";
            this.RezervacijaID.Visible = false;
            this.RezervacijaID.Width = 125;
            // 
            // OcjenaID
            // 
            this.OcjenaID.DataPropertyName = "OcjenaID";
            this.OcjenaID.HeaderText = "OcjenaID";
            this.OcjenaID.MinimumWidth = 6;
            this.OcjenaID.Name = "OcjenaID";
            this.OcjenaID.Visible = false;
            this.OcjenaID.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DatumRezervacije";
            this.Column1.HeaderText = "Datum Rezervacije";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "KorisnikID";
            this.Column2.HeaderText = "Korisnik";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GradID";
            this.Column3.HeaderText = "Grad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.Width = 125;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 125;
            // 
            // SvrhaID
            // 
            this.SvrhaID.DataPropertyName = "SvrhaID";
            this.SvrhaID.HeaderText = "Svrha";
            this.SvrhaID.MinimumWidth = 6;
            this.SvrhaID.Name = "SvrhaID";
            this.SvrhaID.Width = 125;
            // 
            // AdresaDostave
            // 
            this.AdresaDostave.DataPropertyName = "AdresaDostave";
            this.AdresaDostave.HeaderText = "Adresa Dostave";
            this.AdresaDostave.MinimumWidth = 6;
            this.AdresaDostave.Name = "AdresaDostave";
            this.AdresaDostave.Width = 125;
            // 
            // BiljkeID
            // 
            this.BiljkeID.DataPropertyName = "BiljkeID";
            this.BiljkeID.HeaderText = "Biljke";
            this.BiljkeID.MinimumWidth = 6;
            this.BiljkeID.Name = "BiljkeID";
            this.BiljkeID.Width = 125;
            // 
            // frmRezervacijeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxKorisnik);
            this.Controls.Add(this.comboBoxSvrha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBiljke);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Biljka);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRezervacijeDetalji";
            this.Text = "frmRezervacijeDetalji";
            this.Load += new System.EventHandler(this.frmRezervacijaLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnPrikazi;
        private Label Prezime;
        private Label Biljka;
        private ComboBox comboBoxBiljke;
        private ComboBox comboBoxSvrha;
        private Label label2;
        private ComboBox comboBoxKorisnik;
        private GroupBox groupBox1;
        private DataGridView dgvRezervacije;
        private DataGridViewTextBoxColumn RezervacijaID;
        private DataGridViewTextBoxColumn OcjenaID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Napomena;
        private DataGridViewTextBoxColumn Kolicina;
        private DataGridViewTextBoxColumn SvrhaID;
        private DataGridViewTextBoxColumn AdresaDostave;
        private DataGridViewTextBoxColumn BiljkeID;
    }
}