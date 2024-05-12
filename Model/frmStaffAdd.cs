using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Model
{
    public partial class frmStaffAdd : SampleAdd
    {
        public frmStaffAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void frmStaffAdd_Load(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)//insert
            {
                qry = "Insert into staff Values(@Name, @phone , @role) ";
            }
            else
            {
                qry = "Update  staff Set sName = @Name ,sPhone = @phone , sRole = @role where staffID = @id  ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);

            if (Mainclass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully ^^");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;   
                txtName.Focus();
            }
        }
    }
}
