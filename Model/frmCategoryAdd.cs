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
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }
      
        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)//insert
            {
                qry = "Insert into category Values(@Name) ";
            }
            else
            {
                qry = "Update  category Set catName = @Name where catID = @id  ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("id", id);
            ht.Add("@Name",txtName.Text);

           if ( Mainclass.SQL(qry, ht) > 0 )
            {
                MessageBox.Show("Saved successfully ^^");
                id = 0;
                txtName.Focus();
            }
        }


    }
}
