using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBotanika.WinUI.Izvjestaj
{
    public partial class frmIzvjestaj : Form
    {
        APIService _svrhaService = new APIService("Svrha");

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private async Task LoadSvrha()
        {
            var result = await _svrhaService.Get<List<Model.Svrha>>();

            comboBoxAsortiman.DataSource = result;
            comboBoxAsortiman.DisplayMember = "Naziv";
            comboBoxAsortiman.ValueMember = "SvrhaID";
        }

        private async void frmIzvjestaj_Load_Svrha(object sender, EventArgs e)
        {
            await LoadSvrha();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            var svrhaID = comboBoxAsortiman.SelectedValue.ToString();
            if (int.TryParse(svrhaID, out int svrhaid))
            {
                frmIzvjestajView frm = new frmIzvjestajView(svrhaid);
                frm.Show();
            }          
        }
    }
}
