using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
namespace MedicalCenterManangement
{
    class IsConstiant
    {
        public SqlConnection conn;
        DBConnection db = new DBConnection();//dbconnction is class name  
        //تستقبل رقم الصنف و المخزن و الكمية الحالية في داد جريد فيو و اجمالي الكمية في الفاتورة
        //public double get_cost_item(string item, string stor, double saling_Qty, double saled )
        //{
        //    double sum_out = 0, sum_in = 0, deff_Qty = 0, cost = 0;
        //    try
        //    {
        //        DBConnection db = new DBConnection();//dbconnction is class name
        //        conn = db.masterConn();
        //        DataTable dt_in = new DataTable(), dt_out = new DataTable();
        //        SqlDataAdapter da;
              
        //            string sql = "execute continue_type_out " + stor + "," + item;
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //        da = new SqlDataAdapter(sql, conn);
        //        da.Fill(dt_out);
        //        if (FormMain.System_Options("Free_q") == "true")
        //        {
        //            sql = " execute continue_type_in " + stor + "," + item;
        //        }
        //        else
        //            sql = " execute continue_type_in_no_free " + stor + "," + item;
        //        da = new SqlDataAdapter(sql, conn);
        //        da.Fill(dt_in);
        //        if (dt_out.Rows[0].ItemArray[0].ToString() == "")
        //            sum_out = 0;
        //        else
        //            sum_out = double.Parse(dt_out.Rows[0].ItemArray[0].ToString());
        //        sum_in = double.Parse(dt_in.Rows[0]["qty"].ToString());
        //        sum_out += saled - saling_Qty;
        //        for (int i = 0; i < dt_in.Rows.Count; i++)
        //        {
        //            if (sum_out > sum_in)
        //            {
        //                sum_in += double.Parse(dt_in.Rows[i]["qty"].ToString());
        //            }
        //            else
        //            {
        //                deff_Qty += (sum_in - sum_out);
        //                sum_out = 0;
        //                sum_in = 0;
        //                if (saling_Qty > deff_Qty)
        //                {
        //                    saling_Qty -= deff_Qty;
        //                    cost += Math.Round((deff_Qty * double.Parse(dt_in.Rows[i]["cost"].ToString())), FormMain.round_num);
        //                    deff_Qty = double.Parse(dt_in.Rows[i]["qty"].ToString());
        //                }
        //                else
        //                {
        //                    cost += (saling_Qty * double.Parse(dt_in.Rows[i]["cost"].ToString()));
        //                    return cost;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show(ee.Message);
        //    }
        //    return cost;
        //}
     
        public bool is_constrianed(string table_name, int id, string name_column)
        {
            conn = db.masterConn();
            string sql = "select Cons_Num from " + table_name + " where " + name_column + "=" + id;
            conn.Close();
            if (!(conn.State == ConnectionState.Open))
            {
                conn.Open();
                // MessageBox.Show("فشل بالاتصال بقاعدة البيانات");
                //  masterConn.Close();
            }
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand(sql, conn);
            //  SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() != "0")
                {
                    //MessageBox.Show(dr[0].ToString());
                    dr.Close();
                    conn.Close();
                    return true;
                }
            }
            dr.Close();
            conn.Close();
            return false;
        }
        public Boolean isclose()
        {
            //FormLogin ff = (FormLogin)Application.OpenForms["FormLogin"];
            if (FormLogin.stait == "close")
                return true;
            else
                return false;
        }
        
        public string ConvertDateCalendar(DateTime DateConv, string DateLangCulture)
        {
            System.Globalization.DateTimeFormatInfo DTFormat;
            DateLangCulture = DateLangCulture.ToLower();

            DTFormat = new System.Globalization.CultureInfo(DateLangCulture, false).DateTimeFormat;

            /// Set the calendar property of the date time format to the given calendar - LAITH - 11/13/2005 1:04:52 PM -

            DTFormat.Calendar = new System.Globalization.GregorianCalendar();

            /// We format the date structure to whatever we want - LAITH - 11/13/2005 1:05:39 PM -
            //  DTFormat.ShortDatePattern = "M/d/yyyy";  سابقا
            DTFormat.ShortDatePattern = "yyyy/M/d";// لماذا لا يكون التاريخ بهذه الصيغة في الدالة التي بنيتها

            string ss = DateConv.Date.ToString(DTFormat);
            ss = ss.Substring(0, ss.IndexOf(' '));
            return ss;
        }
        public int get_num_account(string name)
        {
            try
            {
                DBConnection db = new DBConnection();//dbconnction is class name
                conn = db.masterConn();
                int x = 0;
                string sql = "select Acc_Num_Last_Parent from Initial where Acc_name='" + name + "'";
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    x = int.Parse(dr[0].ToString());
                    dr.Close();
                    conn.Close();
                    return x;
                }
                dr.Close();
                conn.Close();
                return x;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return 0;

        }
        public Boolean ishavephon(int id)
        {
            //   DBConnection db = new DBConnection();//dbconnction is class name
            // public SqlConnection conn;
            conn = db.masterConn();
            try
            {
                //phonnum = "967";
                string sql;
                sql = "SELECT Phone_Num FROM  Customer where  Acc_Num=" + id + " union all SELECT Phone_Num FROM  Suppliers where  Acc_Num=" + id;

                conn.Close();
                conn.Open();

                SqlCommand cm = new SqlCommand(sql, conn);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["Phone_Num"].ToString() == "")
                    {
                        dr.Close();
                        conn.Close();
                        return false;
                    }
                    dr.Close();
                    conn.Close();
                    return true;
                }
                conn.Close();
            }
            catch
            {

                //dr.Close();
                conn.Close();
                return false;


            }


            return false;



        }
        public Boolean perrmion_other(string user_id, string process_name)
        {
            bool test_process = false;
            string sql = "select Declar from Declare_S where Pro_Num =(select Pro_Num from Processes where Pro_Name='" + process_name + "') and  User_Num ='" + int.Parse(user_id) + "'";
            conn = db.masterConn();
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand(sql, conn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                test_process = Convert.ToBoolean(dr[0].ToString());
                dr.Close();

            }
            dr.Close();
            conn.Close();

            return test_process;
        }
        public Boolean perrmion_all(string user_id, string process_type, string process_name)
        {
            bool test_process = false;
            string sql = "select " + process_type + " from Declare_M where Pro_Num =(select Pro_Num from Processes where Pro_Name='" + process_name + "') and  User_Num ='" + int.Parse(user_id) + "'";
            conn = db.masterConn();
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand(sql, conn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                test_process = Convert.ToBoolean(dr[0].ToString());
                dr.Close();

            }
            dr.Close();
            conn.Close();

            return test_process;
        }
        public void deltecon(int cons_numdelet, string table_Name, int cons_num, int id, string name_column)
        {
            try
            {
                string sql = "delete Constriant where Cons_Num='" + cons_numdelet + "'";
              
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                // update_Cons_Num("Payment_Voucher", 0, int.Parse (tbCash_Vou_num.Text) , "Pay_Vou_Num");
                update_Cons_Num(table_Name, 0, id, name_column);

                MessageBox.Show("تم الغاء ترحيل المستند بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" لم يتم الغاء ترحيل المستند بنجاح" + " \n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void update_Cons_Num(string table_Name, int cons_num, int id, string name_column)
        {
            try
            {
                string sql1 = "update " + table_Name + " set Cons_Num='" + cons_num + "' where " + name_column + "='" + id + "'";
                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public string test_account_type()
        {
            conn = db.masterConn();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "select Options from System_Options where Options_Name='نوع الجرد'";
            SqlCommand cm = new SqlCommand(sql, conn);
            SqlDataReader da = cm.ExecuteReader();
            if (da.Read())
            {
                if (da[0].ToString() == "0")
                {
                    da.Close();
                    conn.Close();
                    return "0";
                }
                else if (da[0].ToString() == "is_round")
                {
                    da.Close();
                    conn.Close();
                    return "is_round";
                }
                else if (da[0].ToString() == "is_continue")
                {
                    da.Close();
                    conn.Close();
                    return "is_continue";
                }
            }
            da.Close();
            conn.Close();
            return "0";
        }
        public string compare_date(DateTime dt1)
        {
            try
            {
                conn = db.masterConn();
                if (!(conn.State == ConnectionState.Open))
                {
                    conn.Open();
                }
                string sql = "select Options from System_Options where Options_Name='Open_Date'";
                SqlCommand cm = new SqlCommand(sql, conn);
                SqlDataReader da = cm.ExecuteReader();
                string date_program = "";
                if (da.Read())
                {
                    date_program = da[0].ToString();
                    da.Close();
                    conn.Close();
                }
                var format = new CultureInfo("en");
                DateTime dt2 = DateTime.ParseExact(date_program, "yyyy/M/d", format);
                if (dt1 < dt2)
                {
                    return "تاريخ المستند قبل تاريخ الفتره المالية";
                }

            }
            catch { return "يجب ضبط تاريخ الفترة المالية"; }
            return null;
        }
        public string coin_test_price(string coinNum, string coinValue)
        {
            try
            {

                conn = db.masterConn();
                if (!(conn.State == ConnectionState.Open))
                {
                    conn.Open();
                }
                SqlDataAdapter SDA_Items;

                string sql_coin = "SELECT Coin_Max,Coin_Min from Coin where Coin_Num=" + coinNum;
                SDA_Items = new SqlDataAdapter(sql_coin, conn);
                float max = 1, min = 1;
                var dt_coin = new DataTable();
                SDA_Items.Fill(dt_coin);
                for (int i = 0; i < dt_coin.Rows.Count; i++)
                {
                    max = float.Parse(dt_coin.Rows[0]["Coin_Max"].ToString());
                    min = float.Parse(dt_coin.Rows[0]["Coin_Min"].ToString());
                }
                if (float.Parse(coinValue) > max)
                {
                    return "سعر الصرف اكبر من الحد الاعلى";
                }
                else if (float.Parse(coinValue) < min)
                {
                    return "سعر الصرف اقل من الحد الادنى";
                }

            }
            catch (Exception e) { return e.Message; }
            return null;
        }

        public bool test_data_period(string type_of_select, string column_name, string values)
        {
            try
            {
                string[] all_table = { };
                if (type_of_select == "")
                {
                    string[] _tabl = { "Purchase_Invoice", "Purchase_Return", "Sales_Invoice", "Sales_Return", "Strore_Permition", "Move_Store" };
                    all_table = _tabl;
                }
                else
                {
                    string[] detail = { "Purchase_Invoice_Detail", "Purchase_Return_Detail", "Sales_Invoice_Detail", "Sales_Return_Detail", "Strore_Permition_Detail", "Move_Store_Detail" };
                    all_table = detail;
                }
                conn = db.masterConn();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cm;
                SqlDataReader dr;
                for (int i = 0; i < all_table.Count(); i++)
                {
                    if (all_table[i] == "Move_Store")
                    {
                        cm = new SqlCommand("select * from " + all_table[i] + " where Store_Num_From =" + values + " or Store_Num_To=" + values, conn);
                    }
                    else
                    { cm = new SqlCommand("select * from " + all_table[i] + " where  " + column_name + " =" + values, conn); }
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        conn.Close();
                        return false;
                    }
                    dr.Close();
                }

                conn.Close();
            }
            catch (Exception ee)
            { MessageBox.Show(ee.Message); }
            return true;
        }
        public bool test_data_period(string all)
        {
            try
            {
                string[] all_table = { "Constriant_Affect", "Cash_Voucher_Detail", "Payment_Voucher_Detail", "Purchase_Invoice", "Purchase_Return", "Sales_Invoice", "Sales_Return", "Strore_Permition" };
                conn = db.masterConn();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cm = new SqlCommand();
                SqlDataReader dr;
                for (int i = 0; i < all_table.Count(); i++)
                {
                    if (i == 0)
                    {
                        cm = new SqlCommand("select * from " + all_table[i] + " where Coin_Affect =" + all, conn);
                    }
                    else if (i == 1 || i == 2)
                    {
                        cm = new SqlCommand("select * from " + all_table[i] + " where Coin_Num_Detail =" + all, conn);
                    }
                    else
                    {
                        cm = new SqlCommand("select * from " + all_table[i] + " where Coin_Num =" + all, conn);
                    }
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        conn.Close();
                        return false;
                    }
                    dr.Close();
                }

                conn.Close();
            }
            catch { }
            return true;
        }
        public string customer_debit(double total, int acc_num)
        {
            double balance = 0, money = 0;
            string sqll = "";
            DataTable Dt;
            SqlDataAdapter da;
            try
            {

                conn = db.masterConn();

                if (!(conn.State == ConnectionState.Open))
                {
                    conn.Open();
                }
                sqll = "select CAST( Coin as float)*Coin_Price as money from Accounts,Coin where Accounts.Coin_Num=Coin.Coin_Num and Acc_Num=" + acc_num;
                Dt = new DataTable();
                da = new SqlDataAdapter(sqll, conn);
                da.Fill(Dt);
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    if (Convert.ToString(Dt.Rows[i]["money"]) == "" || Convert.ToString(Dt.Rows[i]["money"]) == "0")
                    {
                        return null;
                    }
                    else
                        money = double.Parse(Dt.Rows[i]["money"].ToString());
                }
                sqll = "select sum(Debit)-sum(Cridit) as sum1 from Constriant_Affect where Acc_Num=" + acc_num;
                Dt = new DataTable();
                da = new SqlDataAdapter(sqll, conn);
                da.Fill(Dt);
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    if (Dt.Rows[i]["sum1"].ToString() == "" || Dt.Rows[i]["sum1"].ToString() == "0")
                    {
                        balance = 0;
                    }
                    else
                        balance = double.Parse(Dt.Rows[i]["sum1"].ToString());
                }
                balance = balance + total;
                if (balance > money)
                {
                    return "هذا العميل تجاوز سقف الائتمان";
                }
            }
            catch (Exception ex)
            { return ex.Message; }
            return null;
        }
        public string test_update_delete(string date_compare)
        {
            string sal = "", per = "", is_show = "", message_ = "لا يمكن التعديل لانه يوجد" + "\n";
            try
            {
                string sq = "select count(Sales_Invoice_Num),'sal' as typ from Sales_Invoice where cast(Invoice_Date as date ) > '" + date_compare + "' union all select count(Per_Num),'per' as typ from Strore_Permition where cast(Per_Date as date ) > '" + date_compare + "' and Per_Type='صرف'";
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                conn = db.masterConn();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da = new SqlDataAdapter(sq, conn);
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[0].ToString() != "0" && dt.Rows[i].ItemArray[1].ToString() == "sal")
                        sal = "yes";
                    else if (dt.Rows[i].ItemArray[0].ToString() != "0" && dt.Rows[i].ItemArray[1].ToString() == "per")
                        per = "yes";
                }
                if (sal == "yes")
                { message_ += "فواتير مبيعات بعد هذه الفاتوره " + "\n"; is_show = "yes"; }
                if (per == "yes")
                {
                    message_ += "صرف مخزني بعد هذه الفاتوره" + "\n"; is_show = "yes";
                }
                if (is_show == "yes")
                { return message_; }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            return null;
        }
        public bool test_Num_is_Exist(string tab_name, string column_name, string clumn_value)
        {
            if (clumn_value != "0" && clumn_value != "")
            {


                try
                {
                    DataTable dt_num = new DataTable();
                    conn = db.masterConn();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from " + tab_name + " where " + column_name, conn);
                    da.Fill(dt_num);
                    conn.Close();
                    if (dt_num.Rows.Count > 0)
                        return false;

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            return true;
        }
        public Boolean idpaymentsales(int num)
        {
            DataTable dt_num = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from paymentsSales_Invoice where Sales_Invoice_Num=" + num, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da.Fill(dt_num);

            if (dt_num.Rows.Count > 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool is_updating(string num, string column_type, string action_type, int user)
        {
            if (action_type != "0" && action_type != "")
            {
                if (user == -1)
                {
                    MessageBox.Show("عذرا لايمكنك التعديل كونك لا تمتلك معرف وحيد", "خطأ حجب التعديلات!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                try
                {
                    conn = db.masterConn();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    if (action_type == "search")
                    {
                        DataTable dt_num = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter("select * from Is_Update where Up_Type='" + column_type + "' and Up_Num=" + num, conn);
                        da.Fill(dt_num);

                        if (dt_num.Rows.Count > 0)
                        {
                            conn.Close();
                            return true;
                        }
                        else
                        {
                            SqlCommand cm = new SqlCommand("insert into Is_Update values(N'" + num + "',N'" + column_type + "','" + user + "')", conn);
                            cm.ExecuteNonQuery();
                            conn.Close();
                            return false;
                        }
                    }
                    else
                    {
                        string sq = "";
                        if (action_type == "deleteAll")
                            sq = "delete from Is_Update where Us_Num = '" + user + "'";
                        else
                            sq = "delete from Is_Update where Up_Type='" + column_type + "' and Up_Num=" + num;
                        SqlCommand cm = new SqlCommand(sq, conn);
                        cm.ExecuteNonQuery();
                        conn.Close();
                        return false;
                    }





                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            return true;
        }
        public int getNumberConnection()
        {

            int Increment_Num = 0;
            conn = db.masterConn();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                SqlDataReader dr;
                string sql1 = "select max (Up_Num) from Is_Update";
                SqlCommand cmd = new SqlCommand(sql1, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr[0].ToString() == "")
                    {
                        Increment_Num = 1;// if database is empty , no invoices
                        dr.Close();
                        conn.Close();
                        if (!is_updating(Increment_Num.ToString(), "login", "search", Increment_Num))
                            return Increment_Num;
                        else
                            return -1;
                    }
                    Increment_Num = int.Parse(dr[0].ToString());
                    dr.Close();
                    conn.Close();
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل الحصول على رقم فريد" + " \n" + ex.Message, "خطأ حجب التعديلات!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            Increment_Num = Increment_Num + 1;
            if (!is_updating(Increment_Num.ToString(), "login", "search", Increment_Num))
                return Increment_Num;
            else
                return -1;
        }
        public Boolean IsIttemServ( int item_num)
        {
            conn = db.masterConn();
            g:
            try
            {
                string sqll = "select itemtayp from Item where Item_Num= "+Convert .ToString (item_num);
                DataTable dataset1 = new DataTable();

                if (!(conn.State == ConnectionState.Open))
                {
                    conn.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(sqll, conn);
                
                da.Fill(dataset1);
                if (dataset1.Rows.Count > 0)
                {
                    if (Convert.ToString(dataset1.Rows[0].ItemArray[0]) == "خدمي")
                        return true;
                }
            }
            catch(Exception ex)
            { try
                {
                    string sqll = "ALTER TABLE Item ADD itemtayp NVARCHAR(50) NOT NULL DEFAULT (('')) ";
                    if (!(conn.State == ConnectionState.Open))
                    {
                        conn.Open();
                    }
                    SqlCommand cm = new SqlCommand(sqll, conn);
                    cm.ExecuteNonQuery();
                    goto g;
                }
                catch(Exception ex1) { string d = ex1.Message; }
            }
            return false ;
        }
    //public  double  Get_Qty_of_Ittem( int store_num, int item_num)
    //    {
    //        DataTable Dt_qty_in, Dt_qty_out;
    //        SqlCommand cmd_pro;
    //        conn = db.masterConn();

    //        if (conn.State == ConnectionState.Closed)
    //        {
    //            conn.Open();
    //        }


    //        double availbe_qty = 0, bay = 0;
    //        string sqll = "";
    //        try
    //        {
    //            if (FormMain.System_Options("Free_q") == "true")
    //                sqll = "select sum(Qty),sum(cost) /sum(Qty) , sum(bey)/(sum(Qty- Qty_Free)) from Total_income where Item_Num=" + item_num + " and Store_Num=" + store_num + " group by Item_Num, Store_Num ";
    //            else
    //                sqll = "select sum(Qty),sum(cost) /(sum(Qty- Qty_Free)) , sum(bey)/(sum(Qty- Qty_Free)) from Total_income where Item_Num=" + item_num + " and Store_Num=" + store_num + " group by Item_Num, Store_Num ";

    //            Dt_qty_in = new DataTable();
    //            Dt_qty_out = new DataTable();

    //            if (!(conn.State == ConnectionState.Open))
    //            {
    //                conn.Open();
    //            }
    //            SqlDataAdapter da = new SqlDataAdapter(sqll, conn);
    //            da.Fill(Dt_qty_in);

    //            sqll = "select sum(Qty) from Total_abroad where Item_Num=" + item_num + " and Store_Num=" + store_num + " group by Item_Num, Store_Num ";
    //            double q = 0, qnty_out = 0;

    //            SqlDataAdapter da2 = new SqlDataAdapter(sqll, conn);
    //            if (Dt_qty_in.Rows.Count > 0)
    //            {
    //                if (Dt_qty_in.Rows[0].ItemArray[0].ToString() == "")
    //                    return 0;
    //            }
    //            else
    //                return 0;
    //            da2.Fill(Dt_qty_out);
    //            if (Dt_qty_out.Rows.Count > 0)
    //                if (Dt_qty_out.Rows[0].ItemArray[0].ToString() == "")
    //                    availbe_qty = double.Parse(Dt_qty_in.Rows[0].ItemArray[0].ToString());
    //                else
    //                    availbe_qty = double.Parse(Dt_qty_in.Rows[0].ItemArray[0].ToString()) - double.Parse(Dt_qty_out.Rows[0].ItemArray[0].ToString());
    //            else
    //                availbe_qty = double.Parse(Dt_qty_in.Rows[0].ItemArray[0].ToString());
    //            conn.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }
    //        return availbe_qty;
    //    }
    }

}
