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

namespace MedicalCenterManangement.View
{
    public partial class XtraFrmServices : DevExpress.XtraEditors.XtraForm
    {
        public int ID;
        Models.ClsServiecs serviecs = new Models.ClsServiecs();
        public XtraFrmServices()
        {
            InitializeComponent();
            this.dgSerivce.DataSource = serviecs.getAllServiecs();
        }

      
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtserName.Text = "";
            txtserPrice.Text = "";
            txtserNote.Text = "";
            txtserviceCode.Text = "";
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                serviecs.AddServiecs(txtserviceCode.Text, txtserName.Text, comboBoxEdit1.Text, Convert.ToDecimal(txtserPrice.Text), txtserNote.Text, Convert.ToInt32(11));
                MessageBox.Show(" عملية الاضافة ", "تم اضافة الخدمة بنحاج");

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void XtraFrmServices_Load(object sender, EventArgs e)
        {
            
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgSerivce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSerivce_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgSerivce.CurrentRow.Cells[0].Value);

            txtseId.Text = ID.ToString();

            txtserviceCode.Text = dgSerivce.CurrentRow.Cells[1].Value.ToString();
            txtserName.Text = dgSerivce.CurrentRow.Cells[2].Value.ToString();
            comboBoxEdit1.Text = dgSerivce.CurrentRow.Cells[3].Value.ToString();
            txtserPrice.Text = dgSerivce.CurrentRow.Cells[4].Value.ToString();
            txtserNote.Text = dgSerivce.CurrentRow.Cells[5].Value.ToString();
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (ID == 0)
                {
                    MessageBox.Show("المريض المراد تعديله غير موجود");
                    return;
                }

               
                
                    serviecs.UpdateServiecs(ID, txtserviceCode.Text, txtserName.Text, comboBoxEdit1.Text,Convert.ToDecimal(txtserPrice.Text), txtserNote.Text,0);
                    MessageBox.Show("تم تعديل بيانات المريض بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgSerivce.DataSource = serviecs.getAllServiecs();
                

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}