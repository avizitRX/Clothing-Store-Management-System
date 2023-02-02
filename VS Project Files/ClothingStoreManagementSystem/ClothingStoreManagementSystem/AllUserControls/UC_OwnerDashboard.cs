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
    public partial class UC_OwnerDashboard : UserControl
    {
        private DataAccess Da { get; set; }

        public UC_OwnerDashboard()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select top 20 * from Sales;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSales.AutoGenerateColumns = false;
            this.dgvSales.DataSource = ds.Tables[0];
        }
    }
}
