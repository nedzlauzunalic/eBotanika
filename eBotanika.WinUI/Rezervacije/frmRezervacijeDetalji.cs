using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eBotanika.WinUI.Rezervacije
{
    public partial class frmRezervacijeDetalji : Form
    {
        APIService _service = new APIService("Rezervacije");
        private int? _id = null;

        public frmRezervacijeDetalji(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void frmRezervacijeDetalji_Load(object sender, EventArgs e)
        {
            var list = await _service.Get<List<Model.Rezervacije>>();
            dgvRezervacije.AutoGenerateColumns = false;

            dgvRezervacije.DataSource = list;
        }

        private void dgvRezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvRezervacije.SelectedRows[0].Cells[0].Value;

            frmRezervacije frm = new frmRezervacije(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
