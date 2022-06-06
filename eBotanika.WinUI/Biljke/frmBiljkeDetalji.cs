using eBotanika.Model.Requests.Biljke;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBotanika.WinUI.Biljke
{
    public partial class frmBiljkeDetalji : Form
    {
        APIService _service = new APIService("Biljke");
        APIService _kategorijaService = new APIService("Kategorija");
        private int? _id = null;

        public frmBiljkeDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmBiljke_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var entity = await _service.GetById<Model.Biljke>(_id);

                txtNaziv.Text = entity.Naziv;
                txtCijena.Text = entity.Cijena.ToString();
                richTextBoxOpis.Text = entity.Opis;
            }

            await LoadKategorije();
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
                    Opis = richTextBoxOpis.Text
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
                    Opis = richTextBoxOpis.Text
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
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                e.Cancel = true;
                txtCijena.Focus();
                errorProvider.SetError(txtCijena, "Cijena je obavezna!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCijena, "");
            }
        }
    }
}
