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
    public partial class servicesRequestPatientReport : DevExpress.XtraEditors.XtraForm
    {
        public servicesRequestPatientReport()
        {
            InitializeComponent();
        }

        private void servicesRequestPatientReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}