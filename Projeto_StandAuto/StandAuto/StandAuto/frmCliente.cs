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

        private void button1_Click(object sender, EventArgs e)
        {
            txtContato.Enabled = true;
            txtMorada.Enabled = true;
            txtNome.Enabled = true;
            txtNif.Enabled = true;

            this.clienteSetBindingNavigator.BindingSource.AddNew();
            this.clienteSetBindingNavigator.BindingSource.MoveLast();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);
            txtContato.Enabled = false;
            txtMorada.Enabled = false;
            txtNome.Enabled = false;
            txtNif.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp= MessageBox.Show("Tem a certeza que pretende eliminar?","Atenção,",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (resp==DialogResult.Yes)
            {
                this.clienteSetBindingNavigator.BindingSource.RemoveCurrent();
                this.Validate();
                this.clienteSetBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.standAutoDataSet);
            }
            else
            {
                return;
            }

            
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtContato.Enabled = true;
            txtMorada.Enabled = true;
            txtNome.Enabled = true;
            txtNif.Enabled = true;
        }
    }
}
