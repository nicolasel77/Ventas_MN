using System.Windows.Forms;
using Ventas_MN.Tipos;

namespace Ventas_MN
{
    public partial class frmProductos : Form
    {
        Productos productos = new Productos();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, System.EventArgs e)
        {
            lstProductos.Items.Add(productos.Id + ". " + productos.Nombre);
        }

        private void lstProductos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtEditar.Text = lstProductos.Text;
        }

        private void cmdConvertir_Click(object sender, System.EventArgs e)
        {
            int vNuevo = productos.Valor_Nuevo();

            
            cmdConvertir.Text = $"El valor para nuevo prod es {vNuevo}.";
        }
    }
}
