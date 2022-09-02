using eBotanika.Model.Requests.Biljke;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBotanika.WinUI.Biljke
{
    public partial class frmBiljkeDetalji : Form
    {
        APIService _service = new APIService("Biljke");
        APIService _kategorijaService = new APIService("Kategorija");
        APIService _uposlenikService = new APIService("Uposlenik");
        private int? _id = null;

        public frmBiljkeDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmBiljke_Load(object sender, EventArgs e)
        {
            await LoadKategorije();
            await LoadUposlenike();

            if (_id.HasValue)
            {
                var entity    = await _service.GetById<Model.Biljke>(_id);
                var uposlenik = await _uposlenikService.GetById<Model.Uposlenik>(entity.UposlenikID);
                var kategorija = await _kategorijaService.GetById<Model.Kategorija>(entity.KategorijaID);

                txtNaziv.Text                    = entity.Naziv;
                txtCijena.Text                   = entity.Cijena.ToString();
                richTextBoxOpis.Text             = entity.Opis;
                comboBoxUposlenik.SelectedIndex  = comboBoxUposlenik.FindString(uposlenik.Ime);
                comboBoxKategorija.SelectedIndex = comboBoxKategorija.FindString(kategorija.Naziv);
            }
        }

        private async void btnSacuvaj_OnClick(object sender, EventArgs e)
        {
            if (!_id.HasValue)
            {
                BiljkeInsertRequest insertRequest = new BiljkeInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    KategorijaID = comboBoxKategorija.SelectedValue.ToString(),
                    Cijena = txtCijena.Text,
                    Opis = richTextBoxOpis.Text,
                    UposlenikID = comboBoxUposlenik.SelectedValue.ToString()
                };

                var biljke = await _service.Insert<Model.Biljke>(insertRequest);
                MessageBox.Show("Podaci uspješno sačuvani.", "Informacija");
            }
            else
            {
                BiljkeUpdateRequest updateRequest = new BiljkeUpdateRequest()
                {
                    Naziv = txtNaziv.Text,
                    KategorijaID = comboBoxKategorija.SelectedValue.ToString(),
                    Cijena = txtCijena.Text,
                    Opis = richTextBoxOpis.Text,
                    UposlenikID = comboBoxUposlenik.SelectedValue.ToString()
                };

                var biljke = await _service.Update<Model.Biljke>(_id.Value, updateRequest);
                MessageBox.Show("Podaci uspješno izmjenjeni.", "Informacija");
            }
        }

        private async Task LoadKategorije()
        {
            var result = await _kategorijaService.Get<List<Model.Kategorija>>();

            comboBoxKategorija.DataSource = result;
            comboBoxKategorija.DisplayMember = "Naziv";
            comboBoxKategorija.ValueMember = "KategorijaID";
        }

        private async Task LoadUposlenike()
        {
            var result = await _uposlenikService.Get<List<Model.Uposlenik>>();

            comboBoxUposlenik.DataSource    = result;
            comboBoxUposlenik.DisplayMember = "Ime";
            comboBoxUposlenik.ValueMember   = "UposlenikID";
        }

        private void txtNaziv_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                e.Cancel = true;
                txtNaziv.Focus();
                errorProvider.SetError(txtNaziv, "Naziv je obavezan!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNaziv, "");
            }
        }

        private void txtCijena_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtCijena.Text, @"[0-9]$"))
            {
                e.Cancel = true;
                txtCijena.Focus();
                errorProvider.SetError(txtCijena, "Samo brojevi dozvoljeni.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCijena, "");
            }
        }
    }
}
