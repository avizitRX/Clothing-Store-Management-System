using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace ClothingStoreManagementSystem
{
    public partial class frmLogin : Form
    {
        private DataAccess Da { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please enter username and password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var query = "select * from Users where Username = '" + this.txtUsername.Text + "' and Password = '" + this.pswPassword.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //logged in username save in database
                    var sql = @"update Session
                                set Logged_In_User = '" + this.txtUsername.Text + "' where ID = 1;";
                    this.Da.ExecuteDMLQuery(sql);

                    if (ds.Tables[0].Rows[0][3].ToString() == "owner")
                    {
                        new FormOwner().Show();
                    }

                    else if (ds.Tables[0].Rows[0][3].ToString() == "manager")
                    {
                        new FormManager().Show();
                    }

                    else if (ds.Tables[0].Rows[0][3].ToString() == "shopkeeper")
                    {
                        new FormShopkeeper().Show();
                    }
                    this.Hide();
                }

                else
                    MessageBox.Show("Invalid User!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured!\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUsername.Text) || String.IsNullOrEmpty(this.pswPassword.Text))
                return false;
            else
                return true;
        }

        //keyboard shortcut for login form
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void pswPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void frmLoginClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
