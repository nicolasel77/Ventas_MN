using System.IO;
using System.Windows.Forms;

namespace Ventas_MN
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, System.EventArgs e)
        {
            if (!File.Exists("productos.txt"))
            {

            }
            StreamReader stProductos = new StreamReader("productos.txt");

        }

        private void lstProductos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtEditar.Text = lstProductos.Text;
        }

        private void cmdConvertir_Click(object sender, System.EventArgs e)
        {
            Herramientas.Herramientas h = new Herramientas.Herramientas();
            int vIndice = 0;
            int vMaximo = 0;

            foreach (string Producto in lstProductos.Items)
            {
                vIndice = h.Codigo_Seleccionado(Producto);
                if (vIndice > vMaximo) { vMaximo = vIndice; }
            }
            cmdConvertir.Text = $"El valor para nuevo prod es {vMaximo + 1}.";
        }
    }
}
