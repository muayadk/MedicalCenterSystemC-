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
using System.Data.SqlClient;

namespace MedicalCenterManangement.View
{

    public partial class XtraFrmVisit : DevExpress.XtraEditors.XtraForm
    {
        DBConnection con = new DBConnection();
        // static virable to get Value patient Id from  form patient
        public static int PATIENTID, STATE,DOID, VIID;
        public static string VICODE, VINAME, VIDATE, VITIME, VINOTE;

        Models.ClsVisit visit = new Models.ClsVisit();

        public XtraFrmVisit()
        {
            InitializeComponent();
           
        }


        public XtraFrmVisit(int t ,int state)
        {
            InitializeComponent();
            PATIENTID = t;
            txtpaId.Text = PATIENTID.ToString();
            STATE = state;
        }
       
        public XtraFrmVisit(int viid, int t, string code, string name, string date, string time, string note, int doctorId, int state = 1)
        {
            
            
            InitializeComponent();
           
            VIID = viid;

            PATIENTID = t;
            txtpaId.Text = PATIENTID.ToString();

            VICODE = code;
            txtviCode.Text = VICODE;
            VINAME = name;
            txtviName.Text = VINAME;
            VIDATE = date;
            datevisit.Text = VIDATE;
            VITIME = time;
            timevist.Text = VITIME;
            VINOTE = note;
            txtviNote.Text = VINOTE;
            DOID = doctorId;
            STATE = state;
           

           
        }
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void addpatient_Click(object sender, EventArgs e)
        {
           
          
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XtraFrmServiecsRequest sr = new XtraFrmServiecsRequest();
            sr.Show();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

            this.Text = PATIENTID.ToString();
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void XtraFrmVisit_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlDataAdapter da= new SqlDataAdapter("select doId, doNameA from doctorsTab", db.sqlconnection);
           DataSet ds = new DataSet();
            da.Fill(ds, "doctors");
            comdoId.Properties.DataSource = ds.Tables["doctors"];
            comdoId.Properties.DisplayMember = "doId";
            comdoId.Properties.ValueMember = "doNameA";

          

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //decimal c= Convert.ToDecimal( comdoId.EditValue);

            //   MessageBox.Show("this :" +comdoId.Text);
            try
            {

                if (STATE==0)
                {
                    ln.Text = "اضافة جديد";
                    visit.AddVisit(txtviCode.Text, txtviName.Text, datevisit.Text, timevist.Text, PATIENTID, Convert.ToInt32(txtapId.Text), txtviNote.Text, Convert.ToInt32(comdoId.Text));
                    MessageBox.Show(" عملية الاضافة ", "تم اضافة الزيارة بنحاج");
                    txtapId.Text = "";
                    txtviCode.Text = "";
                    txtviName.Text = "";
                    txtviNote.Text = "";
                    datevisit.Text = "";
                    timevist.Text = "";
                   
                }

               else if (STATE ==1)

                {
                    ln.Text = " تعديل زيارة";
                   
                    visit.UpdateVisit(VIID,txtviCode.Text,txtviName.Text,datevisit.Text,timevist.Text,PATIENTID, Convert.ToInt32(txtapId.Text),txtviNote.Text, Convert.ToInt32(comdoId.Text));
                    txtapId.Text = "";
                    txtviCode.Text = "";
                    txtviName.Text = "";
                    txtviNote.Text = "";
                    datevisit.Text = "";
                    timevist.Text = "";
                    MessageBox.Show(" عملية ألتعديل ", "تم تعديل الزيارة بنحاج");
                }

                else
                {
                    return;
                }
            }

                
            catch(Exception ex)
            {
                MessageBox.Show(" exception", ex.Data.ToString());

                }
            

        }

        private void comdoId_PathChanged(object sender, BreadCrumbPathChangedEventArgs e)
        {
           
           
           
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}