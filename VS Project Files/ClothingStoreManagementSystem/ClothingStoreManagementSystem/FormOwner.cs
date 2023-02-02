using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingStoreManagementSystem
{
    public partial class FormOwner : Form
    {
        private DataAccess Da { get; set; }

        public FormOwner()
        {
            InitializeComponent();

            this.Da = new DataAccess();
        }

        private void FormOwner_Load(object sender, EventArgs e)
        {
            var query = "select Logged_In_User from Session where ID = 1;";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.lblOwnerNavUsername.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }

        // Close background forms after exit
        private void FormOwner_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOwnerSettings_Click(object sender, EventArgs e)
        {
            uC_Settings1.Visible = true;
            uC_Settings1.BringToFront();
        }

        private void btnOwnerManagers_Click(object sender, EventArgs e)
        {
            uC_Managers2.Visible = true;
            uC_Managers2.BringToFront();
        }

        private void btnOwnerDashboard_Click(object sender, EventArgs e)
        {
            uC_OwnerDashboard1.Visible = true;
            uC_OwnerDashboard1.BringToFront();
        }
    }
}
