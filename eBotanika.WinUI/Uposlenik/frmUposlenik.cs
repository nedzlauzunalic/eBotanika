using eBotanika.Model.Requests.Uposlenik;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eBotanika.WinUI.Uposlenik
{
    public partial class frmUposlenik : Form
    {
        APIService _apiService = new APIService("Uposlenik");

        public frmUposlenik()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new UposlenikSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text
            };

            var list = await _apiService.Get<List<Model.Uposlenik>>(search);
            dgvUposlenici.AutoGenerateColumns = false;

            dgvUposlenici.DataSource = list;
        }

        private void dgvUposlenik_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvUposlenici.SelectedRows[0].DataBoundItem as Model.Uposlenik;

            frmUposlenikDetalji frm = new frmUposlenikDetalji(item.UposlenikID);
            frm.ShowDialog();
        }
    }
}
