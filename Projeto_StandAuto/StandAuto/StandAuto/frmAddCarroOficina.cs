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
    public partial class frmAddCarroOficina : Form
    {
        public frmAddCarroOficina()
        {
            InitializeComponent();
        }

        private void carroSet_CarroOficinaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carroSet_CarroOficinaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.standAutoDataSet);

        }

        private void frmAddCarroOficina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'standAutoDataSet.CarroSet_CarroOficina' table. You can move, or remove it, as needed.
            this.carroSet_CarroOficinaTableAdapter.Fill(this.standAutoDataSet.CarroSet_CarroOficina);

        }
    }
}
