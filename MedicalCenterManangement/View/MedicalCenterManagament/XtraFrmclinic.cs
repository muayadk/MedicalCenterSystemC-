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
using System.Data.SqlClient;

namespace MedicalCenterManangement.View.MedicalCenterManagament
{
    public partial class XtraFrmclinic : DevExpress.XtraEditors.XtraForm
    {
        MedicalCenterDbEntities db = new MedicalCenterDbEntities();
        clinicTab clinic = new clinicTab();
        public static int CId;

        public void Display()
        {
            this.dgClinic.DataSource = db.clinicTab.Where(c => c.isDeleted == false).Select(x => x).ToList();
        }
        public XtraFrmclinic()
        {
            InitializeComponent();

            Display();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            dgClinic.Columns[7].Visible = false;
            unEnabledText();
        }
    
        void ClearText()
        {
            txtnote.Text = "";
            txtname.Text = "";
            txtmobile.Text = "";
            txtcode.Text = "";
            txtaddress.Text = "";
        }

        void unEnabledText()
        {
            txtcode.Enabled = false;
            txtaddress.Enabled = false;
            txtmobile.Enabled = false;
            txtname.Enabled = false;
            txtnote.Enabled = false;
            hold.Enabled = false;
        }

        void EnabledText()
        {
            txtcode.Enabled = true;
            txtaddress.Enabled = true;
            txtmobile.Enabled = true;
            txtname.Enabled = true;
            txtnote.Enabled = true;
            hold.Enabled = true;
        }
        private void XtraFrmclinic_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT hoId ,hoNameA  FROM hospitalCenterTab", db.sqlconnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "hosp");
            hold.Properties.DataSource = ds.Tables["hosp"];
            hold.Properties.DisplayMember = "hoNameA";
            hold.Properties.ValueMember = "hoId";
            dgClinic.Columns[0].Visible = false;
            dgClinic.Columns[8].Visible = false;
            dgClinic.Columns[9].Visible = false;
            
             dgClinic.Columns[1].HeaderText = "رقم الكود";
            dgClinic.Columns[2].HeaderText = "اسم العيادة";
            dgClinic.Columns[3].HeaderText = "رقم التلفون";
            dgClinic.Columns[4].HeaderText = "العنوان";
            dgClinic.Columns[6].HeaderText = "المركز الطبي";
            dgClinic.Columns[5].HeaderText = "ملاحظات";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            EnabledText();
            btnSave.Enabled = true;
            Display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

               
                if (txtcode.Text == "" || txtname.Text == "" || txtmobile.Text == "" || hold.EditValue==null)
                {
                    MessageBox.Show("يجب ادخال المعلوات الضرورية!!", " تنبيه", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    return;
                }

               
                clinic.clCode = txtcode.Text;
                clinic.clName = txtname.Text;
                clinic.hoId = Convert.ToInt32(hold.EditValue);
                clinic.clAddress = txtaddress.Text;
                clinic.clNote = txtnote.Text;
                clinic.isDeleted = false;
                if (txtmobile.Text == "")
                {
                    clinic.clMobile = Convert.ToInt32(9670000000);

                }
                else
                {
                    clinic.clMobile = Convert.ToInt32(txtmobile.Text);

                }
                 var name =db.clinicTab.SingleOrDefault(c=>c.clName==clinic.clName);
                if (name != null)
                {
                    MessageBox.Show("المعلومات المدخلة موجودة مسبقا يرجا التاكد عزيزي!!", " تنبيه", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    return;
                }
               
                db.clinicTab.Add(clinic);
                db.SaveChanges();

                MessageBox.Show("تم الحفظ بنجاح !! تهانينا");
                Display();
            }

            catch { throw; }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (btnEdit.Text == "تعديل")
            {
                EnabledText();
                btnEdit.Text = "تحديث";
                return;
            }
            try
            {

               

                if (search.Text == "" || hold.EditValue==null)
                {
                    MessageBox.Show("يجب ادخال المعلوات الضرورية!!", " تنبيه", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    return;
                }

                var update = db.clinicTab.Find(CId);
                if (update != null)
                {


                    update.clId = CId;
                    update.clCode = txtcode.Text;
                    update.clName = txtname.Text;
                    update.clNote = txtnote.Text;
                    update.clAddress = txtaddress.Text;
                    update.hoId = Convert.ToInt32(hold.EditValue);
                    update.isDeleted = false;
                    if (txtmobile.Text == "")
                    {
                        update.clMobile = Convert.ToInt32(9670000000);

                    }
                    else
                    {
                        update.clMobile = Convert.ToInt32(txtmobile.Text);

                    }

                    

                    db.SaveChanges();

                    MessageBox.Show("تم حفظ التعديل بنجاح !! تهانينا");
                    Display();
                }
                else
                {
                    MessageBox.Show("ألعيادة المراد تعديلها غير موجودة!");
                    return;
                }
            }

            catch { throw; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {


                if (search.Text == "")
                {
                    MessageBox.Show("يجب ادختيار العيادة المراد حذف بياناتها!!");
                    return;
                }

                var delete = db.clinicTab.Find(CId);
                if (delete != null)
                {
                    delete.isDeleted = true;
                    db.SaveChanges();

                  MessageBox.Show("تم الحذف بنجاح !! تهانينا");
                    Display();
                }
                else
                {
                    MessageBox.Show("ألعيادة المراد حذفها غير موجودة!");
                    return;
                }
            }

            catch { throw; }

        }

        private void dgClinic_DoubleClick(object sender, EventArgs e)
        {


            btnEdit.Enabled = true;
            btnDelete.Enabled = true;



            try
            {

                ClearText();

                CId = Convert.ToInt32(dgClinic.CurrentRow.Cells[0].Value.ToString());
                search.Text = CId.ToString();
                txtcode.Text = Convert.ToString(dgClinic.CurrentRow.Cells[1].Value);
                txtname.Text = Convert.ToString(dgClinic.CurrentRow.Cells[2].Value);
                txtmobile.Text = Convert.ToString(dgClinic.CurrentRow.Cells[3].Value);
                txtaddress.Text = Convert.ToString(dgClinic.CurrentRow.Cells[4].Value);
                txtnote.Text = Convert.ToString(dgClinic.CurrentRow.Cells[5].Value);
                hold.EditValue = Convert.ToString(dgClinic.CurrentRow.Cells[6].Value);
                Display();
            }

            catch
            { return; }

        }
    }
}