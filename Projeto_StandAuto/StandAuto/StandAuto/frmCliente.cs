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

        DataRow[] foundRows;


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
            cbFiltro.Text = "Nome";

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

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            // Variavel para o nome a procurar
            String procura = txtFiltrar.Text;


            // Verifica se a textbox tem alguma coisa
            if (string.IsNullOrWhiteSpace(txtFiltrar.Text))
            {
                // Quando a textbox nao tem nada preenche a datagridview com todos os registos
                clienteSetDataGridView.DataSource = clienteSetBindingSource;

            }
            // Quando a textbox tem texto
            
            else
            {
                
                // Busca a linha
                switch (cbFiltro.SelectedItem.ToString())
                {
                    case "Nome":
                         foundRows = standAutoDataSet.Tables["ClienteSet"].Select("Nome Like '%" + procura + "%'");
                        break;
                    case "NIF":
                         foundRows = standAutoDataSet.Tables["ClienteSet"].Select("NIF Like '%" + procura + "%'");
                        break;
                    case "Morada":
                        foundRows = standAutoDataSet.Tables["ClienteSet"].Select("Morada Like '%" + procura + "%'");
                        break;
                    case "Contacto":
                        foundRows = standAutoDataSet.Tables["ClienteSet"].Select("Contacto Like '%" + procura + "%'");

                        break;
                }


                

                // Se encontrar
                try
                {

                    // Escreve na Datagridview
                    clienteSetDataGridView.DataSource = foundRows.CopyToDataTable();
                }
                // Se Nao Encontrar
                catch (Exception ex)
                {
                    // Msg De erro
                    MessageBox.Show("Nenhum resultado encontrado na BD", "Messagem Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Mete lá todos
                    clienteSetDataGridView.DataSource = clienteSetBindingSource;
                }

            }

        }
    }
}


