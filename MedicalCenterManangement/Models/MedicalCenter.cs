using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCenterManangement.DataModeView;
using System.Windows.Forms;
using System.Data.Entity;

namespace MedicalCenterManangement.Models
{
   public class MedicalCenter
    {
        
       MedicalCenterDbEntities db = new MedicalCenterDbEntities();


        public void Add(hospitalCenterTab hosp)
        {
            try
            {
                db.hospitalCenterTab.Add(hosp);

                db.SaveChanges();
                MessageBox.Show("تم اضاقة سجل مريض بنجاح!!", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Exception" + ex, ex.Data.ToString()); }



        }

        public void Update(hospitalCenterTab hosp)
        {

            try
            {
                /*using (var db = new MedicalCenterDbEntities())
                {
                    var result = db.hospitalCenterTab.SingleOrDefault(b => b.hoId == hosp.hoId);
                    // var result = db.hospitalCenterTab.Find(hosp.hoId);
                    if (result == null)
                    {
                        db.hospitalCenterTab.Add(hosp);
                    }
                    else
                    {
                       // db.Entry(hosp).State=EntityState.Detached;
                       // db.hospitalCenterTab.Attach(hosp);
                       //  db.Entry(hosp).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                   
                }*/

                db.SaveChanges();
            }

            catch (Exception ex)  {MessageBox.Show("ex", ex.Data.ToString());  }
        }
  }
}
