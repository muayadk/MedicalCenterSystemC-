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
using System.IO;
using MedicalCenterManangement.Models;
namespace MedicalCenterManangement.View.MedicalCenterManagament
{
    public partial class XtraFrmMedicalCenter : DevExpress.XtraEditors.XtraForm
    {
        public  static int HoId;
        MedicalCenterDbEntities db = new MedicalCenterDbEntities();
        MedicalCenter medicalcenter = new MedicalCenter();
        public XtraFrmMedicalCenter()
        {
            InitializeComponent();
            dgMedicalcenter.DataSource = db.hospitalCenterTab.Where(h => h.isDeleted == false).Select(h => h).ToList();
            dgMedicalcenter.Columns[11].Visible = false;
            dgMedicalcenter.Columns[9].Visible = false;
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void XtraFrmMedicalCenter_Load(object sender, EventArgs e)
        {
            try
            {
               
               
                dgMedicalcenter.Columns[0].Visible = false;
                dgMedicalcenter.Columns[1].HeaderText = " رقم الكود";
                dgMedicalcenter.Columns[3].HeaderText = "ألاسم بالعربي";
                dgMedicalcenter.Columns[2].HeaderText = "ألاسم بالانجليزي";
                dgMedicalcenter.Columns[4].HeaderText = " رقم الموبايل";
                dgMedicalcenter.Columns[5].HeaderText = "رقم التلفون ";
                dgMedicalcenter.Columns[6].HeaderText = " العنوان بالعربي";
                dgMedicalcenter.Columns[7].HeaderText = "العنوان بالانجليزي ";
                dgMedicalcenter.Columns[8].HeaderText = " رقم الفاكس ";
                dgMedicalcenter.Columns[9].HeaderText = " الصورة ";
                dgMedicalcenter.Columns[10].HeaderText = " ملاحظة ";

                
                // dgMedicalcenter.Columns[12].Visible = false;

                unEnabled();
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
            }

            catch (Exception ex) { MessageBox.Show("ex" + ex.Message, ex.Data.ToString()); }


        }
        public void EnabledT()
        {
            txtaddress1.Enabled = true;
            txtaddress2.Enabled = true;
            txtcode.Enabled = true;
            txtlname.Enabled = true;
            txtmobile1.Enabled = true;
            txtmobile2.Enabled = true;
            txtnote.Enabled = true;
            txtfax.Enabled = true;
            txtname.Enabled = true;
        }
        public void unEnabled()
        {
            txtaddress1.Enabled = false;
            txtaddress2.Enabled = false;
            txtcode.Enabled = false;
            txtname.Enabled = false; 
            txtlname.Enabled = false;
            txtmobile1.Enabled = false;
            txtmobile2.Enabled = false;
            txtnote.Enabled = false;
            txtfax.Enabled = false;

        }

        public void clearText()
        {
            txtaddress1.Text = "";
            txtaddress2.Text = "";
            txtcode.Text = "";
            txtlname.Text = "";
            txtmobile1.Text = "";
            txtname.Text = "";
            txtmobile2.Text = "";
            txtnote.Text = "";
            txtfax.Text = "";
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            hospitalCenterTab hosp = new hospitalCenterTab();
            try
            {
                hosp.hoCode = txtcode.Text;
                hosp.hoNameA = txtname.Text;
                hosp.hoNameE = txtlname.Text;
                hosp.hoAddressA = txtaddress1.Text;
                hosp.hoAddressE = txtaddress2.Text;

                if (txtmobile1.Text == "")
                {
                    hosp.hoMobile1 = Convert.ToInt32(96700000000000);
                }
                else { hosp.hoMobile1 = Convert.ToInt32(txtmobile1.Text); }
                if (txtmobile2.Text == "")
                {
                    hosp.hoMobile2 = Convert.ToInt32(0400000);
                }
                else { hosp.hoMobile2 = Convert.ToInt32(txtmobile2.Text); }

                if (txtfax.Text == "")
                {
                    hosp.hoMobile1 = Convert.ToInt32(04000000);
                }
                else { hosp.hoFix = Convert.ToInt32(txtfax.Text); }
                hosp.hoNote = txtnote.Text;
                hosp.isDeleted = false;
                byte[] Picture;
                if (img.Image == null)
                {

                    Picture = new byte[0];

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    img.Image.Save(ms, img.Image.RawFormat);
                    Picture = ms.ToArray();
                }

                hosp.hoImg = Picture;

                medicalcenter.Add(hosp);
                clearText();
            }
            catch
            {
                return;
            }
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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            EnabledT();
            btnSave.Enabled = true;
         
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try

            {
                
                if(btnEdit.Text=="تعديل")
                {
                    EnabledT();
                    btnEdit.Text = "تحديث";
                    return;
                }
                   

                if (search.Text == "")
                {
                    MessageBox.Show("يجب تحديد العنصر المراد تعديلة!!", "عملية التعديل", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    return;
                }
                hospitalCenterTab hosp = new hospitalCenterTab();
                 hosp = db.hospitalCenterTab.Find(HoId);
                if (hosp != null)
                {
                    hosp.hoId = HoId;
                    hosp.hoCode = txtcode.Text;
                    hosp.hoNameA = txtname.Text;
                    hosp.hoNameE = txtlname.Text;
                    hosp.hoAddressA = txtaddress1.Text;
                    hosp.hoAddressE = txtaddress2.Text;
                    if (txtmobile1.Text == "")
                    {
                        hosp.hoMobile1 = Convert.ToInt32( 96700000000000);
                    }
                    else { hosp.hoMobile1 = Convert.ToInt32(txtmobile1.Text); }
                    if (txtmobile2.Text == "")
                    {
                        hosp.hoMobile2 = Convert.ToInt32(0400000);
                    }
                    else { hosp.hoMobile2 = Convert.ToInt32(txtmobile2.Text); }

                    if (txtfax.Text == "")
                    {
                        hosp.hoMobile1 = Convert.ToInt32(04000000);
                    }
                    else { hosp.hoFix = Convert.ToInt32(txtfax.Text); }
                    
                   
                    hosp.hoNote = txtnote.Text;
                    hosp.isDeleted = false;
                    byte[] Picture;
                    if (img.Image == null)
                    {

                       Picture = new byte[0];

                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        img.Image.Save(ms, img.Image.RawFormat);
                        Picture = ms.ToArray();
                    }

                    hosp.hoImg = Picture;
                
                }
               medicalcenter.Update(hosp);

                MessageBox.Show("تم  عملية التعديل بنجاح!!", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                btnEdit.Enabled = false;
            
            }

            catch
            {
                throw;
            }
        }

        private void dgMedicalcenter_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
     


            try
            {
                clearText();
                img.Image = null;

                HoId = Convert.ToInt32(dgMedicalcenter.CurrentRow.Cells[0].Value.ToString());
                search.Text = HoId.ToString();
                txtcode.Text= Convert.ToString(dgMedicalcenter.CurrentRow.Cells[1].Value);
                txtname.Text= Convert.ToString(dgMedicalcenter.CurrentRow.Cells[3].Value);
                txtlname.Text= Convert.ToString(dgMedicalcenter.CurrentRow.Cells[2].Value);
                txtmobile1.Text= Convert.ToString(dgMedicalcenter.CurrentRow.Cells[4].Value);
                txtmobile2.Text= Convert.ToString(dgMedicalcenter.CurrentRow.Cells[5].Value);
                txtaddress1.Text= Convert.ToString(dgMedicalcenter.CurrentRow.Cells[6].Value);
                txtaddress2.Text= Convert.ToString(dgMedicalcenter.CurrentRow.Cells[7].Value);
                txtfax.Text = Convert.ToString(dgMedicalcenter.CurrentRow.Cells[8].Value);
                byte[] picture = (byte[])dgMedicalcenter.CurrentRow.Cells[9].Value;
                MemoryStream ms = new MemoryStream(picture);
                img.Image = Image.FromStream(ms);

                txtnote.Text = Convert.ToString(dgMedicalcenter.CurrentRow.Cells[10].Value);
               
            }

            catch 
            { return; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(search.Text=="")
                {
                    MessageBox.Show("يجب تحديد العنصر المراد حذفه!! ");
                    return;
                }

                var del = db.hospitalCenterTab.SingleOrDefault(h => h.hoId == HoId);
                if (MessageBox.Show("هل تريد هذا المركز الطبي" + HoId, "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    if (del != null)
                    {
                        db.Entry(del).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                    }

                    MessageBox.Show("!! تم عملبة الحذف بنجاح ","الخذف",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }

            catch (Exception ex) { MessageBox.Show("exception " + ex, ex.Message); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}