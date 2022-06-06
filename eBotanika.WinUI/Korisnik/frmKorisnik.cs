using eBotanika.Model.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eBotanika.WinUI.Korisnik
{
    public partial class frmKorisnik : Form
    {
        APIService _apiService = new APIService("Korisnik");

        public frmKorisnik()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisnikSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text
            };

            var list = await _apiService.Get<List<Model.Korisnik>>(search);
            dgvKorisnici.AutoGenerateColumns = false;

            dgvKorisnici.DataSource = list;
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;

            frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
