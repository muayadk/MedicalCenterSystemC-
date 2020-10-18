using DevExpress.XtraEditors;
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
    class ClsRecipe
    {
      

        
        // Method to retrive Recipe prescription     by visit Id
        public DataTable getRecipeByVisitID(int Id)
        {
            DBConnection DAL = new DBConnection();
            DataTable dt = new DataTable();
            SqlParameter[] prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@Id", SqlDbType.Int);
            prama[0].Value = Id;
            dt = DAL.SelectData("getRecipeByVisitID", prama);
            DAL.Close();

            return dt;
        }


        // Method to retrive Recipe prescription     by Recipe Id
        public DataTable getRecipeByRecipeId(int Id)
        {
            DBConnection DAL = new DBConnection();
            DataTable dt = new DataTable();
            SqlParameter[] prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@Id", SqlDbType.Int);
            prama[0].Value = Id;
            dt = DAL.SelectData("getRecipeByRecipeId", prama);
            DAL.Close();

            return dt;
        }

        // Method to add information Recipe Patient 

        public void AddRecipe(string code,  string date, string time, string note, int viId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[5];

            prama[0] = new SqlParameter("@reCode", SqlDbType.NVarChar, 100);
            prama[0].Value = code;


            prama[1] = new SqlParameter("@reDate", SqlDbType.NVarChar, 50);
            prama[1].Value = date;

            prama[2] = new SqlParameter("@reTime", SqlDbType.NVarChar, 50);
            prama[2].Value = time;

            prama[3] = new SqlParameter("@reNote", SqlDbType.NVarChar, 200);
            prama[3].Value = note;

            prama[4] = new SqlParameter("@viId", SqlDbType.Int);
            prama[4].Value = viId;
            DB.ExecuteCommand("AddRecipe", prama);
            DB.Close();
        }


        // Method to update information Recipe Patient 

        public void UpdateRecipe(int Id ,string code, string date, string time, string note, int viId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[6];

            prama[0] = new SqlParameter("@reId", SqlDbType.Int);
            prama[0].Value = Id;

            prama[1] = new SqlParameter("@reCode", SqlDbType.NVarChar, 100);
            prama[1].Value = code;


            prama[2] = new SqlParameter("@reDate", SqlDbType.NVarChar, 50);
            prama[2].Value = date;

            prama[3] = new SqlParameter("@reTime", SqlDbType.NVarChar, 50);
            prama[3].Value = time;

            prama[4] = new SqlParameter("@reNote", SqlDbType.NVarChar, 200);
            prama[4].Value = note;

            prama[5] = new SqlParameter("@viId", SqlDbType.Int);
            prama[5].Value = viId;
            DB.ExecuteCommand("UpdateRecipe", prama);
            DB.Close();
        }


        // Method to add information Prescription for Recipe patient 

        public void AddPrescription(string code,string name,string Qyt,string timeuse,string size,string priod,int reId,int drId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[8];

            prama[0] = new SqlParameter("@presCode", SqlDbType.NVarChar, 100);
            prama[0].Value = code;


            prama[1] = new SqlParameter("@presName", SqlDbType.NVarChar, 100);
            prama[1].Value = name;

            prama[2] = new SqlParameter("@presQyt", SqlDbType.NVarChar, 100);
            prama[2].Value = Qyt;

            prama[3] = new SqlParameter("@presTimeUse", SqlDbType.NVarChar, 100);
            prama[3].Value = timeuse;

            prama[4] = new SqlParameter("@presSize", SqlDbType.NVarChar,100);
            prama[4].Value = size;

            prama[5] = new SqlParameter("@presPriod", SqlDbType.NVarChar, 100);
            prama[5].Value = priod;

            prama[6] = new SqlParameter("@reId", SqlDbType.Int);
            prama[6].Value = reId;

            prama[7] = new SqlParameter("@drId", SqlDbType.Int);
            prama[7].Value = drId;

            DB.ExecuteCommand("AddPrescription", prama);
            DB.Close();
        }



        // Method to update information Prescription for Recipe patient 

        public void UpdatePrescription(int Id ,string code, string name, string Qyt, string timeuse, string size, string priod, int reId, int drId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[9];

            prama[0] = new SqlParameter("@presId", SqlDbType.Int);
            prama[0].Value = Id;

            prama[1] = new SqlParameter("@presCode", SqlDbType.NVarChar, 100);
            prama[1].Value = code;

            prama[2] = new SqlParameter("@presName", SqlDbType.NVarChar, 100);
            prama[2].Value = name;

            prama[3] = new SqlParameter("@presQyt", SqlDbType.NVarChar, 100);
            prama[3].Value = Qyt;

            prama[4] = new SqlParameter("@presTimeUse", SqlDbType.NVarChar, 100);
            prama[4].Value = timeuse;

            prama[5] = new SqlParameter("@presSize", SqlDbType.NVarChar, 100);
            prama[5].Value = size;

            prama[6] = new SqlParameter("@presPriod", SqlDbType.NVarChar, 100);
            prama[6].Value = priod;

            prama[7] = new SqlParameter("@reId", SqlDbType.Int);
            prama[7].Value = reId;

            prama[8] = new SqlParameter("@drId", SqlDbType.Int);
            prama[8].Value = drId;

            DB.ExecuteCommand("UpdatePrescription", prama);
            DB.Close();
        }


        // Method to get Max Recipe ID 
        public DataTable getMaxRecipeID()
        {
            DBConnection DAL = new DBConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("getMaxRecipeID", null);

            return dt;
        }


        //Method to Deleted Prescription Recipe
        public void DeletePrescription(int ID)
        {
            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[1];

            prama[0] = new SqlParameter("@presId", SqlDbType.Int);
            prama[0].Value = ID;

            DB.ExecuteCommand("DeletePrescription",prama);
            DB.Close();
        }

        // Method to Delete Recipe by change state isDeleted

        public void DeleteRecipeByUpdate(int Id, int t)
        {
            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[2];

            prama[0] = new SqlParameter("@reId", SqlDbType.Int);
            prama[0].Value = Id;

            prama[1] = new SqlParameter("@isDeleted", SqlDbType.Int);
            prama[1].Value = t;
            DB.ExecuteCommand("DeleteRecipeByUpdate", prama);
            DB.Close();

        }






    }   // end class
}    // end namespace

