using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace ProjectA3
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Information updated with success! :)");
        }

        private void tbl_regBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_regBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.tbl_reg' table. You can move, or remove it, as needed.
            this.tbl_regTableAdapter.Fill(this.modelDataSet.tbl_reg);

        }

        private void tbl_regDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
