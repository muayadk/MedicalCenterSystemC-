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
    public partial class XtraFrmscientificNameDrag : DevExpress.XtraEditors.XtraForm
    {
        public XtraFrmscientificNameDrag()
        {
            InitializeComponent();
            
        }
        MedicalCenterDbEntities db;
        private void XtraFrmscientificNameDrag_Load(object sender, EventArgs e)
        {
            db = new MedicalCenterDbEntities();
            db.scientificNameDragTab.Load();
            scientificNameDragTabBindingSource.DataSource = db.scientificNameDragTab.Local;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            scientificNameDragTabBindingSource.AddNew();
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
                scientificNameDragTabBindingSource.RemoveCurrent();
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

            scientificNameDragTabBindingSource.ResetBindings(false);

        }
    }
}