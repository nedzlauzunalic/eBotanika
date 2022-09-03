using eBotanika.Model.Requests.Rezervacije;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBotanika.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        APIService   _apiService      = new APIService("Rezervacije");
        APIService   _svrhaService    = new APIService("Svrha");
        APIService   _korisnikService = new APIService("Korisnik");
        APIService   _gradoviService  = new APIService("Gradovi");
        APIService   _biljkeService   = new APIService("Biljke");
        APIService   _ocjenaService   = new APIService("Ocjena");
        private int? _id              = null;
        
        public frmRezervacije(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmLoadAsync(object sender, EventArgs e)
        {
            await LoadSvrha();
            await LoadKorisnik();
            await LoadGrad();
            await LoadBiljke();
            await LoadOcjena();

            if (_id.HasValue)
            { 
                var entity   = await _apiService.GetById<Model.Rezervacije>(_id);
                var biljka   = await _biljkeService.GetById<Model.Biljke>(entity.BiljkeID);
                var grad     = await _gradoviService.GetById<Model.Gradovi>(entity.GradID);
                var korisnik = await _korisnikService.GetById<Model.Korisnik>(entity.KorisnikID);
                var svrha    = await _svrhaService.GetById<Model.Svrha>(entity.SvrhaID);
                var ocjena    = await _ocjenaService.GetById<Model.Ocjena>(entity.OcjenaID);

                txtAdresaDostave.Text          = entity.AdresaDostave;
                txtDatumRezervacije.Text       = entity.DatumRezervacije;
                txtKolicina.Text               = entity.Kolicina;
                txtNapomena.Text               = entity.Napomena;
                comboBoxBiljke.SelectedIndex   = comboBoxBiljke.FindString(biljka.Naziv);
                comboBoxGrad.SelectedIndex     = comboBoxGrad.FindString(grad.Naziv);
                comboBoxKorisnik.SelectedIndex = comboBoxKorisnik.FindString(korisnik.Ime);
                comboBoxSvrha.SelectedIndex    = comboBoxSvrha.FindString(svrha.Naziv);
                comboBoxOcjena.SelectedIndex   = comboBoxOcjena.FindString(ocjena.OcjenaUsluge.ToString());
            }
        }

        private async void btnRezervisi_Click(object sender, EventArgs e)
        {
            RezervacijeInsertRequest insertRequest = new RezervacijeInsertRequest
            {
                DatumRezervacije = txtDatumRezervacije.Text,
                SvrhaID = comboBoxSvrha.SelectedValue.ToString(),
                Napomena = txtNapomena.Text,
                KorisnikID = (int)comboBoxKorisnik.SelectedValue,
                GradID = (int)comboBoxGrad.SelectedValue,
                Kolicina = txtKolicina.Text,
                BiljkeID = (int)comboBoxBiljke.SelectedValue,
                AdresaDostave = txtAdresaDostave.Text,
                OcjenaID = (int)comboBoxOcjena.SelectedValue
            };

            var rezervacija = await _apiService.Insert<Model.Rezervacije>(insertRequest);
            MessageBox.Show("Rezervacija uspješno poslana.", "Informacija");
        }

        private async Task LoadSvrha()
        {
            var result = await _svrhaService.Get<List<Model.Svrha>>();

            comboBoxSvrha.DataSource = result;
            comboBoxSvrha.DisplayMember = "Naziv";
            comboBoxSvrha.ValueMember = "SvrhaID";
        }

        private async Task LoadOcjena()
        {
            var result = await _ocjenaService.Get<List<Model.Ocjena>>();

            comboBoxOcjena.DataSource    = result;
            comboBoxOcjena.DisplayMember = "OcjenaUsluge";
            comboBoxOcjena.ValueMember   = "OcjenaID";
        }

        private async Task LoadKorisnik()
        {
            var result = await _korisnikService.Get<List<Model.Korisnik>>();

            comboBoxKorisnik.DataSource = result;
            comboBoxKorisnik.DisplayMember = "Ime";
            comboBoxKorisnik.ValueMember = "KorisnikID";
        }

        private async Task LoadGrad()
        {
            var result = await _gradoviService.Get<List<Model.Gradovi>>();

            comboBoxGrad.DataSource = result;
            comboBoxGrad.DisplayMember = "Naziv";
            comboBoxGrad.ValueMember = "GradID";
        }

        private async Task LoadBiljke()
        {
            var result = await _biljkeService.Get<List<Model.Biljke>>();

            comboBoxBiljke.DataSource = result;
            comboBoxBiljke.DisplayMember = "Naziv";
            comboBoxBiljke.ValueMember = "BiljkeID";
        }

        private void txtDatumRezervacije_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDatumRezervacije.Text, @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$"))
            {
                errorProvider.SetError(txtDatumRezervacije, "Format datuma nije ispravan. Mora biti yyyy-mm-dd.");
                txtDatumRezervacije.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDatumRezervacije, "");
            }
        }
    }
}
