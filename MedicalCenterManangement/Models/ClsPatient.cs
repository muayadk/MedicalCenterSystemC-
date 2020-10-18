using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCenterManangement.Models
{
    class ClsPatient
    {
       
        // دالة لاسترجاع كل بيانات المرضى Method to Retreive all information for Patient
        public DataTable getAllPatient()
        {
            DBConnection  DAL = new DBConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("getAllPatient", null);

            return dt;
        }


     

        // دالة اضافة المرضى Method for Add Patient
        public void AddPatient(string paCode, string name1, string name2,
            string Sex, string Brithday,int Age, int phone1,int phone2,byte[] paImg,
            string paAddress, string paCountry, string paCity,string paBloodType,string paState,string paType, int ACC_Num)
        {
            //  DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //  DAL.Open();

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[16];

            prama[0] = new SqlParameter("@paCode", SqlDbType.NVarChar, 100);
            prama[0].Value = paCode;

            prama[1] = new SqlParameter("@paFname", SqlDbType.NVarChar, 100);
            prama[1].Value = name1;

            prama[2] = new SqlParameter("@paLname", SqlDbType.NVarChar, 100);
            prama[2].Value = name2;

            prama[3] = new SqlParameter("@paSex", SqlDbType.NVarChar,50);
            prama[3].Value = Sex;


            prama[4] = new SqlParameter("@paBrithday", SqlDbType.NVarChar,50);
            prama[4].Value = Brithday;

            prama[5] = new SqlParameter("@paAge", SqlDbType.Int);
            prama[5].Value = Age;

            prama[6] = new SqlParameter("@paMobile1", SqlDbType.Int);
            prama[6].Value = phone1;

            prama[7] = new SqlParameter("@paMobile2", SqlDbType.Int);
            prama[7].Value = phone2;

            prama[8] = new SqlParameter("@paImg", SqlDbType.Image);
            prama[8].Value = paImg;

            prama[9] = new SqlParameter("@paAddress", SqlDbType.NVarChar, 100);
            prama[9].Value = paAddress;

            prama[10] = new SqlParameter("@paCountry", SqlDbType.NVarChar, 100);
            prama[10].Value = paCountry;

            prama[11] = new SqlParameter("@paCity", SqlDbType.NVarChar, 100);
            prama[11].Value = paCity;

            prama[12] = new SqlParameter("@paBloodType", SqlDbType.NVarChar, 50);
            prama[12].Value = paBloodType;

            prama[13] = new SqlParameter("@paState", SqlDbType.NVarChar, 100);
            prama[13].Value = paState;

            prama[14] = new SqlParameter("@paType", SqlDbType.NVarChar, 100);
            prama[14].Value = paType;

            prama[15] = new SqlParameter("@ACC_Num", SqlDbType.Int);
            prama[15].Value = ACC_Num;
            

            DB.ExecuteCommand("AddPatient", prama);
            DB.Close();
        }



        //Method to  update patient table 
        //دالة لتعديل ببانات المريض 

         public void updatePatient(int id, string code, string name1, string name2,
            string Sex, string Brday, int Age, int phone1, int phone2, byte[] paImg,
            string paAddress, string paCountry, string paCity, string paBloodType, 
            string paState, string paType, decimal ACC_Num)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[17];

            prama[0] = new SqlParameter("@paId", SqlDbType.NVarChar, 100);
            prama[0].Value = id;
            prama[1] = new SqlParameter("@paCode", SqlDbType.NVarChar, 100);
            prama[1].Value = code;

            prama[2] = new SqlParameter("@paFname", SqlDbType.NVarChar, 100);
            prama[2].Value = name1;

            prama[3] = new SqlParameter("@paLname", SqlDbType.NVarChar, 100);
            prama[3].Value = name2;

            prama[4] = new SqlParameter("@paSex", SqlDbType.NVarChar, 50);
            prama[4].Value = Sex;


            prama[5] = new SqlParameter("@paBrithday", SqlDbType.NVarChar, 50);
            prama[5].Value = Brday;

            prama[6] = new SqlParameter("@paAge", SqlDbType.Int);
            prama[6].Value = Age;

            prama[7] = new SqlParameter("@paMobile1", SqlDbType.Int);
            prama[7].Value = phone1;

            prama[8] = new SqlParameter("@paMobile2", SqlDbType.Int);
            prama[8].Value = phone2;

            prama[9] = new SqlParameter("@paImg", SqlDbType.Image);
            prama[9].Value = paImg;

            prama[10] = new SqlParameter("@paAddress", SqlDbType.NVarChar, 100);
            prama[10].Value = paAddress;

            prama[11] = new SqlParameter("@paCountry", SqlDbType.NVarChar, 100);
            prama[11].Value = paCountry;

            prama[12] = new SqlParameter("@paCity", SqlDbType.NVarChar, 100);
            prama[12].Value = paCity;

            prama[13] = new SqlParameter("@paBloodType", SqlDbType.NVarChar, 50);
            prama[13].Value = paBloodType;

            prama[14] = new SqlParameter("@paState", SqlDbType.NVarChar, 100);
            prama[14].Value = paState;

            prama[15] = new SqlParameter("@paType", SqlDbType.NVarChar, 100);
            prama[15].Value = paType;

            prama[16] = new SqlParameter("@ACC_Num", SqlDbType.Decimal, 18);
            prama[16].Value = ACC_Num;


            DB.ExecuteCommand("updatePatient", prama);
            DB.Close();

        }


        // Method for Delete Patient 
        //دالة لحذف مريض

        public void DeletePatient(int ID)
        {
            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[1];

            prama[0] = new SqlParameter("@paId", SqlDbType.Int);
            prama[0].Value = ID;

            DB.ExecuteCommand("DeletePatient", prama);
            DB.Close();
        }


        //   دالة للاكمال التلقائي لاسم المريض 
        public void autoCompletPatientName(TextBox text)
        {
          
            try
            {
                DBConnection DB = new DBConnection();
                DB.Open();

                SqlDataReader dr;
              
                SqlCommand sm = new SqlCommand("select paFname from patientsTab", DB.sqlconnection);
                
                dr = sm.ExecuteReader();
              
                while (dr.Read())
                {
                    
                    text.AutoCompleteCustomSource.Add(dr["paFname"].ToString());
                   

                }
                dr.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception :", ex.Message);
            }
        }

        // دالة للاكمال التلقائي للقلب المريض
       public void autoCompletPatientLname(TextBox text)
        {

            try
            {
                DBConnection DB = new DBConnection();
                DB.Open();

                SqlDataReader dr;

                SqlCommand sm = new SqlCommand("select paLname from patientsTab", DB.sqlconnection);

                dr = sm.ExecuteReader();

                while (dr.Read())
                {

                    text.AutoCompleteCustomSource.Add(dr["paLname"].ToString());
                   


                }
                dr.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception :", ex.Message);
            }
        }

    }
}
