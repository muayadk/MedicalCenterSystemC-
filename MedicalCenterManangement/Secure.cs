using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Win32;
using System.Windows.Forms;
//using NANO_ACCOUNT_PROGRAM;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Net.NetworkInformation;
using ESD;
using System.Management;

namespace MedicalCenterManangement
{
    public class Secure
    {
        private SqlConnection conn;
        private string globalPath;
        private void firstTime(string install)
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(globalPath); //path


            regkey.SetValue("Install", install); //Value Name,Value Data

        }
        private void firstTime()
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(globalPath); //path

            IsConstiant date_conv = new IsConstiant();
            string toDate = date_conv.ConvertDateCalendar(DateTime.Now, "en-US");

            // DateTime dt = DateTime.Now;
            string onlyDate = date_conv.ConvertDateCalendar(DateTime.Now, "en-US"); // get only date not time

            regkey.SetValue("Install", onlyDate); //Value Name,Value Data
            regkey.SetValue("Use", onlyDate); //Value Name,Value Data
        }
        private void firstTime(string instail, string use)
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(globalPath); //path

            // IsConstiant date_conv = new IsConstiant();
            //  string toDate = date_conv.ConvertDateCalendar(DateTime.Now, "en-US");

            // DateTime dt = DateTime.Now;
            // string onlyDate = date_conv.ConvertDateCalendar(DateTime.Now, "en-US"); // get only date not time

            regkey.SetValue("Install", instail); //Value Name,Value Data
            regkey.SetValue("Use", use); //Value Name,Value Data
        }
        private String checkfirstDate()
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(globalPath); //path
            string Br = (string)regkey.GetValue("Install");
            if (regkey.GetValue("Install") == null)
                return "First";
            else
                return Br;
        }
        Boolean isMaintenance = false;
        private bool checkPassword(String pass)
        { try
            {
                isMaintenance = false;
                Declaration dec;
                dec = new Declaration();
                string Br = dec.A_Key;
                if (Br == pass)
                {
                    isMaintenance = true;
                    return dec.Statement(); ;

                }
                else
                    return false;
            }
            catch
            {

            }
            return false;
           // RegistryKey regkey = Registry.CurrentUser;
           // regkey = regkey.CreateSubKey(globalPath); //path
           //// string Br = (string)regkey.GetValue("Password");
           // //Br = EncryptionClass.Decrypt(Br, "qq19rs");
           // //MessageBox.Show(Br);
           // if (Br == pass)
           //     return true; //good
           // else
           //     return false;//bad
        }
        public string ConvertDateCalendar(DateTime DateConv, string DateLangCulture)
        {
            System.Globalization.DateTimeFormatInfo DTFormat;
            DateLangCulture = DateLangCulture.ToLower();

            DTFormat = new System.Globalization.CultureInfo(DateLangCulture, false).DateTimeFormat;

            /// Set the calendar property of the date time format to the given calendar - LAITH - 11/13/2005 1:04:52 PM -

            DTFormat.Calendar = new System.Globalization.GregorianCalendar();

            /// We format the date structure to whatever we want - LAITH - 11/13/2005 1:05:39 PM -
            DTFormat.ShortDatePattern = "M/d/yyyy";
            string ss = DateConv.Date.ToString(DTFormat);
            ss = ss.Substring(0, ss.IndexOf(' '));
            return ss;
        }

        private String dayDifPutPresent()
        {
            // get present date from system
            DateTime dt = DateTime.Now;
            IsConstiant date_conv = new IsConstiant();

            string today =ConvertDateCalendar(dt, "en-US");
            //DateTime presentDate = Convert.ToDateTime(today);
            DateTime presentDate = DateTime.ParseExact(today, "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            // get instalation date
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(globalPath); //path
            string Br = (string)regkey.GetValue("Install");
            DateTime installationDate = DateTime.ParseExact(Br, "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            
            TimeSpan diff = presentDate.Subtract(installationDate); //first.Subtract(second);
            int totaldays = (int)diff.TotalDays;

            // special check if user chenge date in system
            string usd = (string)regkey.GetValue("Use");
            DateTime lastUse = DateTime.ParseExact(usd, "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //Convert.ToDateTime(usd);
            TimeSpan diff1 = presentDate.Subtract(lastUse); //first.Subtract(second);
            int useBetween = (int)diff1.TotalDays;
            

            if (useBetween >= 0)
            {

                if (totaldays < 0)
                    return "Error"; // if user change date in system like date set before installation
                else if (totaldays >= 0 && totaldays <= 100)
                {
                    regkey.SetValue("Use", today);
                    upd_use(today);
                    return Convert.ToString(100 - totaldays);
                }//how many days remaining
                else
                {
                    regkey.SetValue("Use", today);
                    upd_use(today);
                    return "Expired"; //Expired
                }
            }
            else
                return "Error"; // if user change date in system
        }

        private void blackList()
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(globalPath); //path

            regkey.SetValue("Black", "True");


        }
        void upd_use(string use)
        {
            try
            {

                SqlCommand cmd;
                string sql = "update Serial_Table set use_date ='" + EncryptionClass.Encrypt(use.ToString(), "t3xzq162")  + "'";
                conn.Close();
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                // MessageBox.Show(use);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private bool blackListCheck()
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(globalPath); //path
            string Br = (string)regkey.GetValue("Black");
            //  DialogResult ds = MessageBox.Show(Br);
            if (regkey.GetValue("Black") == null)
                return false; //No
            else
                return true;//Yes
        }

        public bool Algorithm(String appPassword, String pass)
        {
            globalPath = pass;
            bool chpass = checkPassword(appPassword);
            if (chpass == true) //execute
                return true;
            else
            { if(isMaintenance)
                    return false ;
                bool block = blackListCheck();
                if (block == false)
                {
                    string chinstall = checkfirstDate();
                    if (chinstall == "First")
                    {
                        if (chek)
                        {
                            firstTime(instail, use);


                            //firstTime(instail);

                            string status = dayDifPutPresent();
                            if (status == "Error")
                            {
                                // blackList();
                                DialogResult ds = MessageBox.Show("Application Can't be loaded, Unauthorized Date Interrupt Occurred! Without activation it can't run! Would you like to activate it?", "Terminate Error-02", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (ds == DialogResult.Yes)
                                {
                                    Form1 f1 = new Form1(appPassword, globalPath);
                                    DialogResult ds1 = f1.ShowDialog();
                                    if (ds1 == DialogResult.OK)
                                        return true;
                                    else
                                        return false;
                                }
                                else
                                    return false;
                            }
                            else if (status == "Expired")
                            {
                                DialogResult ds = MessageBox.Show("The trial version is now expired! Would you Like to Activate it Now!", "Product key", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (ds == DialogResult.Yes)
                                {
                                    Form1 f1 = new Form1(appPassword, globalPath);
                                    DialogResult ds1 = f1.ShowDialog();
                                    if (ds1 == DialogResult.OK)
                                        return true;
                                    else
                                        return false;
                                }
                                else
                                    return false;
                            }
                            else // execute with how many day remaining   SetValue
                            {
                                DialogResult ds = MessageBox.Show("يجب عليك تنشيط البرنامج بعد " + status + " يوم  \n  هل تريد التنشيط الأن", "Product key", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (ds == DialogResult.Yes)
                                {
                                    Form1 f1 = new Form1(appPassword, globalPath);
                                    DialogResult ds1 = f1.ShowDialog();
                                    if (ds1 == DialogResult.OK)
                                        return true;
                                    else
                                        return false;
                                }
                                else
                                    return true;
                            }

                        }
                        else
                        {
                            firstTime();// installation date
                            DialogResult ds = MessageBox.Show("سيتطلب الأمر منك تنشيط البرنامج بعد فترة محدودة! " + "  \n " + "هل تريد التنشيط الأن!", "Product key", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (ds == DialogResult.Yes)
                            {
                                Form1 f1 = new Form1(appPassword, globalPath);
                                DialogResult ds1 = f1.ShowDialog();
                                if (ds1 == DialogResult.OK)
                                    return true;
                                else
                                    return false;
                            }
                            else
                                return true;
                        }
                    }
                    else
                    {

                        firstTime(instail, use);
                        string status = dayDifPutPresent();
                        if (status == "Error")
                        {
                            //blackList();
                            DialogResult ds = MessageBox.Show("البرنامج لن يعمل حتى يتم التفعيل ,هل تريد التفعيل الان؟", "خطأ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (ds == DialogResult.Yes)
                            {
                                Form1 f1 = new Form1(appPassword, globalPath);
                                DialogResult ds1 = f1.ShowDialog();
                                if (ds1 == DialogResult.OK)
                                    return true;
                                else
                                    return false;
                            }
                            else
                                return false;
                        }
                        else if (status == "Expired")
                        {
                            DialogResult ds = MessageBox.Show("فترة السماح انتهت يجب عليك التفعيل ,هل تريد التفعيل الان", "Product key", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (ds == DialogResult.Yes)
                            {
                                Form1 f1 = new Form1(appPassword, globalPath);
                                DialogResult ds1 = f1.ShowDialog();
                                if (ds1 == DialogResult.OK)
                                    return true;
                                else
                                    return false;
                            }
                            else
                                return false;
                        }
                        else // execute with how many day remaining   SetValue
                        {
                            DialogResult ds = MessageBox.Show("يجب عليك تنشيط البرنامج بعد " + status + " يوم  \n  هل تريد التنشيط الأن", "Product key", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (ds == DialogResult.Yes)
                            {
                                Form1 f1 = new Form1(appPassword, globalPath);
                                DialogResult ds1 = f1.ShowDialog();
                                if (ds1 == DialogResult.OK)
                                    return true;
                                else
                                    return false;
                            }
                            else
                                return true;
                        }
                    }
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Application Can't be loaded, Unauthorized Date Interrupt Occurred! Without activation it can't run! Would you like to activate it?", "Terminate Error-01", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (ds == DialogResult.Yes)
                    {
                        Form1 f1 = new Form1(appPassword, globalPath);
                        DialogResult ds1 = f1.ShowDialog();
                        if (ds1 == DialogResult.OK)
                            return true;
                        else
                            return false;
                    }
                    else
                        return false;
                    //return "BlackList";
                }
            }
        }
        public string building()
        {
            string s = instailserual();
            if (s == "")
                return s;
            string keyy = EncryptionClass.Encrypt("nanoahmedmohammmadnaelzadf18", s + "t3xzq162");
           // string keyy = EncryptionClass.Decrypt("8uQr0vvruTvMp5XA34FrVfb6jh1qV4aPOrHIST9F8vQ =" , "nanoahmedmohammmadnaelzadf18");

            //8uQr0vvruTvMp5XA34FrVfb6jh1qV4aPOrHIST9F8vQ=
            // MessageBox.Show(keyy);
            return keyy;
        }
        public string key_serial = "";
        int day=0;
        public string instailserual()
        {
            // string con_ss = File.ReadAllText(Application.StartupPath + "\\conn.txt");
            string sql;
            SqlCommand cm;
            
            sql = "select * from Serial_Table";
            SqlDataReader dr;
            
            try
            {
                
                Declaration dec;
                dec = new Declaration();

                //  = new Declaration();
                if (dec.Activity(getMACAdress()) == "No")
                {
                    DialogResult ds= MessageBox.Show("معذرة هذا الجهاز غير مصرح له بتشغيل النظام يرجى التواصل مع مدير النظام" + "/n" + EncryptionClass.Encrypt("nanoahmedmohammmadnaelzadf18", getMACAdress() + "t3xzq162") + "\n"+"هل تريد انشاء ملف طلب تصريح?", "الامان والحماية", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    
                    if (ds == DialogResult.Yes)
                    {

                        string filename = "Save Here";

                        SaveFileDialog sf = new SaveFileDialog();

                        sf.FileName = filename;

                        if (sf.ShowDialog() == DialogResult.OK)
                        {

                            string savePath = Path.GetDirectoryName(sf.FileName);

                          
                          
                            
                                FileStream f = new FileStream(savePath + "\\Declaration.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                // StreamWriter stw = new StreamWriter(f);
                                byte[] da = new byte[255];
                                da = ASCIIEncoding.Unicode.GetBytes(EncryptionClass.Encrypt("nanoahmedmohammmadnaelzadf18", getMACAdress() + "t3xzq162")+":" + getMACAdress());
                                f.Write(da,0,da.Length);
                                f.Close();
                           
                               
                        }


                    }
                    return "";
                }
                day = int.Parse ( dec.day);

            // con = new SqlConnection(" Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + con_db + "; Integrated Security = True; Connect Timeout = 30;");
                DBConnection db = new DBConnection();
            conn = db.masterConn();
            cm = new SqlCommand(sql, conn);
            /////////////////////////////////////////////
            // Connect = new SqlConnection(connStr);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {


                    conn.Open();
                }
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    key_serial = getMACAdress();
                    // instail = EncryptionClass.Decrypt (dr["Install"].ToString(), "t3xzq162");
                     instail = dec.dateinstail;

                    use = EncryptionClass.Decrypt( dr["use_date"].ToString(), "t3xzq162");
                    dr.Close();
                    conn.Close();
                    chek = true;
                    return key_serial;
                }
                else
                {//"8/3/2019"
                    key_serial = getMACAdress();
                    dr.Close();
                    IsConstiant date_conv = new IsConstiant();
                    // string onlyDate = date_conv.ConvertDateCalendar(DateTime.Now, "en-US");

                    string onlyDate = dec.dateinstail;//date_conv.ConvertDateCalendar(DateTime.Now, "en-US");
                    //MessageBox.Show(onlyDate);
                    cm = new SqlCommand("insert into Serial_Table values('" + key_serial + "','','" + EncryptionClass.Encrypt (onlyDate, "t3xzq162") + "','" + EncryptionClass.Encrypt (onlyDate, "t3xzq162") + "')", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    chek = false;
                    instail = onlyDate;
                    use = onlyDate;
                    //MessageBox.Show(onlyDate);
                    return key_serial;
                }
               
            }
            catch
            {
                // FormConnet ff = new FormConnet("data");
                //ff.ShowDialog();

            }
            }
            catch(Exception ex)
            {
               MessageBox.Show("معذرة هذا الجهاز غير مصرح له بتشغيل النظام يرجى التواصل مع مدير النظام" + "/n" + EncryptionClass.Encrypt("nanoahmedmohammmadnaelzadf18", getMACAdress() + "t3xzq162")+"/n" +ex.Message, "Product key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //if (ds == DialogResult.Yes)
                //{ 
            }
            ///////////////////////////////////////

            conn.Close();

            return "";
        }
        string instail = "";
        string use = "";
        public Boolean chek = false;
        public string getMACAdress()
        {try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                String sMacAddress = string.Empty;
                String mbtext = string.Empty;
                String cputext = string.Empty;
                foreach (NetworkInterface adapter in nics)
                {
                    // الحصول على رقم الماك ادرس
                    if (sMacAddress == String.Empty)// only return MAC Address from first card  
                    {
                        //IPInterfaceProperties properties = adapter.GetIPProperties(); Line is not required
                        sMacAddress = adapter.GetPhysicalAddress().ToString();
                    }
                }


                if (sMacAddress != String.Empty)
                    return sMacAddress;
                else
                {//الحصول على رقم الهاردسك
                    mbtext = string.Empty;
                    ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_DiskDrive");
                    foreach (ManagementObject mo in mbs.Get())
                    {
                        mbtext = mo["SerialNumber"].ToString();
                    }
                }
                if (mbtext != String.Empty)
                    return mbtext;
                else
                {//الحصول على رقم المعالج
                    ManagementObjectSearcher cpus = new ManagementObjectSearcher("Select * From Win32_Processor");
                    foreach (ManagementObject cpu in cpus.Get())
                    {
                        cputext = cpu["Processorid"].ToString();

                    }
                }
                if (cputext != String.Empty)
                    return cputext;
                else
                {//الحصول علي الرقم التسلسلي للماذربورد- لوحة الام-
                    ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
                    foreach (ManagementObject mo in mbs.Get())
                    {
                        mbtext = mo["SerialNumber"].ToString();
                    }
                }
                if (mbtext != String.Empty)
                    return mbtext;
                else
                    return string.Empty;
            }

            catch { return string.Empty; }
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        //public string RandomPassword()
        //{
        //    string pass = RandomPassword1();
        //    StringBuilder builder = new StringBuilder();
        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));

        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));


        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));

        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));

        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));

        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));

        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));

        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));

        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));

        //    pass = RandomPassword1();

        //    if (pass == "number")
        //        builder.Append(RandomNumber(1, 9));
        //    else if (pass == "char-Uper")
        //        builder.Append(RandomString(1, false));
        //    else
        //        builder.Append(RandomString(1, true));


        //    return builder.ToString();
        //}

        //public string RandomPassword1()
        //{

        //    string[] ff = { "number", "char-Uper", "char-lower" };
        //    StringBuilder builder = new StringBuilder();
        //    // builder.Append(RandomString(4, true));
        //    builder.Append(RandomNumber(0, 3));
        //    // builder.Append(RandomString(2, false));
        //    Thread.Sleep(500);
        //    return ff[int.Parse(builder.ToString())];
        //}

        //public int RandomNumber(int min, int max)
        //{
        //    Random random = new Random();
        //    return random.Next(min, max);
        //}
    }
}
