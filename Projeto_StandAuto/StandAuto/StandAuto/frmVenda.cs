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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void vendaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);

        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standAutoDataSet.VendaSet' table. You can move, or remove it, as needed.
            this.vendaSetTableAdapter.Fill(this.standAutoDataSet.VendaSet);
            // TODO: This line of code loads data into the 'standAutoDataSet.ClienteSet' table. You can move, or remove it, as needed.
            this.clienteSetTableAdapter1.Fill(this.standAutoDataSet.ClienteSet);


        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            frmCliente cli = new frmCliente();
            cli.ShowDialog();
        }
    }
}
