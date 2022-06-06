
using System.Windows.Forms;

namespace eBotanika.WinUI
{
    partial class frmeBotanika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmeBotanika));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.uposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragalistaUposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragalistaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajBiljkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragalistaBiljakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaIzvjestajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.novaDostavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 460);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(791, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uposleniciToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.uslugeToolStripMenuItem,
            this.izvještajiToolStripMenuItem,
            this.dostavaToolStripMenuItem,
            this.kontaktToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(791, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // uposleniciToolStripMenuItem
            // 
            this.uposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUposlenikaToolStripMenuItem,
            this.pretragalistaUposlenikaToolStripMenuItem});
            this.uposleniciToolStripMenuItem.Name = "uposleniciToolStripMenuItem";
            this.uposleniciToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uposleniciToolStripMenuItem.Text = "Uposlenici";
            // 
            // dodajUposlenikaToolStripMenuItem
            // 
            this.dodajUposlenikaToolStripMenuItem.Name = "dodajUposlenikaToolStripMenuItem";
            this.dodajUposlenikaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.dodajUposlenikaToolStripMenuItem.Text = "Dodaj uposlenika";
            this.dodajUposlenikaToolStripMenuItem.Click += new System.EventHandler(this.dodajUposlenikaToolStripMenuItem_Click);
            // 
            // pretragalistaUposlenikaToolStripMenuItem
            // 
            this.pretragalistaUposlenikaToolStripMenuItem.Name = "pretragalistaUposlenikaToolStripMenuItem";
            this.pretragalistaUposlenikaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pretragalistaUposlenikaToolStripMenuItem.Text = "Pretraga/lista uposlenika";
            this.pretragalistaUposlenikaToolStripMenuItem.Click += new System.EventHandler(this.pretragalistaUposlenikaToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem,
            this.pretragalistaKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // pretragalistaKorisnikaToolStripMenuItem
            // 
            this.pretragalistaKorisnikaToolStripMenuItem.Name = "pretragalistaKorisnikaToolStripMenuItem";
            this.pretragalistaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pretragalistaKorisnikaToolStripMenuItem.Text = "Pretraga/lista korisnika";
            this.pretragalistaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pretragalistaKorisnikaToolStripMenuItem_Click);
            // 
            // uslugeToolStripMenuItem
            // 
            this.uslugeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajBiljkeToolStripMenuItem,
            this.pretragalistaBiljakaToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.pregledRezervacijaToolStripMenuItem});
            this.uslugeToolStripMenuItem.Name = "uslugeToolStripMenuItem";
            this.uslugeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.uslugeToolStripMenuItem.Text = "Usluge";
            // 
            // dodajBiljkeToolStripMenuItem
            // 
            this.dodajBiljkeToolStripMenuItem.Name = "dodajBiljkeToolStripMenuItem";
            this.dodajBiljkeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dodajBiljkeToolStripMenuItem.Text = "Dodaj biljke";
            this.dodajBiljkeToolStripMenuItem.Click += new System.EventHandler(this.dodajBiljkeToolStripMenuItem_Click);
            // 
            // pretragalistaBiljakaToolStripMenuItem
            // 
            this.pretragalistaBiljakaToolStripMenuItem.Name = "pretragalistaBiljakaToolStripMenuItem";
            this.pretragalistaBiljakaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pretragalistaBiljakaToolStripMenuItem.Text = "Pretraga/lista biljaka";
            this.pretragalistaBiljakaToolStripMenuItem.Click += new System.EventHandler(this.pretragalistaBiljakaToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.rezervacijeToolStripMenuItem.Text = "Dodaj rezervaciju";
            this.rezervacijeToolStripMenuItem.Click += new System.EventHandler(this.rezervacijeToolStripMenuItem_Click);
            // 
            // pregledRezervacijaToolStripMenuItem
            // 
            this.pregledRezervacijaToolStripMenuItem.Name = "pregledRezervacijaToolStripMenuItem";
            this.pregledRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pregledRezervacijaToolStripMenuItem.Text = "Pregled rezervacija";
            this.pregledRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.pregledRezervacijaToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaIzvjestajaToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // pretragaIzvjestajaToolStripMenuItem
            // 
            this.pretragaIzvjestajaToolStripMenuItem.Name = "pretragaIzvjestajaToolStripMenuItem";
            this.pretragaIzvjestajaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pretragaIzvjestajaToolStripMenuItem.Text = "Pretraga";
            this.pretragaIzvjestajaToolStripMenuItem.Click += new System.EventHandler(this.pretragaIzvjestajaToolStripMenuItem_Click);
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kontaktToolStripMenuItem.Text = "Kontakt";
            this.kontaktToolStripMenuItem.Click += new System.EventHandler(this.kontaktToolStripMenuItem_Click);
            // 
            // dostavaToolStripMenuItem
            // 
            this.dostavaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaDostavaToolStripMenuItem});
            this.dostavaToolStripMenuItem.Name = "dostavaToolStripMenuItem";
            this.dostavaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.dostavaToolStripMenuItem.Text = "Dostava";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(302, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(2200, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "eBotanika";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // novaDostavaToolStripMenuItem
            // 
            this.novaDostavaToolStripMenuItem.Name = "novaDostavaToolStripMenuItem";
            this.novaDostavaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaDostavaToolStripMenuItem.Text = "Nova dostava";
            this.novaDostavaToolStripMenuItem.Click += new System.EventHandler(this.novaDostavaToolStripMenuItem_Click);
            // 
            // frmeBotanika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(791, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmeBotanika";
            this.Text = "frmeBotanika";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem uposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragalistaUposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragalistaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajBiljkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragalistaBiljakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaIzvjestajaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ToolStripMenuItem pregledRezervacijaToolStripMenuItem;
        private ToolStripMenuItem dostavaToolStripMenuItem;
        private ToolStripMenuItem novaDostavaToolStripMenuItem;
    }
}



