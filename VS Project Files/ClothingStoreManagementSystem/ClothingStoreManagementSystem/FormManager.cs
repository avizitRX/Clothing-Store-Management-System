using ClothingStoreManagementSystem.AllUserControls;
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
    public partial class FormManager : Form
    {
        private DataAccess Da { get; set; }

        public FormManager()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            var query = "select Logged_In_User from Session where ID = 1;";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.lblManagerNavUsername.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }

        // Close background forms after exit
        private void FormManagerClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManagerSettings_Click(object sender, EventArgs e)
        {
            uC_Settings1.Visible = true;
            uC_Settings1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Products1.Visible = true;
            uC_Products1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_Shopkeeper1.Visible = true;
            uC_Shopkeeper1.BringToFront();
        }

        private void btnManagerDashboard_Click(object sender, EventArgs e)
        {
            uC_OwnerDashboard1.Visible = true;
            uC_OwnerDashboard1.BringToFront();
        }
    }
}
