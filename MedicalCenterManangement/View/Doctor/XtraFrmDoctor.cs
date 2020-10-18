using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalCenterManangement.DataModeView;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;

namespace MedicalCenterManangement.View.Doctor
{
    public partial class XtraFrmDoctor : DevExpress.XtraEditors.XtraForm
    {
        byte[] img = null;
        public XtraFrmDoctor()
        {
            InitializeComponent();
        }
        MedicalCenterDbEntities db;
        private void doCodeTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void XtraFrmDoctor_Load(object sender, EventArgs e)
        {
            db = new MedicalCenterDbEntities();
            db.doctorsTab.Load();
            doctorsTabBindingSource.DataSource = db.doctorsTab.Local;
            gridView2.Columns[0].Visible =  false;
            gridView2.Columns[18].Visible = false;
            gridView2.Columns[19].Visible = false;
            gridView2.Columns[17].Visible = false;

            DBConnection Db = new DBConnection();
            SqlDataAdapter da = new SqlDataAdapter("select clId, clName from clinicTab", Db.sqlconnection);
            DataSet ds = new DataSet();

            da.Fill(ds, "clinic");
            clIdTextEdit.Properties.DataSource = ds.Tables["clinic"];
            clIdTextEdit.Properties.DisplayMember = "clName";
            clIdTextEdit.Properties.ValueMember = "clId";
            doImgPictureEdit.EditValue = img;


        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            doctorsTabBindingSource.AddNew();
            doImgPictureEdit.EditValue = null;
           
           // XtraMessageBox.Show("تم الحفظ  بنجاح !!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("هل تريد حذف هذا حقا؟", "الرسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                doctorsTabBindingSource.RemoveCurrent();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("تم الحفظ بنجاح !!","تحديث",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void gCDoctor_Click(object sender, EventArgs e)
        {

        }

        private void doImgPictureEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                XtraOpenFileDialog ofd = new XtraOpenFileDialog();
                ofd.Filter = "ملفات الصور |*.JPG; *.PNG ;*.GIF; *.PMB";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    doImgPictureEdit.Image = Image.FromFile(ofd.FileName);
                }

                MemoryStream ms = new MemoryStream();
                doImgPictureEdit.Image.Save(ms, doImgPictureEdit.Image.RawFormat);
                img = ms.ToArray();
                doImgPictureEdit.EditValue = img;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);

            }
        }
    }
}