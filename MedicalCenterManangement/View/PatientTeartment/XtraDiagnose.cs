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
    
    public partial class XtraDiagnose : DevExpress.XtraEditors.XtraForm
    {
        public static int VISITID ,DIAGNOSEID,STATE;
        public static string PANAME,DICODE,DINAME,DIDTATE,DITIME;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Models.ClsDiagnoses diagnose = new Models.ClsDiagnoses();
        public XtraDiagnose()
        {
            InitializeComponent();
        }

        public XtraDiagnose(int v ,string name  ,int state)
        {
            InitializeComponent();
            VISITID = v;
            txtviId.Text = VISITID.ToString();
            txtpaName.Text = name;
           
            STATE = state;

        }

        public XtraDiagnose(int v, int diagnoseId ,string code,string pname, string name,string date ,string time,int state)
        {
            InitializeComponent();
            DIAGNOSEID = diagnoseId;
            VISITID = v;
            txtviId.Text = VISITID.ToString();
            txtpaName.Text = pname;
            txtdiCode.Text = code;
            txtdiName.Text = name;
            datediagnose.Text = date;
            timediagnose.Text = time;
            STATE = state;

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                if (datediagnose.SelectedText == null)
                {
                    MessageBox.Show("يجب ادخال التاريخ للاهمية","حقل التاريخ فارغ!!",MessageBoxButtons.RetryCancel,MessageBoxIcon.None);
                }

                if (STATE == 0)
                {

                    diagnose.AddDiagnoses(txtdiCode.Text,txtdiName.Text,datediagnose.Text,timediagnose.Text,VISITID);

                    MessageBox.Show(" عملية الاضافة ", "تم اضافة معاينة المريض بنحاج");

                    txtpaName.Text = ""; 
                    txtdiCode.Text = "";
                    txtdiName.Text = "";
                    txtviId.Text = "";
                    datediagnose.Text = "";
                    timediagnose.Text = "";
                }

                else if (STATE == 1)

                {

                    diagnose.UpdateDiagnoses(DIAGNOSEID, txtdiCode.Text, txtdiName.Text, datediagnose.Text, timediagnose.Text, VISITID);
                    MessageBox.Show(" عملية التعديل ", "تم تعديل معاينة المريض بنحاج");

                   
                    txtdiCode.Text = "";
                    txtdiName.Text = "";
                    txtviId.Text = "";
                    datediagnose.Text = "";
                    timediagnose.Text = "";

                }

                else
                {
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void XtraDiagnose_Load(object sender, EventArgs e)
        {

        }
    }
}