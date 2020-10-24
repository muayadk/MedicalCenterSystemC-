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

namespace MedicalCenterManangement.Reports
{
    public partial class previewPatientReport : DevExpress.XtraEditors.XtraForm
    {
        public previewPatientReport()
        {
            InitializeComponent();
        }

        private void previewPatientReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}