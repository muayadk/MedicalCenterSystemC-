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
   
    public partial class previewPatientReport : DevExpress.XtraEditors.XtraForm
    {
        public static int VISITID;
        public previewPatientReport( int id)
        {
            InitializeComponent();
            VISITID = id;
        }

        private void previewPatientReport_Load(object sender, EventArgs e)
        {

            using (MedicalCenterDbEntities db = new MedicalCenterDbEntities())
            {

                getPreviewPatientByVistIDResultBindingSource.DataSource = db.getPreviewPatientByVistID(VISITID).ToList();
              


                getHeaderInformationResultBindingSource.DataSource = db.getHeaderInformation(VISITID).ToList();
              

                // reportViewer1.LocalReport.SetParameters(pram);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}