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
using System.Globalization;

namespace MedicalCenterManangement.View
{
    public partial class XtraFrnPatientTreatments : DevExpress.XtraEditors.XtraForm
    {
        Models.ClsDoctors doctor = new Models.ClsDoctors();
        Models.ClsPatient patient = new Models.ClsPatient();
        Models.ClsVisit visit = new Models.ClsVisit();

        public int patientId;
        public static int VISITID, PREVIEWID ,DIAGNOSEID,RECIPEID ,STATE;

        public static string  PRCODE, PRTIME, PRDATE, PRNAME, PRNOTE;
        public static string DICODE, DITIME, DIDATE, DINAME;
        public static string PANAME;

        public static string RECODE, REDATE ,RETIME ,RENOTE; 
        Models.ClsPreviews preview = new Models.ClsPreviews();
        Models.ClsTest test = new Models.ClsTest();
        Models.ClsDiagnoses diagnoe = new Models.ClsDiagnoses();

        Models.ClsRecipe recipe = new Models.ClsRecipe();
        public XtraFrnPatientTreatments()
        {
            InitializeComponent();

            AutoCompleteStringCollection customSource = new AutoCompleteStringCollection();
            var tx = txtName.MaskBox;
            tx.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tx.AutoCompleteCustomSource = customSource;
            patient.autoCompletPatientName(tx);
        }


        public void LoadVistPatient()
        {
            try
            {

               // img.Image = null;
                  patientId=  Convert.ToInt32(dgVisit.CurrentRow.Cells[0].Value);



                dgVisit.CurrentRow.Cells[1].Value.ToString();
                 dgVisit.CurrentRow.Cells[2].Value.ToString();
                 dgVisit.CurrentRow.Cells[3].Value.ToString();

                 dgVisit.CurrentRow.Cells[4].Value.ToString();
                dgVisit.Columns[4].Visible = false;
                dgVisit.CurrentRow.Cells[5].Value.ToString();
                dgVisit.Columns[5].Visible = false;
                dgVisit.CurrentRow.Cells[6].Value.ToString();
                dgVisit.Columns[6].Visible = false;
                dgVisit.CurrentRow.Cells[7].Value.ToString();
                dgVisit.Columns[7].Visible = false;
                dgVisit.CurrentRow.Cells[8].Value.ToString();
                dgVisit.Columns[8].Visible = false;
                dgVisit.CurrentRow.Cells[10].Value.ToString();
                dgVisit.Columns[10].Visible = false;
                dgVisit.CurrentRow.Cells[11].Value.ToString();
                dgVisit.Columns[11].Visible = false;
                dgVisit.CurrentRow.Cells[12].Value.ToString();
                dgVisit.Columns[12].Visible = false;
                dgVisit.CurrentRow.Cells[13].Value.ToString();
                dgVisit.Columns[13].Visible = false;

                dgVisit.CurrentRow.Cells[14].Value.ToString();
                dgVisit.Columns[14].Visible = false;
                dgVisit.CurrentRow.Cells[15].Value.ToString();
                dgVisit.Columns[15].Visible = false;

                VISITID = Convert.ToInt32(dgVisit.CurrentRow.Cells[17].Value);
             
                    dgVisit.CurrentRow.Cells[18].Value.ToString();
                    dgVisit.CurrentRow.Cells[19].Value.ToString();
                    dgVisit.CurrentRow.Cells[20].Value.ToString();
                 dgVisit.CurrentRow.Cells[21].Value.ToString();
                dgVisit.Columns[21].Visible = false;
               dgVisit.CurrentRow.Cells[22].Value.ToString();
                dgVisit.Columns[22].Visible = false;
              

            }
            catch
            {
                return;
            }
        }

        public void LoadPreviewData()
        {
            if(dgPreview.CurrentRow.Selected.Equals(null))
            {
                return;
            }

            PREVIEWID = Convert.ToInt32(dgPreview.CurrentRow.Cells[0].Value);
            PRCODE = dgPreview.CurrentRow.Cells[1].Value.ToString();
            PRNAME = dgPreview.CurrentRow.Cells[2].Value.ToString();
            PRDATE = dgPreview.CurrentRow.Cells[3].Value.ToString();
            PRTIME = dgPreview.CurrentRow.Cells[4].Value.ToString();
            PRNOTE = dgPreview.CurrentRow.Cells[5].Value.ToString();
        }

        public void LoadDiagnoseData()
        {

            if (dgDignoses.CurrentRow.Selected.Equals(null))
            {
                return;
            }
            DIAGNOSEID = Convert.ToInt32(dgDignoses.CurrentRow.Cells[1].Value);
            DICODE = dgDignoses.CurrentRow.Cells[2].Value.ToString();
            DINAME = dgDignoses.CurrentRow.Cells[7].Value.ToString();
            DIDATE = dgDignoses.CurrentRow.Cells[8].Value.ToString();
            DITIME = dgDignoses.CurrentRow.Cells[9].Value.ToString();
          
        }
        private void dgPreview_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPreviewData();
            }
            catch
            {
                return;
            }
        }

        private void dgPreview_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            LoadPreviewData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (PREVIEWID == 0)
                {
                    MessageBox.Show("المعاينة المراد حذفه غير موجود");
                    return;
                }

                if (MessageBox.Show("هل تريد فعلا حذف هذاالمعاينة ", "الحذف" + PREVIEWID, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    preview.DeletePreviewByUpdate(PREVIEWID, 1);
                    MessageBox.Show(" تم الحذف بنجاح   ");
                   
                }

                this.dgDignoses.DataSource = diagnoe.getDiagnosePatientByVistID(VISITID);
                dgDignoses.Columns[2].Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void dgDignoses_Click(object sender, EventArgs e)
        {
            if (dgDignoses.Rows.Count == 0)
            {
                MessageBox.Show("لايوجد معلومات في الداتا", "فارغ", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                return;
            }
            else
            {
            LoadDiagnoseData();

                }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PatientTeartment.XtraDiagnose diagn = new PatientTeartment.XtraDiagnose(VISITID, DIAGNOSEID, DICODE, PANAME, DINAME, DIDATE, DITIME, STATE = 1);
            diagn.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            XtraFrnPatientTreatments.ActiveForm.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (DIAGNOSEID == 0)
                {
                    MessageBox.Show("ألتشخيص المراد حذفه غير موجود");
                    return;
                }

                if (MessageBox.Show("هل تريد فعلا حذف تشخيص هذا المريص !! ", "الحذف" + DIAGNOSEID, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    diagnoe.DeleteDiagnoseByUpdate(DIAGNOSEID, 1);
                    MessageBox.Show(" تم الحذف بنجاح   ");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if (RECIPEID == 0)
                {
                    MessageBox.Show("ألرشدة المراد حذفه غير موجودة!!");
                    return;
                }

                if (MessageBox.Show("هل تريد فعلا حذف الرشدة الطبية لهذا المريص !! ", "الحذف" + RECIPEID, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    recipe.DeleteRecipeByUpdate(RECIPEID, 1);
                    MessageBox.Show(" تم الحذف بنجاح   ");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtvisitId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void datevist_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DataTable Dt = new DataTable();
                
               string date= datevist.Text;
                Convert.ToDateTime(date);
                MessageBox.Show(date,date.ToString());

                Dt = visit.SearchVisitPatientByDate(date.ToString());
                this.dgVisit.DataSource = Dt;
                if (Dt == null)
                {
                    MessageBox.Show("المريض المذكور لم يسجل له زيارة");
                }
                dgVisit.Focus();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            XtraFrnPatientTreatments.ActiveForm.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           Reports.diagnosePatientReport dig = new Reports.diagnosePatientReport(VISITID);
            dig.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Reports.recipePateintReport re = new Reports.recipePateintReport(VISITID);
            re.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            XtraFrnPatientTreatments.ActiveForm.Close();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            PatientTeartment.XtraFrmRecipe recipe = new PatientTeartment.XtraFrmRecipe(VISITID,RECIPEID, RECODE,REDATE, RETIME,RENOTE,STATE = 1);
            recipe.Show();
        }

        private void dgRecipe_Click(object sender, EventArgs e)
        {
            if (dgRecipe.Rows.Count == 0)
            {
                MessageBox.Show("لايوجد معلومات في الداتا", "فارغ", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                return;
            }
            else
            {
                VISITID = Convert.ToInt32(this.dgRecipe.CurrentRow.Cells[1].Value);
                RECIPEID = Convert.ToInt32(this.dgRecipe.CurrentRow.Cells[0].Value);
                RECODE = this.dgRecipe.CurrentRow.Cells[8].Value.ToString();
                RETIME = this.dgRecipe.CurrentRow.Cells[10].Value.ToString();
                REDATE = this.dgRecipe.CurrentRow.Cells[9].Value.ToString();
                RENOTE = this.dgRecipe.CurrentRow.Cells[11].Value.ToString();
            }

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            PatientTeartment.XtraFrmRecipe recipe = new PatientTeartment.XtraFrmRecipe(VISITID,STATE=0);
            recipe.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            PatientTeartment.XtraDiagnose diagnose = new PatientTeartment.XtraDiagnose(VISITID,PANAME,STATE=0);
            diagnose.Show(); 
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DataTable Dt = new DataTable();
               
                
                
                Dt = visit.getVisitPatientByName(txtName.Text);
                this.dgVisit.DataSource = Dt;
                if (Dt == null)
                {
                    MessageBox.Show("المريض المذكور لم يسجل له زيارة");
                }
                dgVisit.Focus();

               

            }
        }

        private void dgVisit_DoubleClick(object sender, EventArgs e)
        {

            if (dgVisit.Rows.Count==0)
            {
                MessageBox.Show("لايوجد معلومات في الداتا", "فارغ", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                return;
            }
            else
            {
                txtName.Text = dgVisit.CurrentRow.Cells[2].Value.ToString();
                PANAME = dgVisit.CurrentRow.Cells[2].Value.ToString();
                VISITID = Convert.ToInt32(dgVisit.CurrentRow.Cells[17].Value);
                txtvisitId.Text = VISITID.ToString();
                datevist.Text = dgVisit.CurrentRow.Cells[5].Value.ToString();

                // get preview for patient
                DataTable Dt1 = new DataTable();
                Dt1 = preview.getPreviewPatientByVistID(VISITID);
                dgPreview.DataSource = Dt1;


                //get test result
                this.dgTest.DataSource = test.getTestResultPatient(VISITID.ToString());

                // get diagnoses patient 
                this.dgDignoses.DataSource = diagnoe.getDiagnosePatientByVistID(VISITID);
                dgDignoses.Columns[2].Visible = false;

                //get recipe patient 

                this.dgRecipe.DataSource = recipe.getRecipeByVisitID(VISITID);
            }
           

        }

        private void txtvisitId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtvisitId.Text == "")
                {
                    return;
                }
                else
                {
                    DataTable Dt = new DataTable();
                    Dt = visit.SearchVisitPatient(txtvisitId.Text);
                    this.dgVisit.DataSource = Dt;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PatientTeartment.FrmPreview preview = new PatientTeartment.FrmPreview(VISITID,PANAME,STATE=0);
            preview.Show();
        }

        private void XtraFrnPatientTreatments_Load(object sender, EventArgs e)
        {

        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            PatientTeartment.FrmPreview preview = new PatientTeartment.FrmPreview(PREVIEWID,VISITID,PANAME,PRCODE,PRNAME,PRDATE,PRTIME,PRNOTE,STATE=1);
            preview.Show();

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}