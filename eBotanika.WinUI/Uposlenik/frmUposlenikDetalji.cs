using eBotanika.Model.Requests.Uposlenik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBotanika.WinUI.Uposlenik
{
    public partial class frmUposlenikDetalji : Form
    {
        APIService _uposlenikService = new APIService("Uposlenik");
        APIService _ulogeService = new APIService("Uloge");
        APIService   _uposlenikUlogeService = new APIService("UposlenikUloge");
        private int? _id = null;

        public frmUposlenikDetalji(int? id = null)
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
                var checkedBoxUloge = checkedListBoxUloge.CheckedItems.Cast<Model.Uloge>().ToList();
                var roleIdList = checkedBoxUloge.Select(x => x.UlogaID).ToList();

                UposlenikInsertRequest insertRequest = new UposlenikInsertRequest
                {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPotvrdaPass.Text,
                        Uloge = roleIdList
                };

                var uposlenik = await _uposlenikService.Insert<Model.Uposlenik>(insertRequest);
                MessageBox.Show("Podaci uspješno sačuvani.", "Informacija");
              }
              else
              { 
                  UposlenikUpdateRequest updateRequest = new UposlenikUpdateRequest
                  {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Telefon = txtTelefon.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPotvrdaPass.Text
                  };

                 var uposlenik = await _uposlenikService.Update<Model.Uposlenik>(_id.Value, updateRequest);
                 MessageBox.Show("Podaci uspješno izmjenjeni.", "Informacija");
              }
            }
        }

        private async void frmUposlenikLoadAsync(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var entity = await _uposlenikService.GetById<Model.Uposlenik>(_id);

                txtIme.Text = entity.Ime;
                txtKorisnickoIme.Text = entity.KorisnickoIme;
                txtPrezime.Text = entity.Prezime;
                txtEmail.Text = entity.Email;
                txtTelefon.Text = entity.Telefon;
            }

            await LoadUloge();
        }

        private async Task LoadUloge()
        {
            var result = await _ulogeService.Get<List<Model.Uloge>>();

            checkedListBoxUloge.DataSource = result;
            checkedListBoxUloge.DisplayMember = "Naziv";
            checkedListBoxUloge.Tag = "UlogaId";
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
    }
}
