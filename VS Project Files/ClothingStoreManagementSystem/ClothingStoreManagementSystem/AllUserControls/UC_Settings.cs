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

namespace ClothingStoreManagementSystem.AllUserControls
{
    public partial class UC_Settings : UserControl
    {
        private DataAccess Da { get; set; }

        private string loggedInUsername;

        public UC_Settings()
        {
            InitializeComponent();

            this.Da = new DataAccess();
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            var query = "select Logged_In_User from Session where ID = 1;";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.loggedInUsername = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.pswOldPassword.Text) || String.IsNullOrEmpty(this.pswNewPassword1.Text) ||
                String.IsNullOrEmpty(this.pswNewPassword2.Text))
                return false;
            else
                return true;
        }

        private bool IsOldPasswordCorrect()
        {
            var query = "select * from Users where Username = '" + this.loggedInUsername + "' and Password = '" + this.pswOldPassword.Text + "';";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }

            else
                return false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }

                if (!IsOldPasswordCorrect())
                {
                    MessageBox.Show("Your Old Password is not correct.");
                    return;
                }

                if (IsOldPasswordCorrect())
                {
                    if (pswNewPassword1.Text == pswNewPassword2.Text)
                    {
                        var sql = @"update Users
                            set Password = '" + this.pswNewPassword2.Text + "' where Username = '" + this.loggedInUsername + "';";

                        int count = this.Da.ExecuteDMLQuery(sql);

                        if (count == 1)
                            MessageBox.Show("Password changed successfully!");
                        else
                            MessageBox.Show("Error! Couldn't change password! Try again!");
                    }

                    else
                        MessageBox.Show("New Passwords didn't match. Try again!");
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }

            pswOldPassword.Text = this.loggedInUsername;
        }
    }
}
