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
using System.Data.Entity;

namespace MedicalCenterManangement.View.DrageManagament
{
    public partial class XtraFrmActiveMaterial : DevExpress.XtraEditors.XtraForm
    {
        MedicalCenterDbEntities db = new MedicalCenterDbEntities();

        public XtraFrmActiveMaterial()
        {
            InitializeComponent();

            db.activeMaterialTab.Load();
            activeMaterialTabBindingSource.DataSource = db.activeMaterialTab.Local;
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("تم الحفظ بنجاح !!", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("هل تريد حذف هذا حقا؟", "الرسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                activeMaterialTabBindingSource.RemoveCurrent();
            }
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
            activeMaterialTabBindingSource.ResetBindings(false);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            activeMaterialTabBindingSource.AddNew();
        }
    }
}