using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {

        }

        public override void SampleAdd_Load(object sender, EventArgs e)
        {

        }

        public override void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
