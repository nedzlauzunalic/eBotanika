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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaDostave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SvrhaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiljkeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista rezervacija";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumRezervacije,
            this.AdresaDostave,
            this.KorisnikID,
            this.GradID,
            this.Napomena,
            this.SvrhaID,
            this.Kolicina,
            this.BiljkeID});
            this.dgvRezervacije.Location = new System.Drawing.Point(46, 87);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.RowTemplate.Height = 25;
            this.dgvRezervacije.Size = new System.Drawing.Size(646, 173);
            this.dgvRezervacije.TabIndex = 2;
            this.dgvRezervacije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRezervacije_MouseDoubleClick);
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.Name = "DatumRezervacije";
            // 
            // AdresaDostave
            // 
            this.AdresaDostave.DataPropertyName = "AdresaDostave";
            this.AdresaDostave.HeaderText = "Adresa dostave";
            this.AdresaDostave.Name = "AdresaDostave";
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "Korisnik";
            this.KorisnikID.Name = "KorisnikID";
            // 
            // GradID
            // 
            this.GradID.DataPropertyName = "GradID";
            this.GradID.HeaderText = "Grad";
            this.GradID.Name = "GradID";
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            // 
            // SvrhaID
            // 
            this.SvrhaID.DataPropertyName = "SvrhaID";
            this.SvrhaID.HeaderText = "Svrha";
            this.SvrhaID.Name = "SvrhaID";
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            // 
            // BiljkeID
            // 
            this.BiljkeID.DataPropertyName = "BiljkeID";
            this.BiljkeID.HeaderText = "Biljke";
            this.BiljkeID.Name = "BiljkeID";
            // 
            // frmRezervacijeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 345);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.label1);
            this.Name = "frmRezervacijeDetalji";
            this.Text = "frmRezervacijeDetalji";
            this.Load += new System.EventHandler(this.frmRezervacijeDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView dgvRezervacije;
        private DataGridViewTextBoxColumn DatumRezervacije;
        private DataGridViewTextBoxColumn AdresaDostave;
        private DataGridViewTextBoxColumn KorisnikID;
        private DataGridViewTextBoxColumn GradID;
        private DataGridViewTextBoxColumn Napomena;
        private DataGridViewTextBoxColumn SvrhaID;
        private DataGridViewTextBoxColumn Kolicina;
        private DataGridViewTextBoxColumn BiljkeID;
    }
}