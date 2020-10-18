using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenterManangement.Models
{
    class ClsVisit
    {
        // Method to retrive all Visit
        public DataTable getAllVisitPatient()
        {
            DBConnection DAL = new DBConnection();
            DataTable dt = new DataTable();
             dt = DAL.SelectData("getAllVisitPatient", null);

            return dt;
        }



        // Method to add information visit 

        public void AddVisit(string code , string vname, string vdate,string vtime,int paId,int apId,string vnote, int doId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[8];

            prama[0] = new SqlParameter("@viCode", SqlDbType.NVarChar, 100);
            prama[0].Value = code;

            prama[1] = new SqlParameter("@viName", SqlDbType.NVarChar, 100);
            prama[1].Value = vname;

            prama[2] = new SqlParameter("@viDate", SqlDbType.NVarChar, 50);
            prama[2].Value = vdate;

            prama[3] = new SqlParameter("@viTime", SqlDbType.NVarChar, 50);
            prama[3].Value = vtime;


            prama[4] = new SqlParameter("@paId", SqlDbType.Int);
            prama[4].Value = paId;

            

            prama[5] = new SqlParameter("@apId", SqlDbType.Int);
            prama[5].Value = apId;

            prama[6] = new SqlParameter("@viNote", SqlDbType.NVarChar ,200);
            prama[6].Value = vnote;

            prama[7] = new SqlParameter("@doId", SqlDbType.Int);
            prama[7].Value = doId;
            DB.ExecuteCommand("AddVisit", prama);
            DB.Close();
        }
       


        // search for patient visit by Date 
        public DataTable SearchVisitPatientByDate(string date)
        {
            DBConnection DAL = new DBConnection();

            DataTable dt = new DataTable();
            SqlParameter[] prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@viDate", SqlDbType.NVarChar, 100);
            prama[0].Value = date;

            dt = DAL.SelectData("SearchVisitPatientByDate", prama);
            DAL.Close();
            return dt;
        }



        // search for patient visit by patient ID
        public DataTable getVisitPatientByID (string ID)
        {
            DBConnection DAL = new DBConnection();

            DataTable dt = new DataTable();
            SqlParameter[] prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            prama[0].Value = ID;

            dt = DAL.SelectData("getVisitPatientByID", prama);
            DAL.Close();
            return dt;
        }


        // search for patient visit by patient ID
        public DataTable getVisitPatientByName(string Name)
        {
            DBConnection DAL = new DBConnection();

            DataTable dt = new DataTable();
            SqlParameter[] prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            prama[0].Value = Name;

            dt = DAL.SelectData("getVisitPatientByName", prama);
            DAL.Close();
            return dt;
        }

        // for search visit  by Visit ID
        // البحث عن زيارة بواسطة رقم الزيارة
        public DataTable SearchVisitPatient(string ID)
        {
            DBConnection DAL = new DBConnection();

            DataTable dt = new DataTable();
            SqlParameter[] prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            prama[0].Value = ID;

            dt = DAL.SelectData("SearchVisitById", prama);
            DAL.Close();
            return dt;
        }

   

        //لتعديل زيارة طبية بموجب اجراء التعديل 
        //Method to Edit Visit 
        public void UpdateVisit(int id ,string code, string vname, string vdate, string vtime, int paId, int apId, string vnote, int doId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[9];

            prama[0] = new SqlParameter("@viId", SqlDbType.Int);
            prama[0].Value = id;

            prama[1] = new SqlParameter("@viCode", SqlDbType.NVarChar, 100);
            prama[1].Value = code;

            prama[2] = new SqlParameter("@viName", SqlDbType.NVarChar, 100);
            prama[2].Value = vname;

            prama[3] = new SqlParameter("@viDate", SqlDbType.NVarChar, 50);
            prama[3].Value = vdate;

            prama[4] = new SqlParameter("@viTime", SqlDbType.NVarChar, 50);
            prama[4].Value = vtime;

            prama[5] = new SqlParameter("@paId", SqlDbType.Int);
            prama[5].Value = paId;

            prama[6] = new SqlParameter("@apId", SqlDbType.Int);
            prama[6].Value = apId;

            prama[7] = new SqlParameter("@viNote", SqlDbType.NVarChar, 200);
            prama[7].Value = vnote;

            prama[8] = new SqlParameter("@doId", SqlDbType.Int);
            prama[8].Value = doId;
            DB.ExecuteCommand("UpdateVisit", prama);
            DB.Close();
        }

        // Method to visit Patient from visti table
        //دالة لحذف زياة المريض 

       public void DeleteVisitPatient(int Id)
        {
            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter []prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@viId", SqlDbType.Int);
            prama[0].Value = Id;
            DB.ExecuteCommand("DeleteVisitPatient",prama);
            DB.Close();
            
        }


    }
}
