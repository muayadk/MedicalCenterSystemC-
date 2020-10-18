using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenterManangement.Models
{
    class ClsDiagnoses
    {

        public DataTable getDiagnosePatientByVistID(int ID)
        {
            DBConnection DAL = new DBConnection();

            DataTable dt = new DataTable();
            SqlParameter[] prama = new SqlParameter[1];
            prama[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            prama[0].Value = ID;

            dt = DAL.SelectData("getDiagnosePatientByVistID", prama);
            DAL.Close();
            return dt;
        }

        // Method to add Diagnose 
        public void AddDiagnoses(string code, string name, string date, string time,  int viId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[5];

            prama[0] = new SqlParameter("@diCode", SqlDbType.NVarChar, 100);
            prama[0].Value = code;

            prama[1] = new SqlParameter("@diName", SqlDbType.NVarChar, 100);
            prama[1].Value = name;

            prama[2] = new SqlParameter("@diDate", SqlDbType.NVarChar, 50);
            prama[2].Value = date;

            prama[3] = new SqlParameter("@diTime", SqlDbType.NVarChar, 50);
            prama[3].Value = time;

          

            prama[4] = new SqlParameter("@viId", SqlDbType.Int);
            prama[4].Value = viId;
            DB.ExecuteCommand("AddDiagnoses", prama);
            DB.Close();
        }


        // Method to update Diagnose Patient 
        public void UpdateDiagnoses(int Id,string code, string name, string date, string time, int viId)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[6];

            prama[0] = new SqlParameter("@diId", SqlDbType.NVarChar, 100);
            prama[0].Value = Id;

            prama[1] = new SqlParameter("@diCode", SqlDbType.NVarChar, 100);
            prama[1].Value = code;

            prama[2] = new SqlParameter("@diName", SqlDbType.NVarChar, 100);
            prama[2].Value = name;

            prama[3] = new SqlParameter("@diDate", SqlDbType.NVarChar, 50);
            prama[3].Value = date;

            prama[4] = new SqlParameter("@diTime", SqlDbType.NVarChar, 50);
            prama[4].Value = time;

            prama[5] = new SqlParameter("@viId", SqlDbType.Int);
            prama[5].Value = viId;
            DB.ExecuteCommand("UpdateDiagnoses", prama);
            DB.Close();
        }


        // Method to Delete Diagnose by change state isDeleted

        public void DeleteDiagnoseByUpdate(int Id, int t)
        {
            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[2];

            prama[0] = new SqlParameter("@diId", SqlDbType.Int);
            prama[0].Value = Id;

            prama[1] = new SqlParameter("@isDeleted", SqlDbType.Int);
            prama[1].Value = t;
            DB.ExecuteCommand("DeleteDiagnoseByUpdate", prama);
            DB.Close();
        }


        } // end Classs
} // end  NameSpasec
