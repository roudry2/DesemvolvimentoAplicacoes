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
    public partial class frmSelecionarCarro : Form
    {
        public frmSelecionarCarro()
        {
            InitializeComponent();
        }

        private void carroSet_CarroOficinaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carroSet_CarroOficinaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);

        }

        private void frmSelecionarCarro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standAutoDataSet.CarroSet_CarroOficina' table. You can move, or remove it, as needed.
            this.carroSet_CarroOficinaTableAdapter.Fill(this.standAutoDataSet.CarroSet_CarroOficina);

        }

        private void btnCriarCarro_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCriarCarro carro = new frmCriarCarro();
            carro.ShowDialog();
        }

        private void frmSelecionarCarro_Activated(object sender, EventArgs e)
        {
            Auxiliar idt = new Auxiliar();
            //label1.Text = idt.idt;
        }
    }
}
