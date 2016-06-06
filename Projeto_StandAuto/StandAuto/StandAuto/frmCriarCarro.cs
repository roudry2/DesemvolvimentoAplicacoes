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
    public partial class frmCriarCarro : Form
    {
        public Cliente clienteSelecionado;
        public frmCriarCarro(Cliente clienteselect)
        {
            InitializeComponent();
            this.clienteSelecionado = clienteselect;
        }

        private void carroSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carroSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);

        }

        private void frmCriarCarro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standAutoDataSet.CarroSet' table. You can move, or remove it, as needed.
            this.carroSetTableAdapter.Fill(this.standAutoDataSet.CarroSet);
            txtChassis.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            combustivelComboBox.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carroSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);

            txtChassis.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            combustivelComboBox.Enabled = false;

            btnAlterar.Enabled = true;
            btnElminar.Enabled = true;
            btnNovo.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.carroSetBindingNavigator.BindingSource.AddNew();
            this.carroSetBindingNavigator.BindingSource.MoveLast();

            txtChassis.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            combustivelComboBox.Enabled = true;

            btnAlterar.Enabled = false;
            btnElminar.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Tem a certeza que pretende eliminar?", "Atenção,", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                this.carroSetBindingNavigator.BindingSource.RemoveCurrent();
                this.Validate();
                this.carroSetBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.standAutoDataSet);
            }
            else
            {
                return;
            }
        }

        private void combustivelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtChassis.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            combustivelComboBox.Enabled = true;

            btnNovo.Enabled = false;
            btnElminar.Enabled = false;
            btnAlterar.Enabled = false;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CarroOficina car = new CarroOficina();
            car.IdCarro =Convert.ToInt32(idCarroTextBox.Text);
            car.NumeroChassis = txtChassis.Text;
            car.Modelo = txtModelo.Text;
            car.Marca = txtMarca.Text;
            car.Combustivel = combustivelComboBox.Items.ToString();

            clienteSelecionado.CarroOficina.Add(car);



            this.Close();



        }
    }
}
