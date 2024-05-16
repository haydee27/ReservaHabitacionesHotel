using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservacionesHoteles
{
    public partial class MDIMenu : Form
    {
      

        public MDIMenu()
        {
            InitializeComponent();
        }

        private void InformacionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clie=new FrmClientes();
            clie.MdiParent = this;
            clie.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
