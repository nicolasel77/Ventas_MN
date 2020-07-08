namespace Ventas_MN.Tipos
{
    class Productos
    {
        string vArchivo;

        public Productos(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public Productos()
        {
            //se lea el arcivo txt
            //y se carge vArchivo con los valores
        }

        public int Id { get; set; }
        public string Nombre { get; set; }


        public int Valor_Nuevo()
        {
            return 100;
        }
        public string Datos()
        {
            return vArchivo;
        }
    }
}
