using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MedicalCenterManangement.DataModeView;

namespace MedicalCenterManangement.Reports
{
    public partial class diagnosePatientReport : DevExpress.XtraEditors.XtraForm
    {
        public static int VISITID;
        public diagnosePatientReport(int v)
        {
            InitializeComponent();
            VISITID = v;
        }

        private void diagnosePatientReport_Load(object sender, EventArgs e)
        {

            using (MedicalCenterDbEntities db = new MedicalCenterDbEntities())
            {
               
                getDiagnosePatientByVistID_ResultBindingSource.DataSource = db.getDiagnosePatientByVistID(VISITID).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] pram = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter(VISITID.ToString()),

                };


                getHeaderInformationResultBindingSource.DataSource = db.getHeaderInformation(VISITID).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] pram1 = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter(VISITID.ToString()),

                };

                // reportViewer1.LocalReport.SetParameters(pram);
                this.reportViewer1.RefreshReport();
            }
        }

    }
}