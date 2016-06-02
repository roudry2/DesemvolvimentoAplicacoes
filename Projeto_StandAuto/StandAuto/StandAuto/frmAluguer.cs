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
            if (DGV_Aluguer.SelectedCells.Count > 0)
            {
                int selectedrowindex = DGV_Aluguer.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = DGV_Aluguer.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["IdAluguer"].Value);

                lbl_IDSelecionado.Text = a;

            }
        }
    }
}
