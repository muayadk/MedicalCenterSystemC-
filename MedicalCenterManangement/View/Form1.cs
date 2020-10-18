using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCenterManangement
{
    public partial class Form1 : Form
    {
        Models.ClsPatient patient = new Models.ClsPatient();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient.AddPatient(code.Text,fname.Text,lname.Text,sex.Text,Convert.ToDateTime(brithday.Text),
                Convert.ToInt32( age.Text),Convert.ToInt32( mobile1.Text), Convert.ToInt32(mobile2.Text),img.ToString(),
                address.Text,country.Text,city.Text,boold.Text,state.Text,type.Text,1);
            MessageBox.Show("تم اضاقة سجل مريض بنجاح!!", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
