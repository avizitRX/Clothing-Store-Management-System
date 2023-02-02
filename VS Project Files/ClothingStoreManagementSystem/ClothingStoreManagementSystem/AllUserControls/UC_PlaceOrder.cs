using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClothingStoreManagementSystem.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        private DataAccess Da { get; set; }

        protected int n, total = 0;
        private int billNo;

        public UC_PlaceOrder()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Products;")
        {
            
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            this.dgvCart.ClearSelection();

            var sql = "select * from Products;";
            showItemList(sql);

            ClearAll();

            var query = "select Bill_No from Session where ID = 1;";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.billNo = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Products where Product_Type = '" + this.CmbProductType.Text + "' and Product_Name like '" + this.txtSearch.Text + "%';";
            showItemList(sql);
        }

        private void showItemList(String sql)
        {
            listboxPlaceOrderSearch.Items.Clear();

            var ds = this.Da.ExecuteQuery(sql);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listboxPlaceOrderSearch.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }
        }

        private void listboxPlaceOrderSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();

            String text = listboxPlaceOrderSearch.GetItemText(listboxPlaceOrderSearch.SelectedItem);
            txtName.Text = text;

            var sql = "select Price from Products where Product_Name = '" + text + "'";
            var ds = this.Da.ExecuteQuery(sql);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void ClearAll()
        {
            this.txtName.Clear();
            this.txtPrice.Clear();
            this.txtTotalPrice.Clear();
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text != "0" && txtTotalPrice.Text != "")
            {
                n = dgvCart.Rows.Add();
                this.dgvCart.Rows[n].Cells[0].Value = this.txtName.Text;
                this.dgvCart.Rows[n].Cells[1].Value = this.txtPrice.Text;
                this.dgvCart.Rows[n].Cells[2].Value = this.updownQuantity.Text;
                this.dgvCart.Rows[n].Cells[3].Value = this.txtTotalPrice.Text;

                total += int.Parse(txtTotalPrice.Text);
                lblTotalAmount.Text = "Tk. " + total;
            }

            else
                MessageBox.Show("Minimum quantity needs to be 1.");
        }

        int amount;

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dgvCart.Rows[e.RowIndex].Cells[3].Value.ToString());
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCart.Rows.RemoveAt(this.dgvCart.SelectedRows[0].Index);
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }

            total -= amount;
            lblTotalAmount.Text = "Tk. " + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var sql = @"insert into Sales values ('" + this.billNo + "', '" + this.total + "');";
            int count = this.Da.ExecuteDMLQuery(sql);

            if (count == 1)
            {
                billNo++;

                sql = @"update Session
                                set Bill_No = '" + this.billNo + "' where ID = '1';";

                this.Da.ExecuteDMLQuery(sql);
            }

            else
                MessageBox.Show("Couldn't make bill.");

            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Customer Bill";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + lblTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvCart);

            total = 0;
            dgvCart.Rows.Clear();
            lblTotalAmount.Text = "Tk. " + total;
        }

        private void updownQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please select an item first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {
                    Int64 quan = Int64.Parse(updownQuantity.Value.ToString());
                    Int64 price = Int64.Parse(txtPrice.Text.ToString());
                    Int64 total = quan * price;
                    txtTotalPrice.Text = total.ToString();
                }

                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured!\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }    
}
