using System;
using System.Windows.Forms;

namespace Ventas_MN
{
    public partial class frmContenedor : Form
    {
        frmProductos frProductos = new frmProductos();
        frmStock frStock = new frmStock();

        public frmContenedor()
        {
            InitializeComponent();
        }

        private void mnuStock_Click(object sender, EventArgs e)
        {
            
            frStock.MdiParent = this;              
            frStock.Show();
            frStock.WindowState = FormWindowState.Minimized;
            frStock.WindowState = FormWindowState.Maximized;

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProductos.MdiParent = this;
            frProductos.Show();
            frProductos.WindowState = FormWindowState.Minimized;
            frProductos.WindowState = FormWindowState.Maximized;
        }
        
    }
}
