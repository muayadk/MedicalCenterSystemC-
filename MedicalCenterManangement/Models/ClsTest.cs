using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenterManangement.Models
{
    class ClsTest
    {


    

        // Method to retrive  Resut Test for patient
        public DataTable getTestResultPatient(string  Id)
        {
            DBConnection DAL = new DBConnection();
          
            SqlParameter[] prama = new SqlParameter[1];

            prama[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 100);
            prama[0].Value = Id;
            DataTable dt = new DataTable();


            dt = DAL.SelectData("getTestResultPatient", prama);

            return dt;
        }

    }
}
