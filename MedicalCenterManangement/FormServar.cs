using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCenterManangement
{
    public partial class FormServar : Form
    {
        public FormServar()
        {
            InitializeComponent();
        }
        DataSet DS;
        decimal d = 0;
        string con_ss = "";
        bool Isfrest = true;
        SqlConnection conloing;
        private void FormServar_Load(object sender, EventArgs e)
        {
           // con_ss = File.ReadAllText(Application.StartupPath + "\\conn.txt");

            try
            {
                if (File.Exists(con_ss))
                {
                }
                else
                {
                    // label1.Text = "ملف الدخول غير موجود";
                    // label1.ForeColor = Color.Red;
                   // label7.Enabled = false;
                    // label6.Enabled = true;
                    //button2.Visible = true;
                }
            }
            catch
            {
                // label1.Text = "ملف الدخول غير متاح";
              //  btnLogin.Enabled = false;
                //  label1.ForeColor = Color.Red;
              //  label7.Enabled = false;
                // label6.Enabled = true;
                //button2.Visible = true;
            }
            ///////////////////////////////////////////
            //// comboBox1.Text = ".sql\\";
            Sql_where = "";

        }

        private void ch_db_in_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_db_in.Checked)
            {
                tx_sql.Text = " (LocalDB)\\MSSQLLocalDB";



            }

            //if (ch_db_in.Enabled != false)
            //    btnAdd_Unit.Enabled = true;
            //else
            //    btnAdd_Unit.Enabled = false;
        }

        private void cmpath_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = cmpath.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connStrdata = "";
            //if (File.Exists(textBox1.Text) || conn_type.Text.ToString().IndexOf('.') > 0 || conn_type.Text.ToString().IndexOf('(') > 0)
            //{
            //    if (conn_type.Text.ToString().IndexOf('.') > 0)
            //    {
            //        ch_db_out.Checked = true;
            //    }
            //    else
            //        ch_db_in.Checked = true;

            //    connStrdata = conn_type.Text + textBox1.Text;
            try
            {
                SqlConnection con = new SqlConnection(connserver + "; database=" + textBox1.Text);
                con.Close();
                con.Open();
                string sql = "select Options from System_Options where Options_Name='state'";

                SqlCommand cm = new SqlCommand(sql, con);
                SqlDataReader da = cm.ExecuteReader();
                if (da.Read())
                    FormLogin.stait = da[0].ToString();
                else
                    FormLogin.stait = "open";
                con.Close();
                label2.ForeColor = Color.MediumSeaGreen;
                btnLogin.Enabled = true;
                label2.Text = "جاهز";
                // ch_db_in.Enabled = false ;
                //ch_db_out.Enabled = false ;
                //   btnAdd_Unit.Enabled = false ;
            }
            catch (Exception ex)
            {
                label2.Text = "الاتصال غير متاح بقاعدة البيانات الحالية";
                btnLogin.Enabled = false;
                label7.Enabled = true;
                label2.ForeColor = Color.Red;

            }
            //}
            //else
            //{
            //    label2.Text = "قاعدة البيانات غير موجودة";
            //    label2.ForeColor = Color.Red;
            //    label7.Enabled = true;
            //    btnLogin.Enabled = false;
            //    ch_db_in.Checked = false;
            //    ch_db_out.Checked = false;
            //    ch_db_in.Enabled = true;
            //    ch_db_out.Enabled = true;
            //    radioButton1.Checked = false;
            //    radioButton2.Checked = false;
            //    radioButton1.Enabled = true;
            //    radioButton2.Enabled = true;
            //    //btnAdd_Unit.Enabled = true;
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الخروج ؟", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void FormServar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!iscontinue)
            {
                DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الخروج ؟", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Environment.Exit(1);
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;

                }
            }
            iscontinue = false;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string pth = Application.StartupPath + "\\db_new\\FINANCY_YEAR.mdf";
        //    if (File.Exists(pth))
        //    {

        //            File.WriteAllText(Application.StartupPath + "\\conn.txt", pth);
        //            FormServar_Load(null, null);
        //        ///////////////////////////////////////////////////////////
        //        if (label1.Text == "جاهز")
        //        {
        //            for (int i = 0; i < cmYear.Items.Count; i++)
        //            {
        //                if (label2.Text != "جاهز")
        //                {
        //                    SqlCommand cm;
        //                    string sql = "";
        //                    try
        //                    {
        //                        conloing.Close();
        //                        conloing.Open();

        //                        sql = "update Years set Path='" + Application.StartupPath + "\\db_new\\" + cmYear.GetItemText(cmYear.  Items[i]) + ".mdf" + "' where Year_Name='" + cmYear.GetItemText(cmYear.Items[i]) + "'";
        //                        cm = new SqlCommand(sql, conloing);
        //                        cm.ExecuteNonQuery();

        //                        conloing.Close();
        //                    }
        //                    catch
        //                    {

        //                    }


        //                }
        //                else
        //                {
        //                    try
        //                    {
        //                        cmYear.SelectedItem = cmYear.Items[cmYear.SelectedIndex + 1];
        //                    }
        //                    catch
        //                    {
        //                    }
        //                }

        //            }
        //            FormServar_Load(null, null);
        //        }
        //        else
        //        {
        //           // label1.Text = "ملفات الدخول الموجودة غير صالحة";

        //        }
        //    }
        //    else
        //    {
        //       // label1.Text = "تعذر علينا الحصول على ملفات الدخول بالمسارات الافتراضيه";
        //    }
        //}
        Boolean iscontinue = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (File.Exists(Application.StartupPath + "\\logserver.txt"))
            {
                File.WriteAllText(Application.StartupPath + "\\logserver.txt", tx_sql.Text.ToString().Trim() + " \n" + radioButton1.Checked.ToString() + " \n" + radioButton2.Checked.ToString() + " \n" + EncryptionClass.Encrypt(txtUserName.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + EncryptionClass.Encrypt(txtPassword.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + cmYear.Text);

            }
            else
            {
                try
                {
                    File.Create(Application.StartupPath + "\\logserver.txt");
                    File.WriteAllText(Application.StartupPath + "\\logserver.txt", tx_sql.Text.ToString().Trim() + " \n" + radioButton1.Checked.ToString() + " \n" + radioButton2.Checked.ToString() + " \n" + EncryptionClass.Encrypt(txtUserName.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + EncryptionClass.Encrypt(txtPassword.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + cmYear.Text);
                }
                catch { }
            }
            ///////////////////////////////////////////////////////////
            string[] namedata;
            Boolean isinsert = false;
            if (File.Exists(Application.StartupPath + "\\dataname.txt"))
            {
                namedata = File.ReadAllLines(Application.StartupPath + "\\dataname.txt");
                if (namedata != null)
                {
                    for (int i = 0; i < namedata.Length; i++)
                        if (cmYear.Text == namedata[i])
                            isinsert = true;
                    //////////////////////////////////////
                }
                if (isinsert == false)
                {
                    namedata = new string[1];
                    namedata[0] = cmYear.Text;
                    File.AppendAllLines(Application.StartupPath + "\\dataname.txt", namedata);
                }
            }
            iscontinue = true;
            FormLogin.yir = cmYear.Text;

            FormLogin.path_databas = textBox1.Text;
            FormLogin.connfordata_tayp = connserver + "; database=";
            this.Close();
        }

        //private void label6_Click(object sender, EventArgs e)
        //{


        //        openFileDialog1.Filter = " DataBase (*.log) | *.log; *.log| all files (*.log) | *.log";

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //            try
        //            {
        //                //string connStr = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + openFileDialog1.FileName.ToString().Substring(0, openFileDialog1.FileName.ToString().LastIndexOf("\\") + 1) + "financy_year.mdf; Integrated Security = True; Connect Timeout = 30;"; //"DATA SOURCE='NAEL-PC\\SQLEXPRESS';" + //server name sql server

        //                //SqlConnection con = new SqlConnection(connStr);
        //                //con.Close();
        //                //con.Open();
        //                //string sql = "select * from Years";
        //                //SqlCommand cm = new SqlCommand(sql, con);
        //                //SqlDataReader da = cm.ExecuteReader();
        //                //con.Close();
        //                //tx_pathLogin.Text = openFileDialog1.FileName.ToString().Substring(0, openFileDialog1.FileName.ToString().LastIndexOf("\\") + 1) + "financy_year.mdf";
        //            if(File .Exists(tx_pathLogin.Text))
        //            {
        //                File.WriteAllText(Application.StartupPath + "\\conn.txt", tx_pathLogin.Text);
        //                FormServar_Load(null, null);
        //            }
        //        }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("اختيار خاطئ" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }
        //        }

        //    }

        private void label7_Click(object sender, EventArgs e)
        {

            string connStr = "";

            openFileDialog1.Filter = " DataBase (*.mdf) | *.mdf; *.mdf| all files (*.mdf) | *.mdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                connStr = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + openFileDialog1.FileName + "; Integrated Security = True ;Connect Timeout = 30;"; //"DATA SOURCE='NAEL-PC\\SQLEXPRESS';" + //server name sql server
                try
                {
                    SqlConnection con = new SqlConnection(connStr);
                    con.Close();
                    con.Open();
                    string sql = "select * from Branch";
                    SqlCommand cm = new SqlCommand(sql, con);
                    SqlDataReader da = cm.ExecuteReader();
                    con.Close();

                    try
                    {
                        conloing.Close();
                        conloing.Open();
                        sql = "update Years set Path='" + openFileDialog1.FileName + "' where Year_Name='" + cmYear.Text + "'";
                        cm = new SqlCommand(sql, conloing);
                        cm.ExecuteNonQuery();
                        conloing.Close();
                    }
                    catch
                    {
                        MessageBox.Show("القاعدة المختارة محجوزة لسنة مالية اخرى");
                        return;
                    }

                    FormServar_Load(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("اختيار خاطئ" + ex.Message);
                    return;
                }




            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
        }
        string connserver = "";
        void start_server()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (tx_sql.ReadOnly == false)
            {
                if (!ch_db_out.Checked && !ch_db_in.Checked)
                {
                    MessageBox.Show("حدد نوع الاتصال", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ch_db_out.Checked == true || ch_db_in.Checked == true)
                //
                {//192.168.1.8\SQLEXPRESS
                 //Data Source = DESKTOP-6S11TJB; Initial Catalog = DB2020; User ID = sa;Password=nano12345;
                    if (radioButton2.Checked)
                        connserver = ("Data Source=" + tx_sql.Text + ";server=" + tx_sql.Text + "; integrated security=true");
                    else if (radioButton1.Checked)
                    {
                        if (Convert.ToString(txtUserName.Text) == "" || Convert.ToString(txtPassword.Text) == "")
                        {
                            MessageBox.Show("ادخل اسم المستخدم وكلمة المرور ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        connserver = ("Data Source=" + tx_sql.Text + ";server=" + tx_sql.Text + "; Network Library = DBMSSOCN; User ID =" + txtUserName.Text + " ;Password=" + txtPassword.Text);

                    }
                    else
                    {
                        MessageBox.Show("حدد طريقة الدخول الى الخادم ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Boolean isempte = false;
                    try
                    {
                        //SqlConnection conisdata = new SqlConnection(connserver + "; database=" + textBox1.Text);
                        //conisdata.Close();
                        //conisdata.Open();
                        //string sql = "select * from Branch";

                        //SqlCommand cm = new SqlCommand(sql, conisdata);
                        //SqlDataReader da = cm.ExecuteReader();
                        //conisdata.Close();
                        SqlConnection con = new SqlConnection(connserver);
                        string sql = "";
                        string[] namedata;
                        string whersq = "";
                        con.Open();
                        if (File.Exists(Application.StartupPath + "\\dataname.txt") && !isshift)
                        {
                            namedata = File.ReadAllLines(Application.StartupPath + "\\dataname.txt");
                            if (namedata != null)
                            {
                                for (int i = 0; i < namedata.Length; i++)
                                    whersq += "'" + namedata[i] + "',";
                                whersq += "''";
                                sql = "select name from sys.databases where name in(" + whersq + ")";
                            }
                            else
                                sql = "select name from sys.databases";

                        }
                        else
                        {
                            //File.Create(Application.StartupPath + "\\dataname.txt");
                            FileStream f = new FileStream(Application.StartupPath + "\\dataname.txt", FileMode.Create);
                            f.Close();
                            sql = "select name from sys.databases";
                            isempte = true;
                        }
                        SqlCommand cm = new SqlCommand(sql, con);

                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(cm);
                        da.Fill(ds);
                        label10.Text = con.ServerVersion;
                        label10.ForeColor = Color.MediumSeaGreen;
                        Sql_where = "";
                        SqlConnection conisdata;
                        SqlDataReader dr;
                        cmYear.Items.Clear();
                        int indx = 0;
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            try
                            {

                                conisdata = new SqlConnection(connserver + "; database=" + ds.Tables[0].Rows[i].ItemArray[0].ToString());
                                conisdata.Close();
                                conisdata.Open();
                                sql = "select * from visitTab";

                                cm = new SqlCommand(sql, conisdata);
                                dr = cm.ExecuteReader();
                                conisdata.Close();
                                if (loginserver != null)
                                {
                                    try
                                    {
                                        if (ds.Tables[0].Rows[i].ItemArray[0].ToString() == loginserver[5])
                                            indx = cmYear.Items.Count;
                                    }
                                    catch { }

                                }
                                if (isempte)
                                {
                                    namedata = new string[1];
                                    namedata[0] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                                    File.AppendAllLines(Application.StartupPath + "\\dataname.txt", namedata);
                                }
                                cmYear.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                            }
                            catch { }
                            // cmYear.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                            //    if (Sql_where.Length == 0)
                            //        Sql_where = " where Path in ('" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "',";
                            //    else 
                            //    Sql_where += "'"+ds.Tables[0].Rows[i].ItemArray[0].ToString() + "',";

                            //}
                            //if (Sql_where.Length > 0)
                            //{
                            //    Sql_where = Sql_where.Substring(0, Sql_where.LastIndexOf(',') ) + ")";

                        }

                        con.Close();
                        try { cmYear.SelectedIndex = indx; }
                        catch { }
                        //FormServar_Load (null ,null );
                        //Sql_where = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل الاتصال بالخادم " + tx_sql.Text, ex.Data.Values.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label10.Text = "فشل الاتصال بالخادم " + tx_sql.Text;
                        label10.ForeColor = Color.Red;
                        return;
                    }

                }
            }
            Cursor.Current = Cursors.Default;
            isshift = false;
        }
        private void tx_sql_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                start_server();
            }

        }
        string Sql_where = "";
        private void btnAdd_Unit_Click(object sender, EventArgs e)
        {
            //FormAdd_database f = new FormAdd_database(conloing);
            //f.ShowDialog();
            //FormServar_Load(null, null);
            

        }

        private void tx_sql_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = cmYear.Text;
            btnLogin.Focus();
        }

        private void ch_db_out_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_db_out.Checked)
            {
                tx_sql.Text = ".\\";

                //  this.AcceptButton = null;

            }
        }
        string[] loginserver;

        private void FormServar_Shown(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\logserver.txt"))
            {
                loginserver = File.ReadAllLines(Application.StartupPath + "\\logserver.txt");

                if (loginserver.Length > 0)
                {

                    if (loginserver[0].IndexOf('(') > 0)
                    {
                        ch_db_in.Checked = true;
                        tx_sql.Text = loginserver[0].ToString().Trim();
                        tx_sql.Focus();
                    }
                    else
                    {
                        ch_db_out.Checked = true;
                        tx_sql.Text = loginserver[0].ToString().Trim();
                        tx_sql.Focus();
                    }
                    radioButton1.Checked = Boolean.Parse(loginserver[1]);
                    radioButton2.Checked = Boolean.Parse(loginserver[2]);
                    txtUserName.Text = EncryptionClass.Decrypt(loginserver[3], "nanoahmedmohammmadnaelzadf18");
                    txtPassword.Text = EncryptionClass.Decrypt(loginserver[4], "nanoahmedmohammmadnaelzadf18");
                }
            }
            //ch_db_in.Checked =true;
            //tx_sql.Focus();
        }

        private void btnLogin_EnabledChanged(object sender, EventArgs e)
        {
            if (btnLogin.Enabled)
                btnLogin.Focus();
            else
                cmYear.Focus();
        }
        Boolean isshift = false;
        private void tx_sql_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                isshift = true;
            }
        }

        private void tx_sql_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Shift)
            //{
            //    isshift = false;
            //}
        }

        private void groupBox4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.F9 && e.KeyData == Keys.Enter)
            {

            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                isshift = true;
            //    start_server();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                start_server();
            }
        }
    }

}

