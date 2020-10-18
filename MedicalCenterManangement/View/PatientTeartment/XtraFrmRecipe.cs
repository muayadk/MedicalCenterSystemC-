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
using DevExpress.XtraEditors.Controls;

namespace MedicalCenterManangement.View.PatientTeartment
{
    public partial class XtraFrmRecipe : DevExpress.XtraEditors.XtraForm
    {
        DataTable Dt = new DataTable();
        DataTable Dt1 = new DataTable();
        public static  int VISITID,RECIPEID ,STATE;
        public static string RECODE, REDATE, RETIME, RENOTE;

        public int ID,recipeId;
        Models.ClsRecipe recipe = new Models.ClsRecipe();
        public XtraFrmRecipe()
        {
            InitializeComponent();
          
        }

       
        public XtraFrmRecipe(int viId , int state)
        {
            InitializeComponent();
           
            VISITID = viId;
            txtviId.Text = VISITID.ToString();
            txtreId.Text = recipe.getMaxRecipeID().Rows[0][0].ToString();
            /*recipeId =Convert.ToInt32( recipe.getMaxRecipeID().Rows[0][0].ToString());*/
            STATE = state;
            CreateDataTable();
            ResizeDGV();

            DataGridViewButtonColumn btnDelte = new DataGridViewButtonColumn();
            btnDelte.Text = "حذف";
            btnDelte.Width = 60;
            btnDelte.Name = "btnDelte";
            btnDelte.UseColumnTextForButtonValue = true;
            dgPrescription.Columns.Add(btnDelte);


        }

        public XtraFrmRecipe(int viId, int reId, string code,string date ,string time ,string note,int state)
        {
            InitializeComponent();
            RECIPEID = reId;
            txtreId.Text = RECIPEID.ToString();
            Dt1 = recipe.getRecipeByRecipeId(RECIPEID);
            CreateDataTable1();

            DataGridViewButtonColumn btnDelte = new DataGridViewButtonColumn();
            btnDelte.Text = "حذف";
            btnDelte.Width = 60;
            btnDelte.Name = "btnDelte";
            btnDelte.UseColumnTextForButtonValue = true;
            dgPrescription.Columns.Add(btnDelte);


            // this.dgPrescription.Columns[7].Visible = false;


            //  
            RECODE = code;
            txtreCode.Text = RECODE;
            REDATE = date;
            daterecipe.Text = REDATE;
            RETIME = time;
            timerecipe.Text = RETIME;
            RENOTE = note;
            txtreNote.Text = RENOTE;
            ResizeDGV();
            
            /* this.dgPrescription.Columns[0].Visible = false;
             this.dgPrescription.Columns[1].Visible = false;
             this.dgPrescription.Columns[2].Visible = false;
             this.dgPrescription.Columns[3].Visible = false;
             this.dgPrescription.Columns[4].Visible = false;*/

            VISITID = viId;
            txtviId.Text = VISITID.ToString();
           

            STATE = state;
            
          

        }

     

        void CreateDataTable()
        {
            Dt.Columns.Add("الكود");
            Dt.Columns.Add("العلاج");
            Dt.Columns.Add("الوصفة الطبية");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("الحجم");
            Dt.Columns.Add("وقت الاستخدام");
           
            Dt.Columns.Add("المدة");
            Dt.Columns.Add("رقم الوصفة");


            dgPrescription.DataSource = Dt;
        }

        void CreateDataTable1()
        {
            Dt.Columns.Add("الكود");
            Dt.Columns.Add("العلاج");
            Dt.Columns.Add("الوصفة الطبية");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("الحجم");
            Dt.Columns.Add("وقت الاستخدام");

            Dt.Columns.Add("المدة");
            Dt.Columns.Add("رقم الوصفة");


            dgPrescription.DataSource = Dt1;
        }
        void ClearText()
        {
            txtpressName.Text = "";
            txtprestiemuse.Text = "";
            txtpresQyt.Text = "";
            txtpresPriod.Text = "";
            txtpresCode.Text = "";
            txtpresSize.Text = "";
            comdrId.Text = "";
           
        }

        void ResizeDGV()
        {
            try
            {
                this.dgPrescription.RowHeadersVisible = false;
                this.dgPrescription.RowHeadersWidth = 10;

                this.dgPrescription.Columns[0].Width = 87;
                this.dgPrescription.Columns[1].Width = 128;
                this.dgPrescription.Columns[2].Width = 225;
                this.dgPrescription.Columns[3].Width =75;
                this.dgPrescription.Columns[4].Width = 76;
                this.dgPrescription.Columns[5].Width = 173;
                this.dgPrescription.Columns[6].Width = 150;
            }
            catch
            {
                return;
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                

                if (STATE == 1)
                {
                    recipe.AddPrescription(txtpresCode.Text,
                            txtpressName.Text,
                            txtpresQyt.Text,
                            txtprestiemuse.Text,
                            txtpresSize.Text,
                            txtpresPriod.Text,
                            Convert.ToInt32(txtreId.Text),
                            Convert.ToInt32(comdrId.EditValue)
                           );

                    DataRow r = Dt1.NewRow();

                    r[0] = txtpresCode.Text;
                    r[1] = comdrId.EditValue;
                    r[2] = txtpressName.Text;
                    r[3] = txtpresQyt.Text;
                    r[4] = txtpresSize.Text;
                    r[5] = txtprestiemuse.Text;
                    r[6] = txtpresPriod.Text;

                    Dt1.Rows.Add(r);
                    dgPrescription.DataSource = Dt1;
                    ClearText();
                    txtpresCode.Focus();
                }
                else
                {
                    DataRow r = Dt.NewRow();

                    r[0] = txtpresCode.Text;
                    r[1] = comdrId.EditValue;
                    r[2] = txtpressName.Text;
                    r[3] = txtpresQyt.Text;
                    r[4] = txtpresSize.Text;
                    r[5] = txtprestiemuse.Text;
                    r[6] = txtpresPriod.Text;

                    Dt.Rows.Add(r);
                    dgPrescription.DataSource = Dt;
                    ClearText();
                    txtpresCode.Focus();
                }
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(daterecipe.Text=="")
            {
                MessageBox.Show("يجب ادخال التاريخ","حقل التاريخ !!فارغّ!!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Hand);
                return;
            }
            try
            {
                if (STATE == 0)
                {



                    //check values
                    if (txtreId.Text == string.Empty || txtviId.Text == string.Empty || dgPrescription.Rows.Count < 1)
                    {
                        MessageBox.Show("ينبغي ادخال المعلومات المهمة", "تنبه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //اضافة معلومات الرشدة الطبية 
                    recipe.AddRecipe(txtreCode.Text, daterecipe.Text, timerecipe.Text, txtreNote.Text, VISITID);
                    recipeId = Convert.ToInt32(recipe.getMaxRecipeID().Rows[0][0].ToString())-1;
                  
                    //  اضافة الوصفات الطبية للرشدة
                    for (int i = 0; i < dgPrescription.Rows.Count; i++)
                    {
                       
                        recipe.AddPrescription(dgPrescription.Rows[i].Cells[1].Value.ToString(),
                           Convert.ToString(dgPrescription.Rows[i].Cells[3].Value),
                            Convert.ToString(dgPrescription.Rows[i].Cells[4].Value),
                            Convert.ToString(dgPrescription.Rows[i].Cells[5].Value),
                           Convert.ToString(dgPrescription.Rows[i].Cells[6].Value),
                            Convert.ToString(dgPrescription.Rows[i].Cells[7].Value),
                           recipeId,
                           Convert.ToInt32(dgPrescription.Rows[i].Cells[2].Value.ToString())
                           );
                    }
                    MessageBox.Show("تم حفظ الرشدة الطبية  بنجاح!!", "حفظ الرشدة ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if(STATE==1)
                {
                    dgPrescription.DataSource = Dt1;

                    //check values
                    if (txtreId.Text == string.Empty || txtviId.Text == string.Empty || dgPrescription.Rows.Count < 1)
                    {
                        MessageBox.Show("ينبغي ادخال المعلومات المهمة", "تنبه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //اضافة معلومات الرشدة الطبية 
                    recipe.UpdateRecipe(Convert.ToInt32(txtreId.Text),txtreCode.Text, daterecipe.Text, timerecipe.Text, txtreNote.Text, VISITID);

                    //  اضافة الوصفات الطبية للرشدة
                    for (int i = 0; i < dgPrescription.Rows.Count; i++)
                    {
                        
                        recipe.UpdatePrescription(Convert.ToInt32(dgPrescription.Rows[i].Cells[8].Value.ToString()),
                            Convert.ToString(dgPrescription.Rows[i].Cells[1].Value),
                            Convert.ToString(dgPrescription.Rows[i].Cells[3].Value),
                            Convert.ToString(dgPrescription.Rows[i].Cells[4].Value),
                            Convert.ToString(dgPrescription.Rows[i].Cells[5].Value),
                            Convert.ToString(dgPrescription.Rows[i].Cells[6].Value),
                           Convert.ToString(dgPrescription.Rows[i].Cells[7].Value),
                            Convert.ToInt32(txtreId.Text),
                           Convert.ToInt32(dgPrescription.Rows[i].Cells[2].Value.ToString())
                           );
                    }
                    MessageBox.Show("تم حفظ  التعديل لــالرشدة الطبية  بنجاح!!", "تعديل  الرشدة ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("غلظ في اداء العمليات غلط ....");
                }

             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtpresCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comdrId.Focus();
            }
        }

        private void comdrId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpressName.Focus();
            }
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPrescription_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void dgPrescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgPrescription.Columns["btnDelte"].Index && e.RowIndex >= 0)//make sure button index here
            {
                //write your code here
                try
                     
                {
                    ID = Convert.ToInt32(dgPrescription.CurrentRow.Cells["presId"].Value.ToString());




                   if (ID == 0)
                    {
                        MessageBox.Show("الوصفة المراد حذفه غير موجود");
                        return;
                    }

                    if (MessageBox.Show("هل تريد فعلا حذف هذا المريض", "الحذف" + ID, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        dgPrescription.Rows.RemoveAt(dgPrescription.CurrentRow.Index);
                        // تم الحذف الحقيقي من الداتا بيس في حالة كانت البيانات مخزنة فعلا
                        if (STATE == 1)
                        {
                            recipe.DeletePrescription(ID);
                            MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgPrescription.DataSource = recipe.getRecipeByRecipeId(RECIPEID);
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception", ex.Message);

                }

            }
        }

        private void txtprestiemuse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpresPriod.Focus();
            }
        }

        private void txtpressName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpresQyt.Focus();
            }
        }

        private void txtpresQyt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                txtpresSize.Focus();
        }

        private void txtpresSize_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                txtprestiemuse.Focus();

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void XtraFrmRecipe_Load(object sender, EventArgs e)
        {

           

            DBConnection db = new DBConnection();
            SqlDataAdapter da = new SqlDataAdapter("select drId, drName from dragTab", db.sqlconnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "drags");
            comdrId.Properties.DataSource = ds.Tables["drags"];
            comdrId.Properties.DisplayMember = "drName";
            comdrId.Properties.ValueMember = "drId";
            

        }
    }
}