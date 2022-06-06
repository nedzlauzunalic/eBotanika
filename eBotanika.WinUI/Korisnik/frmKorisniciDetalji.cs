using eBotanika.Model.Requests.Korisnik;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace eBotanika.WinUI.Korisnik
{
    public partial class frmKorisniciDetalji : Form
    {
        APIService _service = new APIService("Korisnik");
        private int? _id = null;

        public frmKorisniciDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (!_id.HasValue)
                {
                    KorisnikInsertRequest insertRequest = new KorisnikInsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPotvrdaPass.Text,
                        DatumRodjenja = txtDatumRodjenja.Text
                    };

                    var korisnik = await _service.Insert<Model.Korisnik>(insertRequest);
                    MessageBox.Show("Podaci uspješno sačuvani.", "Informacija");
                }
                else
                {
                    KorisnikUpdateRequest updateRequest = new KorisnikUpdateRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Telefon = txtTelefon.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPotvrdaPass.Text,
                        DatumRodjenja = txtDatumRodjenja.Text
                    };

                    var korisnik = await _service.Update<Model.Korisnik>(_id.Value, updateRequest);
                    MessageBox.Show("Podaci uspješno izmjenjeni.", "Informacija");
                }
            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var entity = await _service.GetById<Model.Korisnik>(_id);
                txtIme.Text = entity.Ime;
                txtKorisnickoIme.Text = entity.KorisnickoIme;
                txtPrezime.Text = entity.Prezime;
                txtEmail.Text = entity.Email;
                txtTelefon.Text = entity.Telefon;
                txtDatumRodjenja.Text = entity.DatumRodjenja.ToString();
            }
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

        private void txtPrezime_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                e.Cancel = true;
                txtPrezime.Focus();
                errorProvider.SetError(txtPrezime, "Ime je obavezno!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPrezime, "");
            }
        }

        private void txtEmail_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9+_.-]+@(.+)$"))
            {
                errorProvider.SetError(txtEmail, "Format e-maila nije ispravan.");
                txtEmail.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, "");
            }
        }

        private void txtDatumRodjenja_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDatumRodjenja.Text, @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$"))
            {
                errorProvider.SetError(txtDatumRodjenja, "Format datuma nije ispravan.");
                txtDatumRodjenja.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDatumRodjenja, "");
            }
        }

        private void txtTelefon_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtTelefon.Text, @"^([0-9]{3})-([0-9]{3})-([0-9]{3})$"))
            {
                errorProvider.SetError(txtTelefon, "Format telefona nije ispravan.");
                txtTelefon.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTelefon, "");
            }
        }

        private void txtKorisnickoIme_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                e.Cancel = true;
                txtKorisnickoIme.Focus();
                errorProvider.SetError(txtKorisnickoIme, "Korisničko ime je obavezno!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtKorisnickoIme, "");
            }
        }
    }
}
