using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA3
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void tbl_regBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_regBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.tbl_reg' table. You can move, or remove it, as needed.
            this.tbl_regTableAdapter.Fill(this.modelDataSet.tbl_reg);

        }
    }
}
