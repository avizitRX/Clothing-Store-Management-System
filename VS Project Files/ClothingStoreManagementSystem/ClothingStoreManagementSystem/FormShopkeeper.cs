using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingStoreManagementSystem
{
    public partial class FormShopkeeper : Form
    {
        private DataAccess Da { get; set; }

        public FormShopkeeper()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        // Close background forms after exit
        private void FormShopkeeperClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnManagerSettings_Click(object sender, EventArgs e)
        {
            uC_Settings1.Visible = true;
            uC_Settings1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }

        private void FormShopkeeper_Load(object sender, EventArgs e)
        {
            var query = "select Logged_In_User from Session where ID = 1;";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.lblShopkeeperNavUsername.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }
    }
}
