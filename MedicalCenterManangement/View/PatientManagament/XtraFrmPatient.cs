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
using System.IO;
using System.Globalization;
using System.Data.SqlClient;

namespace MedicalCenterManangement.View.PatientManagament
{

    public partial class XtraFrmPatient : DevExpress.XtraEditors.XtraForm
    {
       
       
        Models.ClsPatient patient = new Models.ClsPatient();
       
        // استدعاء كلاس الزيارة 
        Models.ClsVisit visit = new Models.ClsVisit();
       
        public int ID, position;

        //  هنا تم تعريف متغيرات من نوع استاتيك للوصل الى رقم المريض والدمتور والزيارة والحالة اذا كانت العلية اضافة اوتعديل من فورم الزيارة وبقية البيانات 
        public static int PATIENTID, DOID,STATE ,VIID;
        public static string VICODE, VINAME,VIDATE,VITIME,VINOTE;
        
        public XtraFrmPatient()
        {
            InitializeComponent();


            btnSave.Enabled = false;
            
           
            AutoCompleteStringCollection customSource = new AutoCompleteStringCollection();
         //   customSource.Add("Yes");
          //  customSource.Add("You");
          //  customSource.Add("Can");
            var tx = txtname.MaskBox;
       

          
            tx.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tx.AutoCompleteCustomSource = customSource;
            patient.autoCompletPatientName(tx);


            AutoCompleteStringCollection customSource1 = new AutoCompleteStringCollection();
            var tx2 = txtlname.MaskBox;
            tx2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tx2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tx2.AutoCompleteCustomSource = customSource1;
            
           
            patient.autoCompletPatientLname(tx2);

            //  this.dgVisit.DataSource = patient.getAllPatient();
            //


            //
            /*dgVisit.Columns[1].Visible = false;
            dgVisit.Columns[5].Visible = false;
            dgVisit.Columns[7].Visible = false;
            dgVisit.Columns[8].Visible = false;
            dgVisit.Columns[9].Visible = false;
            dgVisit.Columns[11].Visible = false;
            dgVisit.Columns[12].Visible = false;
            dgVisit.Columns[13].Visible = false;
            dgVisit.Columns[14].Visible = false;
            dgVisit.Columns[15].Visible = false;
            dgVisit.Columns[16].Visible = false;
            dgVisit.Columns[17].Visible = false;
            dgVisit.Columns[18].Visible = false;
            //txtcode.Text = ID.ToString();
            btnSave.Enabled = false;*/



        }
       

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtname.Text == "") || (txtlname.Text == "") || comsex.SelectedText == null || comtype.SelectedText == null )
                {
                    MessageBox.Show("يجب اضافات البيانات الضرورية واللازمة!!", "  البيانات الضرورية", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                    return;
                }

                if (txtage.Text == "")
                {
                    txtage.Text = 00.ToString();
                }
                if (txtmobile1.Text == "")
                {
                    txtmobile1.Text = 967000000.ToString();
                }
                if (txtmobile2.Text == "")
                {
                    txtmobile2.Text = 04000000.ToString();
                }

                if (PATIENTID == 0)
                {
                    MessageBox.Show("المريض المراد تعديله غير موجود");
                    return;
                }
                if (txtage.Text == "")
                {
                    txtage.Text = 00.ToString();
                }
                byte[] Picture;
                if (img.Image == null)
                {
                    Picture = new byte[0];
                    patient.updatePatient(Convert.ToInt32(txtpaId.Text),
                        Convert.ToString(txtcode.Text), Convert.ToString(txtname.Text),
                        Convert.ToString(txtlname.Text),
                        Convert.ToString(comsex.Text),
                        Convert.ToString(txtdate.Text), 
                        Convert.ToInt32(txtage.Text),
                        Convert.ToInt32(txtmobile1.Text), 
                        Convert.ToInt32(txtmobile2.Text),
                        Picture,
                        Convert.ToString(txtaddress.Text),
                        Convert.ToString(txtcountry.Text),
                        Convert.ToString(txtcity.Text),
                        Convert.ToString(comboold.Text),
                        Convert.ToString(txtstate.Text),
                        Convert.ToString(comtype.Text),
                        Convert.ToInt32(paAccount.EditValue));
                    MessageBox.Show("تم تعديل بيانات المريض بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgVisit.DataSource = patient.getAllPatient();
                 
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    img.Image.Save(ms, img.Image.RawFormat);
                    Picture = ms.ToArray();
                    patient.updatePatient(Convert.ToInt32(txtpaId.Text),
                        Convert.ToString(txtcode.Text), Convert.ToString(txtname.Text),
                        Convert.ToString(txtlname.Text),
                        Convert.ToString(comsex.Text),
                        Convert.ToString(txtdate.Text),
                        Convert.ToInt32(txtage.Text),
                        Convert.ToInt32(txtmobile1.Text),
                        Convert.ToInt32(txtmobile2.Text),
                        Picture,
                        Convert.ToString(txtaddress.Text),
                        Convert.ToString(txtcountry.Text),
                        Convert.ToString(txtcity.Text),
                        Convert.ToString(comboold.Text),
                        Convert.ToString(txtstate.Text),
                        Convert.ToString(comtype.Text),
                        Convert.ToInt32(paAccount.EditValue));
                    MessageBox.Show("تم تعديل بيانات المريض بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                ClearText();
                btnNew.Enabled = true;
                btnSave.Enabled = false;
            }
            catch
            {
                return;
            }
        }

        public void ClearText()
        {
            txtpaId.Text = "";
            txtviId.Text = "";
            txtcode.Text = "";
            txtage.Text = "";
            txtaddress.Text = "";
            txtcity.Text = "";
            txtcountry.Text = "";
            txtdate.Text = "";
            txtlname.Text = "";
            txtmobile1.Text = "";
            txtmobile2.Text = "";
            txtname.Text = "";
            txtstate.Text = "";
            txtage.Text = "";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(patient.getAllPatient().Rows.Count);


            txtpaId.Text = (t + 1).ToString();
            ClearText();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnLast.Enabled = false;
            btnNext.Enabled = false;
            btnP.Enabled = false;
            btn0.Enabled = false;

            btnSave.Focus();


        }

        public void enableText()
        {
            txtname.Enabled = false;
            txtlname.Enabled = false;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        
            try
            {
                if ((txtname.Text == "") || (txtlname.Text == "") || comsex.SelectedText == null || comtype.SelectedText == null )
                {
                    MessageBox.Show("يجب اضافات البيانات الضرورية واللازمة!!", "  البيانات الضرورية", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                    return;
                }

                if (txtage.Text == "")
                {
                    txtage.Text = 00.ToString();
                }
                if (txtmobile1.Text == "")
                {
                    txtmobile1.Text = 967000000.ToString();
                }
                if (txtmobile2.Text == "")
                {
                    txtmobile2.Text = 04000000.ToString();
                }

                byte[] Picture;
                if (img.Image == null)
                {
                   
                    Picture = new byte[0];
                 

                   
                    patient.AddPatient(
                        Convert.ToString(txtcode.Text),
                        Convert.ToString(txtname.Text),
                        Convert.ToString(txtlname.Text),
                        Convert.ToString(comsex.Text),
                        Convert.ToString(txtdate.Text),
                        Convert.ToInt32(txtage.Text),
                        Convert.ToInt32(txtmobile1.Text),
                        Convert.ToInt32(txtmobile2.Text),
                        Picture,
                        Convert.ToString(txtaddress.Text),
                        Convert.ToString(txtcountry.Text),
                        Convert.ToString(txtcity.Text),
                        Convert.ToString(comboold.Text),
                        Convert.ToString(txtstate.Text),
                        Convert.ToString(comtype.SelectedText),
                         Convert.ToInt32(paAccount.EditValue));

                    MessageBox.Show("تم اضاقة سجل مريض بنجاح!!", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MemoryStream ms = new MemoryStream();
                    img.Image.Save(ms, img.Image.RawFormat);
                    Picture = ms.ToArray();

                    patient.AddPatient(Convert.ToString(txtcode.Text),
                        Convert.ToString(txtname.Text),
                        Convert.ToString(txtlname.Text),
                        Convert.ToString(comsex.Text),
                        Convert.ToString(txtdate.Text),
                        Convert.ToInt32(txtage.Text),
                        Convert.ToInt32(txtmobile1.Text),
                        Convert.ToInt32(txtmobile2.Text),
                        Picture,
                        Convert.ToString(txtaddress.Text),
                        Convert.ToString(txtcountry.Text),
                        Convert.ToString(txtcity.Text),
                        Convert.ToString(comboold.Text),
                        Convert.ToString(txtstate.Text),
                        Convert.ToString(comtype.SelectedText),
                       Convert.ToInt32( paAccount.EditValue));
                    MessageBox.Show("تم اضاقة سجل مريض بنجاح!!", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
               
                    

                btnNew.Enabled = true;
                btnSave.Enabled = false;
            }



            catch(Exception ex)
            {
                MessageBox.Show("exception", ex.Data.ToString());
            }


        }

        private void img_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {

            // OpenFileDialog ofd = new OpenFileDialog();
            /* XtraOpenFileDialog ofd = new XtraOpenFileDialog();
             ofd.Filter = "ملفات الصور |*.JPG; *.PNG ;*.GIF; *.PMB";
             if (ofd.ShowDialog() == DialogResult.OK)
             {
                 img.Image = Image.FromFile(ofd.FileName);
             }*/

        }

        private void XtraFrmPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalCenterDbDataSet.patientsTab' table. You can move, or remove it, as needed.
            //  this.patientsTabTableAdapter.Fill(this.medicalCenterDbDataSet.patientsTab);

            DBConnection db = new DBConnection();

            SqlDataAdapter da = new SqlDataAdapter("SELECT Acc_Num,Acc_Name from Accounts where Acc_Type='فرعي' ", db.sqlconnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Accounts");
            paAccount.Properties.DataSource = ds.Tables["Accounts"];
            paAccount.Properties.DisplayMember = "Acc_Name";
            paAccount.Properties.ValueMember = "Acc_Num";

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // this.patientsTabTableAdapter.FillBy(this.medicalCenterDbDataSet.patientsTab);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gridPatient_DoubleClick(object sender, EventArgs e)
        {


        }

        private void txtstate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dgPatient_DoubleClick(object sender, EventArgs e)
        {

        }

        // method for transection
        void Navigate(int Index)
        {
            try
            {

                img.Image = null;
                DataRowCollection DRC = patient.getAllPatient().Rows;
                ID = Convert.ToInt32(DRC[Index][0].ToString());
                txtpaId.Text = ID.ToString();

                PATIENTID = Convert.ToInt32(DRC[Index][0].ToString());

                txtpaId.Text = DRC[Index][0].ToString();
                txtcode.Text = DRC[Index][1].ToString();
                txtname.Text = DRC[Index][2].ToString();
                txtlname.Text = DRC[Index][3].ToString();
                comsex.Text = DRC[Index][4].ToString();

                txtdate.Text = DRC[Index][5].ToString();

                txtage.Text = DRC[Index][6].ToString();
                txtmobile1.Text = DRC[Index][7].ToString();
                txtmobile2.Text = DRC[Index][8].ToString();
                byte[] picture = (byte[])DRC[Index][9];
                MemoryStream ms = new MemoryStream(picture);
                img.Image = Image.FromStream(ms);


                txtaddress.Text = DRC[Index][10].ToString();
                txtcountry.Text = DRC[Index][11].ToString();
                txtcity.Text = DRC[Index][12].ToString();
               
              

                comboold.Text = DRC[Index][13].ToString();


                txtstate.Text = DRC[Index][14].ToString();
                comtype.Text = DRC[Index][15].ToString();

            }
            catch
            {

                return;
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                position = patient.getAllPatient().Rows.Count - 1;
                Navigate(position);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {

                if (position == patient.getAllPatient().Rows.Count - 1)
                {
                    MessageBox.Show("هذا هو اخر مريض");
                    return;

                }
                position += 1;
                Navigate(position);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);

            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            try
            {
                if (position == 0)
                {
                    MessageBox.Show("هذا هو اول مريض");
                    return;

                }
                position -= 1;
                Navigate(position);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);

            }

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void img_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                XtraOpenFileDialog ofd = new XtraOpenFileDialog();
                ofd.Filter = "ملفات الصور |*.JPG; *.PNG ;*.GIF; *.PMB";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img.Image = Image.FromFile(ofd.FileName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                    if (PATIENTID == 0)
                    {
                        MessageBox.Show("المريض المراد حذفه غير موجود");
                        return;
                    }

                    if (MessageBox.Show("هل تريد فعلا حذف هذا المريض", "الحذف" + PATIENTID, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        patient.DeletePatient(PATIENTID);
                        MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dgVisit.DataSource = visit.getAllVisitPatient();
                    ClearText();
                }

            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);

            }
        }

        private void txtviId_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteVisit_Click(object sender, EventArgs e)
        {
            try
            {
                if (VIID == 0)
                {
                    {
                        MessageBox.Show(" الزيارة المراد حذفها غير صحيحة");
                        return;
                    }

                }

                if (MessageBox.Show("هل تريد فعلا حذف الزيارة لهذا المريض حقاً", "الحذف" + VIID, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    visit.DeleteVisitPatient(VIID);
                    MessageBox.Show("تم الحذف بنجاح !!  ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgVisit.DataSource = visit.getAllVisitPatient();
                }
            }
           
            catch(Exception ex)
            {
                MessageBox.Show("Exception",ex.Message);
                
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DataTable Dt = new DataTable();


                Dt = visit.getVisitPatientByName(txtname.Text);
                this.dgVisit.DataSource = Dt;
                txtlname.Focus();
               // ClearText();
            }
        }

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable Dt = new DataTable();


                Dt = visit.getVisitPatientByName(txtlname.Text);
                this.dgVisit.DataSource = Dt;
                comsex.Focus();
            }
        }

        private void dgVisit_KeyDown(object sender, KeyEventArgs e)
        {

            LoaddgVisitPatient();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchVisit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmobile1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtmobile2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmobile1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtname.Focus();
            }
        }

        private void comsex_Click(object sender, EventArgs e)
        {
            comtype.Focus();
        }

        private void comtype_Click(object sender, EventArgs e)
        {
            txtstate.Focus();
        }

        private void txtstate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paAccount.Focus();
            }
        }

        private void paAccount_Click(object sender, EventArgs e)
        {
          
        }

        private void paAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmobile1.Focus();
            }

        }

        private void dgVisit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoaddgVisitPatient()
        {

            try
            {

                img.Image = null;

                PATIENTID = Convert.ToInt32(dgVisit.CurrentRow.Cells[0].Value);

                txtpaId.Text = PATIENTID.ToString();

                txtcode.Text = dgVisit.CurrentRow.Cells[1].Value.ToString();
                txtname.Text = dgVisit.CurrentRow.Cells[2].Value.ToString();
                txtlname.Text = dgVisit.CurrentRow.Cells[3].Value.ToString();

                comsex.Text = dgVisit.CurrentRow.Cells[4].Value.ToString();

                txtdate.Text = dgVisit.CurrentRow.Cells[5].Value.ToString();
                txtage.Text = dgVisit.CurrentRow.Cells[6].Value.ToString();
                txtmobile1.Text = dgVisit.CurrentRow.Cells[7].Value.ToString();
                txtmobile2.Text = dgVisit.CurrentRow.Cells[8].Value.ToString();
                txtaddress.Text = dgVisit.CurrentRow.Cells[10].Value.ToString();
                txtcountry.Text = dgVisit.CurrentRow.Cells[11].Value.ToString();
                txtcity.Text = dgVisit.CurrentRow.Cells[12].Value.ToString();

                comboold.Text = dgVisit.CurrentRow.Cells[13].Value.ToString();


                txtstate.Text = dgVisit.CurrentRow.Cells[14].Value.ToString();
                comtype.Text = dgVisit.CurrentRow.Cells[15].Value.ToString();


                VIID = Convert.ToInt32(dgVisit.CurrentRow.Cells[17].Value);
                txtviId.Text = VIID.ToString();
                VICODE = dgVisit.CurrentRow.Cells[18].Value.ToString();
                VINAME = dgVisit.CurrentRow.Cells[19].Value.ToString();
                VIDATE = dgVisit.CurrentRow.Cells[20].Value.ToString();
                VITIME = dgVisit.CurrentRow.Cells[21].Value.ToString();
                VINOTE = dgVisit.CurrentRow.Cells[22].Value.ToString();

                byte[] picture = (byte[])dgVisit.CurrentRow.Cells[9].Value;
                MemoryStream ms = new MemoryStream(picture);
                img.Image = Image.FromStream(ms);

            }
            catch
            {
                return;
            }
        }

        private void dgVisit_DoubleClick(object sender, EventArgs e)
        {

            LoaddgVisitPatient();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //add new visit 

            XtraFrmVisit Frmvisit = new XtraFrmVisit(PATIENTID,STATE=0);
            Frmvisit.Show();

        }

        private void searchVisit_KeyPress(object sender, KeyEventArgs e)
        {
           

        }

        private void searchVisit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (searchVisit.Text == "")
                {
                    return;
                }
                else
                {
                    DataTable Dt = new DataTable();
                    Dt = visit.SearchVisitPatient(searchVisit.Text);
                    this.dgVisit.DataSource = Dt;
                }

            }
       


        }

        private void txtpaId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                DataTable Dt = new DataTable();


                Dt = visit.getVisitPatientByID(txtpaId.Text);
                this.dgVisit.DataSource = Dt;
            }
        }

        private void btnEditeVisit_Click(object sender, EventArgs e)
        {
            XtraFrmVisit visit = new XtraFrmVisit(VIID, PATIENTID, VICODE, VINAME, VIDATE, VITIME, VINOTE, DOID, STATE=1);
            visit.Show();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Navigate(0);



        }
    }
}