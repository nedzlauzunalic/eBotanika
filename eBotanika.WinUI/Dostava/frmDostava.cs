using eBotanika.Model.Requests.Dostava;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eBotanika.WinUI.Dostava
{
    public partial class frmDostava : Form
    {
        APIService _service = new APIService("Dostava");
        APIService _apiService = new APIService("Rezervacije");
        private int? _id = null;

        public frmDostava(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnPrikazi_Click(object sender, System.EventArgs e)
        {
            DostavaInsertRequest insertRequest = new DostavaInsertRequest()
            {
                DatumSlanja = datumSlanja.Text,
                DatumPreuzimanja = datumPreuzimanja.Text,
                Napomena = txtNapomena.Text,
                TrenutnaLokacija = txtLokacija.Text,
                RezervacijaID = (int)comboBoxRezervacije.SelectedValue
            };

            var dostava = await _service.Insert<Model.Dostava>(insertRequest);
            MessageBox.Show("Dostava uspješno sačuvana.", "Informacija");
        }

        private async void LoadRezervacije(object sender, System.EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Rezervacije>>();

            comboBoxRezervacije.DataSource = result;
            comboBoxRezervacije.DisplayMember = "RezervacijaID";
            comboBoxRezervacije.ValueMember = "RezervacijaID";
        }
    }
}
