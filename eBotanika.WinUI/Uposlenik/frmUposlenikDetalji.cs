using eBotanika.Model.Requests.Uposlenik;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBotanika.WinUI.Uposlenik
{
    public partial class frmUposlenikDetalji : Form
    {
        APIService _uposlenikService = new APIService("Uposlenik");
        APIService _ulogeService = new APIService("Uloge");
        private int? _id = null;

        public frmUposlenikDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            if (!_id.HasValue)
            {
                UposlenikInsertRequest insertRequest = new UposlenikInsertRequest
                {
                    Ime             = txtIme.Text,
                    Prezime         = txtPrezime.Text,
                    Email           = txtEmail.Text,
                    Telefon         = txtTelefon.Text,
                    KorisnickoIme   = txtKorisnickoIme.Text,
                    Password        = txtPassword.Text,
                    PasswordPotvrda = txtPotvrdaPass.Text,
                    UlogaID         = comboBoxUloge.SelectedValue.ToString()
                };

                var uposlenik = await _uposlenikService.Insert<Model.Uposlenik>(insertRequest);
                MessageBox.Show("Podaci uspješno sačuvani.", "Informacija");
            }
            else
            {
                UposlenikUpdateRequest updateRequest = new UposlenikUpdateRequest
                {
                    Ime             = txtIme.Text,
                    Prezime         = txtPrezime.Text,
                    Telefon         = txtTelefon.Text,
                    KorisnickoIme   = txtKorisnickoIme.Text,
                    Email           = txtEmail.Text,
                    Password        = txtPassword.Text,
                    PasswordPotvrda = txtPotvrdaPass.Text,
                    UlogaID         = comboBoxUloge.SelectedValue.ToString()
                };

                var uposlenik = await _uposlenikService.Update<Model.Uposlenik>(_id.Value, updateRequest);
                MessageBox.Show("Podaci uspješno izmjenjeni.", "Informacija");
            }
        }

        private async Task LoadUloge()
        {
            var result = await _ulogeService.Get<List<Model.Uloge>>();

            comboBoxUloge.DataSource    = result;
            comboBoxUloge.DisplayMember = "Naziv";
            comboBoxUloge.ValueMember   = "UlogaId";
        }

        private void txtIme_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                txtIme.Focus();
                errorProvider.SetError(txtIme, "Ime je obavezno!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtIme, "");
            }
        }

        private async void frmUlogeLoadAsync(object sender, EventArgs e)
        {
            await LoadUloge(); 

            if (_id.HasValue)
            {
                var entity = await _uposlenikService.GetById<Model.Uposlenik>(_id);

                if (entity.UlogaID.Equals(1))
                {
                    txtIme.Text                 = entity.Ime;
                    txtKorisnickoIme.Text       = entity.KorisnickoIme;
                    txtPrezime.Text             = entity.Prezime;
                    txtEmail.Text               = entity.Email;
                    txtTelefon.Text             = entity.Telefon;
                    comboBoxUloge.SelectedIndex = comboBoxUloge.FindString("Administrator");
                }
                else
                {
                    txtIme.Text                 = entity.Ime;
                    txtKorisnickoIme.Text       = entity.KorisnickoIme;
                    txtPrezime.Text             = entity.Prezime;
                    txtEmail.Text               = entity.Email;
                    txtTelefon.Text             = entity.Telefon;
                    comboBoxUloge.SelectedIndex = comboBoxUloge.FindString("Radnik");
                }
            }
        }

        private void txtEmailValidate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9+_.-]+@(.+)$"))
            {
                errorProvider.SetError(txtEmail, "Format e-maila nije ispravan. Mora biti test@live.com.");
                txtEmail.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, "");
            }
        }

        private void txtTelefonValidate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtTelefon.Text, @"^([0-9]{3})-([0-9]{3})-([0-9]{3})$"))
            {
                errorProvider.SetError(txtTelefon, "Format telefona nije ispravan. Mora biti 123-456-789");
                txtTelefon.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTelefon, "");
            }
        }

        private void txtLozinkaValidate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtLozinkaPotvrdaValidate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPotvrdaPass.Text) || string.IsNullOrEmpty(txtPotvrdaPass.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrdaPass, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPotvrdaPass, null);
            }
        }
    }
}
