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
        APIService _apiService = new APIService("Rezervacije");
        APIService _svrhaService = new APIService("Svrha");
        APIService _korisnikService = new APIService("Korisnik");
        APIService _gradoviService = new APIService("Gradovi");
        APIService _biljkeService = new APIService("Biljke");
        private int? _id = null;
        
        public frmRezervacije(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnRezervisi_Click(object sender, EventArgs e)
        {
            RezervacijeInsertRequest insertRequest = new RezervacijeInsertRequest()
            {
                DatumRezervacije = txtDatumRezervacije.Text,
                SvrhaID = comboBoxSvrha.SelectedValue.ToString(),
                Napomena = txtNapomena.Text,
                KorisnikID = (int)comboBoxKorisnik.SelectedValue,
                GradID = (int)comboBoxGrad.SelectedValue,
                Kolicina = txtKolicina.Text,
                BiljkeID = (int)comboBoxBiljke.SelectedValue,
                AdresaDostave = txtAdresaDostave.Text
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

        private async Task LoadKorisnik()
        {
            var result = await _korisnikService.Get<List<Model.Korisnik>>();

            comboBoxKorisnik.DataSource = result;
            comboBoxKorisnik.DisplayMember = "Naziv";
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
                errorProvider.SetError(txtDatumRezervacije, "Format datuma nije ispravan.");
                txtDatumRezervacije.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDatumRezervacije, "");
            }
        }

        private void comboBoxSvrha_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxSvrha.Text))
            {
                e.Cancel = true;
                comboBoxSvrha.Focus();
                errorProvider.SetError(comboBoxSvrha, "Svrha je obavezna!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(comboBoxSvrha, "");
            }
        }

        private void frmLoadAsync(object sender, EventArgs e)
        {
            LoadSvrha();
            LoadKorisnik();
            LoadGrad();
            LoadBiljke();
        }

        private void txtKolicina_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtKolicina.Text, @"[0-9]$"))
            {
                e.Cancel = true;
                txtKolicina.Focus();
                errorProvider.SetError(txtKolicina, "Samo brojevi dozvoljeni.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtKolicina, "");
            }
        }
    }
}
