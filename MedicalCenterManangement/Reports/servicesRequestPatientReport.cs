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
    public partial class servicesRequestPatientReport : DevExpress.XtraEditors.XtraForm
    {
        public static int VISITID;
        public servicesRequestPatientReport(int id)
        {
            InitializeComponent();
            VISITID = id;
        }

        private void servicesRequestPatientReport_Load(object sender, EventArgs e)
        {
            using (MedicalCenterDbEntities db = new MedicalCenterDbEntities())
            {

                getServicesRequestByVisitID_ResultBindingSource.DataSource = db.getServicesRequestByVisitID(VISITID).ToList();



                getHeaderInformation_ResultBindingSource.DataSource = db.getHeaderInformation(VISITID).ToList();


                // reportViewer1.LocalReport.SetParameters(pram);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}