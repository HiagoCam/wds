using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaSplash : Form
    {
        estadualEntities bd = new estadualEntities();
        public representante usuarioLogado = new representante();
        public static string senhaDescoberta;

        public TelaSplash()
        {
            InitializeComponent();
        }
        public TelaSplash(representante usuario, string senhaDescriptografada)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
            senhaDescoberta = senhaDescriptografada;
            lblProgessBar.Text = "Carregando componentes...";
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 12)
            {
                if (progressBar1.Value > 2 && progressBar1.Value <= 5)
                {
                    lblProgessBar.Text = "Carregando dados...";
                }
                else if (progressBar1.Value > 5 && progressBar1.Value <= 8)
                {
                    lblProgessBar.Text = "Carregando imagens...";
                }
                else if (progressBar1.Value > 8 && progressBar1.Value <= 13)
                {
                    lblProgessBar.Text = "Iniciando Dashboard...";
                }
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                new TelaDashboard(usuarioLogado, senhaDescoberta).Show();
                this.Hide();
            }
        }

        private void TelaSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 12;
            timer1.Tick += new EventHandler(timer1_Tick);
        }
    }
}
