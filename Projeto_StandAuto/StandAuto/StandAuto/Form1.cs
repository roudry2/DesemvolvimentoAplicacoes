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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        public int timerSp;
        public static frmSplash frmSplash;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            // Faz aparecer o splah screen
            frmSplash = new frmSplash();
            frmSplash.Show();
            timerSp = 5;
            timerSplash.Start();
                      

        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (timerSp > 0)
            {
                timerSp = timerSp - 1;
                //frmSplash.progressBarLoading.Increment(1);
                frmSplash.progressBarLoading.Value += 20;
            }
            else
            {
                timerSplash.Stop();
                //CARREGA OS DADOS
                /*
                ............
                ...........
                ..........           
                
                */
                frmSplash.Close();

                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmOficina frmOfi = new frmOficina();
            frmOfi.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAluguer frmAlu = new frmAluguer();
            frmAlu.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmVenda frmVend = new frmVenda();
            frmVend.ShowDialog();
        }

        private void tslData_Click(object sender, EventArgs e)
        {
            
           
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            
            
        }
    }
}
