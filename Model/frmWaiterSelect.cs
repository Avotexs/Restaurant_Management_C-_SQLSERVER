using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Model
{
    public partial class frmWaiterSelect : Form
    {
        public frmWaiterSelect()
        {
            InitializeComponent();
        }
        public string waiterName;
        private void frmWaiterSelect_Load(object sender, EventArgs e)
        {

            string qry = "Select * from staff where sRole Like 'Waiter'";
            SqlCommand cmd = new SqlCommand(qry, Mainclass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.Text = row["sName"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.FillColor = Color.FromArgb(241, 85, 126);
                b.HoverState.FillColor = Color.FromArgb(50, 55, 89);

                //event for click
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);



            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            waiterName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }
    }
}
