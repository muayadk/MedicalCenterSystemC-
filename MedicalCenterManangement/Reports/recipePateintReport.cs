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
using Microsoft.Reporting.WinForms;

namespace MedicalCenterManangement.Reports
{
    public partial class recipePateintReport : DevExpress.XtraEditors.XtraForm
    {
        public static int VISITID;
        public recipePateintReport(int id)
        {
            InitializeComponent();
            VISITID = id;
        }

        private void recipePateintReport_Load(object sender, EventArgs e)
        {


            using (MedicalCenterDbEntities db = new MedicalCenterDbEntities())
            {
                getHeaderInformation_ResultBindingSource.DataSource = db.getHeaderInformation(VISITID).ToList();
                
                getRecipeByVisitID_ResultBindingSource.DataSource = db.getRecipeByVisitID(VISITID).ToList();
                this.reportViewer1.RefreshReport();
                /*Microsoft.Reporting.WinForms.ReportParameter[] pram = new Microsoft.Reporting.WinForms.ReportParameter[]
                 {
                     new Microsoft.Reporting.WinForms.ReportParameter("",VISITID.ToString())

                 };*/



                /* Microsoft.Reporting.WinForms.ReportParameter[] pram1 = new Microsoft.Reporting.WinForms.ReportParameter[]
                 {
                     new Microsoft.Reporting.WinForms.ReportParameter(VISITID.ToString()),

                 };*/


                // reportViewer1.LocalReport.SetParameters(pram);
                // reportViewer1.LocalReport.SetParameters(pram1);

            }


        }
    }
}