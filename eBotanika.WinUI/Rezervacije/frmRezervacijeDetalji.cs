using eBotanika.Model.Requests.Rezervacije;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBotanika.WinUI.Rezervacije
{
    public partial class frmRezervacijeDetalji : Form
    {
        APIService   _service         = new APIService("Rezervacije");
        APIService   _biljkeService   = new APIService("Biljke");
        APIService   _svrhaService    = new APIService("Svrha");
        APIService   _korisnikService = new APIService("Korisnik");
        private int? _id              = null;

        public frmRezervacijeDetalji(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async Task LoadBiljke()
        {
            var result = await _biljkeService.Get<List<Model.Biljke>>();

            comboBoxBiljke.DataSource    = result;
            comboBoxBiljke.DisplayMember = "Naziv";
            comboBoxBiljke.ValueMember   = "BiljkeID";
            comboBoxBiljke.SelectedIndex = -1;
        }

        private async Task LoadSvrha()
        {
            var result = await _svrhaService.Get<List<Model.Svrha>>();

            comboBoxSvrha.DataSource    = result;
            comboBoxSvrha.DisplayMember = "Naziv";
            comboBoxSvrha.ValueMember   = "SvrhaID";
            comboBoxSvrha.SelectedIndex = -1;
        }

        private async Task LoadKorisnik()
        {
            var result = await _korisnikService.Get<List<Model.Korisnik>>();

            comboBoxKorisnik.DataSource    = result;
            comboBoxKorisnik.DisplayMember = "Ime";
            comboBoxKorisnik.ValueMember   = "KorisnikID";
            comboBoxKorisnik.SelectedIndex = -1;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new RezervacijeSearchRequest
            {
                BiljkeID     = (int?)comboBoxBiljke.SelectedValue,
                SvrhaID = (int?)comboBoxSvrha.SelectedValue,
                KorisnikID = (int?)comboBoxKorisnik.SelectedValue
            };

            var list = await _service.Get<List<Model.Rezervacije>>(search);
            dgvRezervacije.AutoGenerateColumns = false;

            dgvRezervacije.DataSource = list;
        }

        private async void frmRezervacijaLoad(object sender, EventArgs e)
        {
            await LoadBiljke();
            await LoadSvrha();
            await LoadKorisnik();
        }

        private void dgv_Rezervacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvRezervacije.SelectedRows[0].Cells[0].Value;

            frmRezervacije frm = new frmRezervacije((int?)item);
            frm.ShowDialog();
        }
    }
}
