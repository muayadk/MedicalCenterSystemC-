using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Diagnostics;

namespace MedicalCenterManangement
{
    public partial class FormLogin : Form
    {

       
       // public FormFastArraive f_fast;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public static string name;// name of user to welcome him ,in mainform
        public static int plevel; // permission var

        private string sql;
        private SqlConnection conn;
        FormServar fServar;
    static    public  string yir;
        static public string connfordata_tayp;
        static public string path_databas;
        static public string stait;
        public FormLogin()
        {
            
            InitializeComponent();
            FormLogin.CheckForIllegalCrossThreadCalls = false;
            //Process[] pr = Process.GetProcessesByName("NANO ACCOUNT PROGRAM");

            //if (pr.Length > 1)
            //{
            //    FormConnectSet fco = new FormConnectSet();
            //    fco.ShowDialog();
            //}

            try
            {
               fServar = new FormServar();
                //yir = fServar.cmYear.Text;
                fServar.ShowDialog();
                btnLogin.Enabled = true;
              //  con_ss = File.ReadAllText(Application.StartupPath + "\\conn.txt");

                //try
                //{
              //   string connStr = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + con_ss + "; Integrated Security = True; Connect Timeout = 30;"; //"DATA SOURCE='NAEL-PC\\SQLEXPRESS';" + //server name sql server

               //    SqlConnection con = new SqlConnection(connStr);
                ////    con.Close();
                //    con.Open();
                //    string sql = "select * from Years";
                //    SqlCommand cm = new SqlCommand(sql, con);
                //    SqlDataReader da = cm.ExecuteReader();
                //    con.Close();
           //        con_ss = connStr;
                //}
                //catch
                //{
                //    FormConnet ff = new FormConnet("file");

                //    ff.label1.Text = "حدد مسار ملف الدخول";
                //    ff.ShowDialog();
                //    btnLogin.Enabled = false;
                //    return;
                //}
            }
            catch
            {
                MessageBox.Show("المعذرة لم يتم العثور على بعض ملفات النظام");
                return;
            }
            txtUserName.Focus();
            year();

          
        }

        public string con_ss;

        void year()
        {
           SqlConnection con = new SqlConnection();
            try
            {

               // FormServar fServar =(FormServar) Application.OpenForms["FormServar"];
               // con.Close();
                //con.Open();
                sql = "SELECT " + yir + ", " + stait  + ", " + path_databas + ", " + connfordata_tayp + " FROM Years where Year_Name='" + yir + "' order by Year_Name DESC";

                //sql = "SELECT Year_Name,State,Path,Connect_Type FROM Years where Year_Name='"+ yir + "' order by Year_Name DESC";
                //SqlDataAdapter SDA = new SqlDataAdapter(sql, con);
                //SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                //var DS = new DataSet();
                //SDA.Fill(DS, "Years");
                //cmYear.DisplayMember = "Year_Name";
                //cmState.DisplayMember = "State";
                //cmpath.DisplayMember = "Path";
                //conn_type.DisplayMember = "Connect_Type";
                //// cmbCash.ValueMember = "Cash_Name";
                cmYear.Text = yir;//.DataSource = DS.Tables["Years"];
                cmState.Text = stait;//.DataSource = DS.Tables["Years"];
                cmpath.Text = path_databas;//DataSource = DS.Tables["Years"];
                conn_type.Text = connfordata_tayp;
                //conn_type.DataSource = DS.Tables["Years"];
                //con.Close();
                //if (DS.Tables[0].Rows[0]["Connect_Type"].ToString() == "")
                //{
                //    FormConnectSet f = new FormConnectSet(con_ss,cmYear.Text);
                //    f.ShowDialog();
                //}

               
            }
            catch (Exception es)
            {
             //   con.Close();
                MessageBox.Show(es.Message);
            }
        }
        public string p = "";
        bool branch_test()
        {
            try
            {
                string sq = "select Branch_Num from Branch where Branch_Num='" + int.Parse(txtbranch.Text) + "'";
                conn.Close();
                conn.Open();
                SqlCommand cmdSql = new SqlCommand(sq, conn);
                SqlDataReader dr = cmdSql.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    conn.Close();
                    return true;
                }
                dr.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            conn.Close();
            return false;
        }
        public int user_Num = 0;
        public string Permission = "";
        public Boolean isAdmin = false;
        public string Status = null;

        void validateUser()
        {
            try
            {
                string username;
                string password;
                string branch;

                username = txtUserName.Text;
                password = txtPassword.Text;
                branch = txtbranch.Text;
                if (username != "")
                {
                    sql = "SELECT User_Login_Name,User_Pass,Full_Name,Permission_Level,User_Num,Is_Admin,Status FROM Users WHERE User_Login_Name =@d1";
                    if (conn.State == ConnectionState.Closed)
                    {

                        conn.Open();
                    }
                    SqlCommand cmdSql = new SqlCommand(sql, conn);
                    cmdSql.Parameters.AddWithValue("@d1",username);
                    SqlDataReader dr = cmdSql.ExecuteReader();

                    if (dr.Read())
                    {
                        Status = Convert.ToString(dr["Status"].ToString());

                        if (Status == "")
                        {
                            MessageBox.Show("عزيزي المستخدم بما انه يعد هذا اول دخول لك الى النظام يجب تعين كلمة مرور جديدة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormUser_Activation f = new FormUser_Activation(username);
                            f.ShowDialog();
                            return;
                        }


                    }

                }


                if (username == "" || password == "" || branch == "" || cmYear.Text == "")
                {
                   
                    MessageBox.Show("يجب ملئ البيانات","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   
                }
                else
                {
                 sql = "SELECT User_Login_Name,User_Pass,Full_Name,Permission_Level,User_Num,Is_Admin,Status FROM Users WHERE User_Login_Name =@d1 AND User_Pass =@d2";

                    if (branch_test() == false)
                    {
                        //f6.Close();
                        //thshow.Abort();
                        MessageBox.Show("رقم الفرع غير موجود","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand cmdSql = new SqlCommand(sql, conn);
                    cmdSql.Parameters.AddWithValue("@d1", username);
                    cmdSql.Parameters.AddWithValue("@d2", password);
                    SqlDataReader dr = cmdSql.ExecuteReader();

                    if (dr.Read())
                    {
                        Status = Convert.ToString(dr["Status"].ToString());

                        if (Status.Trim() == "Lok")
                        {
                            MessageBox.Show("المستخدم الحالي موقف مؤقتاً يرجى التواصل بمسؤول النظام", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (Status.Trim() == "Delete")
                        {
                            MessageBox.Show("المستخدم الحالي غير موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ///////////////////////////////////////////////////////////////////
 
                        user_Num = int.Parse(dr["User_Num"].ToString());
                        Permission = dr["Permission_Level"].ToString();
                        isAdmin = Boolean.Parse(dr["Is_Admin"].ToString());
                        name = dr["Full_Name"].ToString();
                        dr.Close();
                        conn.Close();
                        //MessageBox.Show(plevel.ToString(), "Warning", MessageBoxButtons.OK);
                        string abc = @"Software\Nano\Protection";
                        Secure scr = new Secure();
                        /////////////////////////////////////////////////////////////
                       
                        ///////////////////////////////////////////////////////////
                        string clo = scr.building();
                        if (clo == "")
                            Application.ExitThread();
                        // MessageBox.Show(EncryptionClass.Encrypt("nano+ahmed+mohammmad+nael+zadf18", "$+-qq19$-rs"));
                        bool logic = scr.Algorithm(clo, abc);
                        if (logic == true)
                        {
                           View. XtraFrmVisit frm = new View.XtraFrmVisit();
                            frm.Show();
                            //f_fast = new FormFastArraive();
                            //f_fast.Show();
                            this.Hide();

                        }
                        // MessageBox.Show("تم تسجيل الدخول بنجاح ", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //f6.Close();
                        //thshow.Abort();
                        MessageBox.Show(" خطأ في اسم المستخدم او كلمة السر  ", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    dr.Close();
                    conn.Close();

                }
            }
            catch (Exception es)
            {// set 
                try
                {
                    string sql = "ALTER TABLE dbo.Users ADD Status NVARCHAR (10)";
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand cm = new SqlCommand(sql, conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("عزيزي المستخدم \n  لقد وجدنا تحديث جديد في جزء من قواعد البيانات الخاصة بك  \n لا تقلق عزيزي المستخدم لا توجد اي اشكالية وانما قم بتكرار عملية تسجيل الدخول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception es1)
                {
                    MessageBox.Show(" محاولةتحديث قاعدة البيانات فاشلة"+es1.Message+" /n "+ es.Message);
                }
               // MessageBox.Show(es.Message);
            }
        }
       // Thread thshow;
       
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //////////////////////////////////
            DBConnection db = new DBConnection();//dbconnction is class name
            //thshow = new Thread(showdow);
            //thshow.Start();
            conn = db.masterConn();
            if (btnLogin.Enabled == true)
                validateUser();
            else
                return;
            if (File.Exists(Application.StartupPath + "\\loginList.txt"))
            {if(checkBox1.Checked)
                File.WriteAllText(Application.StartupPath + "\\loginList.txt", EncryptionClass.Encrypt(txtUserName.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + EncryptionClass.Encrypt(txtPassword.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + txtbranch.Text + " \n" +Convert .ToString( checkBox1.Checked) );
            else
                    File.WriteAllText(Application.StartupPath + "\\loginList.txt", EncryptionClass.Encrypt(txtUserName.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + EncryptionClass.Encrypt("", "nanoahmedmohammmadnaelzadf18") + " \n" + txtbranch.Text + " \n" + Convert.ToString(checkBox1.Checked));
            }
            else
            {
                try
                {
                    File.Create(Application.StartupPath + "\\loginList.txt");
                  
                    if (checkBox1.Checked)
                        File.WriteAllText(Application.StartupPath + "\\loginList.txt", EncryptionClass.Encrypt(txtUserName.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + EncryptionClass.Encrypt(txtPassword.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + txtbranch.Text + " \n" + Convert.ToString(checkBox1.Checked));
                    else
                        File.WriteAllText(Application.StartupPath + "\\loginList.txt", EncryptionClass.Encrypt(txtUserName.Text, "nanoahmedmohammmadnaelzadf18") + " \n" + EncryptionClass.Encrypt("", "nanoahmedmohammmadnaelzadf18") + " \n" + txtbranch.Text + " \n" + Convert.ToString(checkBox1.Checked));
                }
                catch { }
            }
            ///////////////////////////////////////////////////////////

            //f6.Close();
            //thshow.Abort();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

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

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmYear_SelectedValueChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }
        string[] loginserver;
        private void txtbranch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || e.KeyChar == (char)8 || e.KeyChar == (char)13))
                e.Handled = true;

        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\loginList.txt"))
            {
                loginserver = File.ReadAllLines(Application.StartupPath + "\\loginList.txt");

                if (loginserver.Length > 0)
                {
                    try
                    {

                        txtUserName.Text = EncryptionClass.Decrypt(loginserver[0], "nanoahmedmohammmadnaelzadf18");
                        txtPassword.Text = EncryptionClass.Decrypt(loginserver[1], "nanoahmedmohammmadnaelzadf18");
                        txtbranch.Text = loginserver[2].ToString().Trim();
                        checkBox1.Checked = Boolean.Parse(loginserver[3]);
                    }catch { }
                }
            }

        }
        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FormLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
        void s()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //EncryptionClass.Encrypt("nanoahmedmohammmadnaelzadf18", "14DDA98EC159" + "t3xzq162");
            //Form1 f = new Form1(EncryptionClass.Encrypt("nanoahmedmohammmadnaelzadf18", "14DDA98EC159" + "t3xzq162"),"");

           // f.ShowDialog();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
