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
    class ClsServiecs
    {

       // Method to retrive all Serviecs
        public DataTable getAllServiecs()
        {
            DBConnection DAL = new DBConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("getAllServiecs", null);

            return dt;
        }



        // Method to add information Serivecs 

        public void AddServiecs(string code, string name, string type,  decimal price,string  note, int ACC_Num)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[6];

            prama[0] = new SqlParameter("@seCode", SqlDbType.NVarChar, 100);
            prama[0].Value = code;

            prama[1] = new SqlParameter("@seName", SqlDbType.NVarChar, 100);
            prama[1].Value = name;

            prama[2] = new SqlParameter("@seType", SqlDbType.NVarChar, 100);
            prama[2].Value = type;

            prama[3] = new SqlParameter("@sePrice", SqlDbType.Decimal);
            prama[3].Value = price;


            prama[4] = new SqlParameter("@seNote", SqlDbType.NVarChar,200);
            prama[4].Value = note;

            
            prama[5] = new SqlParameter("@ACC_Num", SqlDbType.Int);
            prama[5].Value =ACC_Num;
            DB.ExecuteCommand("AddServiecs", prama);
            DB.Close();
        }


        // Method  to Update Servieces

        public void UpdateServiecs(int Id,string code, string name, string type, decimal price, string note, int ACC_Num)
        {

            DBConnection DB = new DBConnection();
            DB.Open();
            SqlParameter[] prama = new SqlParameter[7];

            prama[0] = new SqlParameter("@seId", SqlDbType.Int);
            prama[0].Value = Id;

            prama[1] = new SqlParameter("@seCode", SqlDbType.NVarChar, 100);
            prama[1].Value = code;

            prama[2] = new SqlParameter("@seName", SqlDbType.NVarChar, 100);
            prama[2].Value = name;

            prama[3] = new SqlParameter("@seType", SqlDbType.NVarChar, 100);
            prama[3].Value = type;

            prama[4] = new SqlParameter("@sePrice", SqlDbType.Decimal);
            prama[4].Value = price;


            prama[5] = new SqlParameter("@seNote", SqlDbType.NVarChar, 200);
            prama[5].Value = note;


            prama[6] = new SqlParameter("@ACC_Num", SqlDbType.Int);
            prama[6].Value = ACC_Num;
            DB.ExecuteCommand("UpdateServiecs", prama);
            DB.Close();
        }


    }
}
