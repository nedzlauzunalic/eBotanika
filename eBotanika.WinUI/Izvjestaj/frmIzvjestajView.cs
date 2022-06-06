using eBotanika.Model.Requests.Rezervacije;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eBotanika.WinUI.Izvjestaj
{
    public partial class frmIzvjestajView : Form
    {
        APIService _rezervacijeService = new APIService("Rezervacije");
        APIService _svrhaService = new APIService("Svrha");
        private int _svrhaId;

        public frmIzvjestajView(int valueMember)
        {
            InitializeComponent();
            _svrhaId = valueMember;
        }

        private async void frmIzvjestajView_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("DatumKreiranja", DateTime.Now.ToString("dd.MM.yyyy")));

            var svrha = await _svrhaService.GetById<Model.Svrha>(_svrhaId);

            rpc.Add(new ReportParameter("SvrhaID", svrha.Naziv));

            reportViewer.LocalReport.SetParameters(rpc);

            List<Model.Rezervacije> rezervacijeList = new List<Model.Rezervacije>();

            rezervacijeList = await _rezervacijeService.Get<List<Model.Rezervacije>>(new RezervacijeSearchRequest { SvrhaID = svrha.SvrhaID });

            ReportDataSource rds = new ReportDataSource("dataSetEbotanika", rezervacijeList);

            this.reportViewer.LocalReport.DataSources.Add(rds);

            this.reportViewer.RefreshReport();
        }
    }
}
