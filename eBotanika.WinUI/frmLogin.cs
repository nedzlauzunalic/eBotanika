using System;
using System.Windows.Forms;

namespace eBotanika.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Uposlenik");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btn_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                var result = await _service.Get<dynamic>();

                frmeBotanika frm = new frmeBotanika();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
