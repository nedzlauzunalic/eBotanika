using eBotanika.Model.Requests.Biljke;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eBotanika.WinUI.Biljke
{
    public partial class frmBiljke : Form
    {
        APIService _apiService = new APIService("Biljke");

        public frmBiljke()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new BiljkeSearchRequest()
            {
                Naziv = txtNaziv.Text
            };

            var list = await _apiService.Get<List<Model.Biljke>>(search);
            dgvBiljke.AutoGenerateColumns = false;

            dgvBiljke.DataSource = list;
        }

        private void dgvBiljke_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvBiljke.SelectedRows[0].DataBoundItem as Model.Biljke;

            frmBiljkeDetalji frm = new frmBiljkeDetalji(item.BiljkeID);
            frm.ShowDialog();
        }
    }
}
