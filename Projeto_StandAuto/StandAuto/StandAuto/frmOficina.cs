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

        private ModelDoProfContainer StandAuto;
        public frmOficina()
        {
            //db.Open();
            InitializeComponent();
            StandAuto = new ModelDoProfContainer();
            lbCliente.DataSource = StandAuto.ClienteSet.ToList<Cliente>();
            lbCliente.SelectedItem = null;
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
            if (lbCliente.SelectedItem != null)
            {
                Cliente clienteselecionado = (Cliente)lbCliente.SelectedItem;

                lbCarros.DataSource = null;

                lbCarros.DataSource = clienteselecionado.CarroOficina.ToList();
            }
        }

        private void lbCliente_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void lbCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCarros.SelectedItem != null)
            {
                CarroOficina clienteselecionado = (CarroOficina)lbCarros.SelectedItem;
            
               /* if(clienteselecionado != null)
                {
                    if((lbServiços.DataSource = clienteselecionado.Serviço.ToList()) != null)
                    {
                        lbServiços.DataSource = clienteselecionado.Serviço.ToList() != null;
                        lbServiços.SelectedItem = null;
                        lbParcelas.DataSource = null;
                    }
                }*/
            }
        }
    }
}
