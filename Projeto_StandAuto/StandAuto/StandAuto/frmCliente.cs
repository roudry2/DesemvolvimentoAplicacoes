using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAuto
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void clienteSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standAutoDataSet.ClienteSet' table. You can move, or remove it, as needed.
            this.clienteSetTableAdapter.Fill(this.standAutoDataSet.ClienteSet);

        }

        private void clienteSetBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void clienteSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
