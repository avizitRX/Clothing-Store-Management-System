using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingStoreManagementSystem.AllUserControls
{
    public partial class UC_Shopkeeper : UserControl
    {
        private DataAccess Da { get; set; }

        private int managerId;

        public UC_Shopkeeper()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Users where role='shopkeeper';")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvShopkeepers.AutoGenerateColumns = false;
            this.dgvShopkeepers.DataSource = ds.Tables[0];
            AutoIdGenerate();
        }

        private void UC_Managers_Load(object sender, EventArgs e)
        {
            this.dgvShopkeepers.ClearSelection();
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtUsername.Text) ||
                String.IsNullOrEmpty(this.pswPassword.Text))
                return false;
            
            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }

                var query = "select * from Users where Username = '" + this.txtUsername.Text + "' and role = 'shopkeeper';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"update Users
                                set Username = '" + this.txtUsername.Text + "', Password = '" + this.pswPassword.Text + "' where ID = '" + this.txtId.Text + "';";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data updated properly");
                        this.PopulateGridView();
                    }

                    else
                        MessageBox.Show("Data upgradation failed");
                }

                else
                {
                    var sql = @"insert into Users values (" + this.txtId.Text + ", '" + this.txtUsername.Text + "', '" + this.pswPassword.Text + "', 'shopkeeper', null);";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Added properly");

                        managerId++;

                        sql = @"update Session
                                set Users_ID = '" + this.managerId + "' where ID = '1';";

                        this.Da.ExecuteDMLQuery(sql);
                    }

                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void AutoIdGenerate()
        {
            var query = "select Users_ID from Session where ID = 1;";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.managerId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                this.txtId.Text = managerId.ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvShopkeepers.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvShopkeepers.CurrentRow.Cells[0].Value.ToString();
                var username = this.dgvShopkeepers.CurrentRow.Cells["Username"].Value.ToString();

                var sql = "delete from Users where id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(username.ToUpper() + " has been removed successfully.");

                    managerId--;

                    sql = @"update Session
                                set Users_ID = '" + this.managerId + "' where ID = '1';";

                    this.Da.ExecuteDMLQuery(sql);
                }

                else
                    MessageBox.Show("Data remove failed.");

                this.PopulateGridView();

            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGridView();
        }

        private void ClearAll()
        {
            this.txtUsername.Clear();
            this.pswPassword.Clear();
        }

        private void dgvShopkeepers_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvShopkeepers.CurrentRow.Cells["ID"].Value.ToString();
            this.txtUsername.Text = this.dgvShopkeepers.CurrentRow.Cells["Username"].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Users where Role = 'shopkeeper' and Username like '" + this.txtSearch.Text + "%';";

            PopulateGridView(sql);
        }
    }
}
