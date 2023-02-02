using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClothingStoreManagementSystem.AllUserControls
{
    public partial class UC_Products : UserControl
    {
        private DataAccess Da { get; set; }

        private int productId;

        public UC_Products()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Products;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.DataSource = ds.Tables[0];

            AutoIdGenerate();
        }

        private void UC_Products_Load(object sender, EventArgs e)
        {
            this.dgvProducts.ClearSelection();
            this.PopulateGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtProductname.Clear();
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
            this.AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var query = "select Products_ID from Session where ID = 1;";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.productId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            }

            this.txtID.Text = productId.ToString();
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtProductname.Text) ||
                String.IsNullOrEmpty(this.CmbProductType.Text) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(txtQuantity.Text))
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

                var query = "select * from Products where Product_Name = '" + this.txtProductname.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"update Products
                                set Product_Name = '" + this.txtProductname.Text + "', Product_Type = '" + this.CmbProductType.Text + "', Price = '" + this.txtPrice.Text + "', Quantity = '" + this.txtQuantity.Text + "' where ID = '" + this.txtID.Text + "';";

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
                    var sql = @"insert into Products values (" + this.txtID.Text + ", '" + this.txtProductname.Text + "', '" + this.CmbProductType.Text + "', '" + this.txtPrice.Text + "', '" + this.txtQuantity.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Added properly");

                        productId++;

                        sql = @"update Session
                                set Products_ID = '" + this.productId + "' where ID = '1';";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProducts.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvProducts.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvProducts.CurrentRow.Cells["Product_Name"].Value.ToString();

                var sql = "delete from Products where id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(name.ToUpper() + " has been removed successfully.");

                    productId--;

                    sql = @"update Session
                                set Products_ID = '" + this.productId + "' where ID = '1';";

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

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtID.Text = this.dgvProducts.CurrentRow.Cells["ID"].Value.ToString();
                this.txtProductname.Text = this.dgvProducts.CurrentRow.Cells["Product_Name"].Value.ToString();
                this.CmbProductType.Text = this.dgvProducts.CurrentRow.Cells["Product_Type"].Value.ToString();
                this.txtPrice.Text = this.dgvProducts.CurrentRow.Cells["Price"].Value.ToString();
                this.txtQuantity.Text = this.dgvProducts.CurrentRow.Cells["Quantity"].Value.ToString();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Products where Product_Name like '" + this.txtSearch.Text + "%';";

            PopulateGridView(sql);
        }
    }
}
