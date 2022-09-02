using eBotanika.Model.Requests.Dostava;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBotanika.WinUI.Dostava
{
    public partial class frmDostava : Form
    {
        APIService _service = new APIService("Dostava");
        APIService _apiService = new APIService("Rezervacije");
        APIService   _korisnikService = new APIService("Korisnik");
        private int? _id = null;

        public frmDostava(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnPrikazi_Click(object sender, System.EventArgs e)
        {
            DostavaInsertRequest insertRequest = new DostavaInsertRequest
            {
                DatumSlanja = datumSlanja.Text,
                DatumPreuzimanja = datumPreuzimanja.Text,
                Napomena = txtNapomena.Text,
                TrenutnaLokacija = txtLokacija.Text,
                RezervacijaID = comboBoxRezervacije.SelectedValue.ToString(),
                KorisnikID = comboBoxKorisnik.SelectedValue.ToString()
            };

            var dostava = await _service.Insert<Model.Dostava>(insertRequest);
            MessageBox.Show("Dostava uspješno sačuvana.", "Informacija");
        }

        private async Task LoadKorisnici()
        {
            var result = await _korisnikService.Get<List<Model.Korisnik>>();

            comboBoxKorisnik.DataSource    = result;
            comboBoxKorisnik.DisplayMember = "Ime";
            comboBoxKorisnik.ValueMember   = "KorisnikID";
        }

        private async Task LoadRezervacije()
        {
            var result = await _apiService.Get<List<Model.Rezervacije>>();

            comboBoxRezervacije.DataSource = result;
            comboBoxRezervacije.DisplayMember = "RezervacijaID";
            comboBoxRezervacije.ValueMember = "RezervacijaID";
        }

        private async void LoadAsync(object sender, System.EventArgs e)
        {
            await LoadRezervacije();
            await LoadKorisnici();
        }

        private void txtDatumSlanjaValidate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(datumSlanja.Text, @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$"))
            {
                errorProvider.SetError(datumSlanja, "Format datuma nije ispravan. Mora biti yyyy-mm-dd.");
                datumSlanja.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(datumSlanja, "");
            }
        }

        private void txtDatumPreuzimanjaValidate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(datumPreuzimanja.Text, @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$"))
            {
                errorProvider.SetError(datumPreuzimanja, "Format datuma nije ispravan. Mora biti yyyy-mm-dd.");
                datumPreuzimanja.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(datumPreuzimanja, "");
            }
        }
    }
}
