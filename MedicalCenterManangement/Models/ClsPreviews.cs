using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenterManangement.Models
{
    class ClsPreviews
    {
        // Method to retrive patient preview  by visit Id
        public DataTable getPreviewPatientByVistID(int Id)
        {
            DBConnection DAL = new DBConnection();
            DataTable dt = new DataTable();
            SqlParameter[] prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@ID", SqlDbType.Int);
            prama[0].Value = Id;
            dt = DAL.SelectData("getPreviewPatientByVistID", prama);
            DAL.Close();

            return dt;
        }



        // Method to add information Preview Patient 

        public void AddPreview(string code, string name, string date, string time,  string note, int viId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[6];

            prama[0] = new SqlParameter("@prCode", SqlDbType.NVarChar, 100);
            prama[0].Value = code;

            prama[1] = new SqlParameter("@prName", SqlDbType.NVarChar, 100);
            prama[1].Value = name;

            prama[2] = new SqlParameter("@prDate", SqlDbType.NVarChar, 50);
            prama[2].Value = date;

            prama[3] = new SqlParameter("@prTime", SqlDbType.NVarChar, 50);
            prama[3].Value = time;

            prama[4] = new SqlParameter("@prNote", SqlDbType.NVarChar, 200);
            prama[4].Value = note;

            prama[5] = new SqlParameter("@viId", SqlDbType.Int);
            prama[5].Value = viId;
            DB.ExecuteCommand("AddPreview", prama);
            DB.Close();
        }

        // Method to update  information Preview 
        public void UpdatePreview(int Id,string code, string name, string date, string time, string note, int viId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[7];

            prama[0] = new SqlParameter("@prId", SqlDbType.NVarChar, 100);
            prama[0].Value = Id;

            prama[1] = new SqlParameter("@prCode", SqlDbType.NVarChar, 100);
            prama[1].Value = code;

            prama[2] = new SqlParameter("@prName", SqlDbType.NVarChar, 100);
            prama[2].Value = name;

            prama[3] = new SqlParameter("@prDate", SqlDbType.NVarChar, 50);
            prama[3].Value = date;

            prama[4] = new SqlParameter("@prTime", SqlDbType.NVarChar, 50);
            prama[4].Value = time;

            prama[5] = new SqlParameter("@prNote", SqlDbType.NVarChar, 200);
            prama[5].Value = note;

            prama[6] = new SqlParameter("@viId", SqlDbType.Int);
            prama[6].Value = viId;
            DB.ExecuteCommand("UpdatePreview", prama);
            DB.Close();
        }


        // Method to Delete Preview by change state isDeleted

        public void DeletePreviewByUpdate(int Id ,int t)
        {
            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[2];

            prama[0] = new SqlParameter("@prId", SqlDbType.Int);
            prama[0].Value = Id;

            prama[1] = new SqlParameter("@isDeleted", SqlDbType.Int);
            prama[1].Value = t;
            DB.ExecuteCommand("DeletePreviewByUpdate", prama);
            DB.Close();

        }

    }
}
