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

namespace MedicalCenterManangement.View.PatientTeartment
{
    public partial class FrmPreview : DevExpress.XtraEditors.XtraForm
    {
        public static int VISITID, PREVIEWID, STATE;
        public static string PANAME, PRCODE, PRTIME, PRDATE, PRNAME, PRNOTE;

        private void FrmPreview_Load(object sender, EventArgs e)
        {

        }

        Models.ClsPreviews Preview = new  Models.ClsPreviews();
        public FrmPreview()
        {
            InitializeComponent();
        }
        public FrmPreview(int v ,string name,int state)
        {
            InitializeComponent();
            
            VISITID = v;
            txtviId.Text = VISITID.ToString();
            PANAME = name;
            txtpaName.Text = PANAME;
            STATE = state;
            txtprNote.Text = STATE.ToString();
        }

        public FrmPreview(int pr ,int v, string pname, string code, string name,string date,string time,string note, int state)
        {
            InitializeComponent();
            PREVIEWID = pr;
            VISITID = v;
            txtviId.Text = VISITID.ToString();
            PANAME = pname;
            txtpaName.Text = PANAME;
            STATE = state;
            txtprNote.Text = STATE.ToString();
          
            txtprCode.Text = code;
            txtprName.Text = name;
            datepreview.Text = date;
            timepreview.Text = time;
            txtprNote.Text = note;

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("this :" +comdoId.Text);
            try
            {

                if (STATE == 0)
                {

                    Preview.AddPreview(txtprCode.Text, txtprName.Text, datepreview.Text, timepreview.Text, txtprNote.Text, VISITID);
                  
                    MessageBox.Show(" عملية الاضافة ", "تم اضافة معاينة المريض بنحاج");
                    txtprNote.Text = "";
                    txtprCode.Text = "";
                    txtprName.Text = "";
                    txtviId.Text = "";
                    datepreview.Text = "";
                    timepreview.Text = "";

                }

                else if (STATE == 1)

                {
                    Preview.UpdatePreview(PREVIEWID,txtprCode.Text,txtpaName.Text,datepreview.Text,timepreview.Text,txtprNote.Text,VISITID);
                    MessageBox.Show(" عملية التعديل ", "تم تعديل معاينة المريض بنحاج");

                    txtprNote.Text = "";
                    txtprCode.Text = "";
                    txtprName.Text = "";
                    txtviId.Text = "";
                    datepreview.Text = "";
                    timepreview.Text = "";
                   
                }

                else
                {
                    return;
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(" exception", ex.Data.ToString());

            }
        }
    }
}