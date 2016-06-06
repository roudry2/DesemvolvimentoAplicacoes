using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAuto
{
    public partial class frmOficina : Form
    {
        //Auxiliar db = new Auxiliar();
        public frmOficina()
        {
            //db.Open();
            InitializeComponent();

        }

        private void frmOficina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standAutoDataSet.CarroSet_CarroOficina' table. You can move, or remove it, as needed.
            //this.carroSet_CarroOficinaTableAdapter.Fill(this.standAutoDataSet.CarroSet_CarroOficina);
            // TODO: This line of code loads data into the 'standAutoDataSet.ClienteSet' table. You can move, or remove it, as needed.
            //this.clienteSetTableAdapter.Fill(this.standAutoDataSet.ClienteSet);
            //carrega os clientes na lb
            
        



    }

        private void lvlNomeCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            frmCriarCarro carro = new frmCriarCarro();
            carro.ShowDialog();
        }

        private void frmOficina_Activated(object sender, EventArgs e)
        {

        }

        private void lbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //StandAutoDataSet.ClienteSetRow clienteselecionado;
            ClassCliente clienteselecionado = (ClassCliente)lbCliente.SelectedItem;
            //clienteselecionado = (StandAutoDataSet.ClienteSetRow)lbCliente.SelectedItem;
            lblNomeCliente.Text = clienteselecionado.Nome;
            lblNif.Text = clienteselecionado.NIF;
            lblNrTele.Text = clienteselecionado.Contacto;

            lbCarros.DataSource = null;

            lbCarros.DataSource = clienteselecionado.ClassCarros;
        }
    }
}
