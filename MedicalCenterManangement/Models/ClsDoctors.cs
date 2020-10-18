using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenterManangement.Models
{
    class ClsDoctors
    {

        public DataTable getNameDoctors()
        {
            DBConnection DAL = new DBConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("getNameDoctors", null);

            return dt;
        }
    }
}
