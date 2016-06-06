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
    public partial class frmAluguer : Form
    {
        public frmAluguer()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void aluguerSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aluguerSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);

        }

        private void frmAluguer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standAutoDataSet.AluguerSet' table. You can move, or remove it, as needed.
            this.aluguerSetTableAdapter.Fill(this.standAutoDataSet.AluguerSet);

        }

        private void llb_IDSelecionado_Click(object sender, EventArgs e)
        {

        }

        private void aluguerSetDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGV_Aluguer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_MainEditar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = true;
            btn_MainEditar.Enabled = false;
            btn_MainAluguer.Enabled = false;
            btn_MainPesquisar.Enabled = false;
            btn_Pesquisar.Enabled = false;
            btn_Adicionar.Enabled = false;
            btn_SelecCarro.Enabled = true;
            btn_SelecCliente.Enabled = true;
            btn_Editar.Enabled = true;
            lbl_Modo.Text = "Edição";
            valorTextBox.ReadOnly = false;
            dataInicioTextBox.ReadOnly = false;
            dataFimTextBox.ReadOnly = false;
            kmsTextBox.ReadOnly = false;
        }

        private void aluguerSetDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(lbl_Modo.Text == "---")
            {
                btn_MainEditar.Enabled = true;
            }
            

        }

        private void btn_MainPesquisar_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btn_Cancelar.Enabled = true;
            btn_MainEditar.Enabled = false;
            btn_MainPesquisar.Enabled = false;
            btn_Adicionar.Enabled = false;
            cb_Pesquisa.Enabled = true;
            btn_Pesquisar.Enabled = true;
            lbl_Modo.Text = "Pesquisa";
            txt_Pesquisa.ReadOnly = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btn_Cancelar.Enabled = false;
            btn_MainEditar.Enabled = true;
            btn_MainPesquisar.Enabled = true;
            btn_MainAluguer.Enabled = true;
            btn_Adicionar.Enabled = false;
            btn_Pesquisar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_SelecCarro.Enabled = false;
            btn_SelecCliente.Enabled = false;
            cb_Pesquisa.Enabled = false;
            lbl_Modo.Text = "---";
            txt_Pesquisa.ReadOnly = true;
            valorTextBox.ReadOnly = true;
            dataInicioTextBox.ReadOnly = true;
            dataFimTextBox.ReadOnly = true;
            kmsTextBox.ReadOnly = true;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_MainAluguer_Click(object sender, EventArgs e)
        {
            btn_MainEditar.Enabled = false;
            btn_MainPesquisar.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Adicionar.Enabled = true;
            btn_SelecCarro.Enabled = true;
            btn_SelecCliente.Enabled = true;
            lbl_Modo.Text = "Adicionar";
            valorTextBox.ReadOnly = false;
            kmsTextBox.ReadOnly = false;
            dataFimTextBox.ReadOnly = false;
            dataInicioTextBox.ReadOnly = false;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aluguerSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);
        }
    }
}
