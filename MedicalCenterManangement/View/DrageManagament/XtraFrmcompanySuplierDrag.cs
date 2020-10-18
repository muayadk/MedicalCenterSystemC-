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
using System.Data.Entity;

using MedicalCenterManangement.DataModeView;

namespace MedicalCenterManangement.View.DrageManagament
{
    public partial class XtraFrmcompanySuplierDrag : DevExpress.XtraEditors.XtraForm
    {
        MedicalCenterDbEntities db = new MedicalCenterDbEntities();
        public XtraFrmcompanySuplierDrag()
        {
            InitializeComponent();
        }

        private void XtraFrmcompanySuplierDrag_Load(object sender, EventArgs e)
        {
            db = new MedicalCenterDbEntities();
            db.companySuplierDragTab.Load();
            companySuplierDragTabBindingSource.DataSource = db.companySuplierDragTab.Local;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;
        }

        private void isDeletedCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;

                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;

                    case EntityState.Detached:
                        obj.State = EntityState.Unchanged;
                        break;

                }
            }

            companySuplierDragTabBindingSource.ResetBindings(false);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            companySuplierDragTabBindingSource.AddNew();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("هل تريد حذف هذا حقا؟", "الرسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                companySuplierDragTabBindingSource.RemoveCurrent();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("تم الحفظ بنجاح !!", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void isDeletedCheckEdit_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}