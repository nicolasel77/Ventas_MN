namespace Ventas_MN.Tipos
{
    class Productos
    {
        public Productos(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        
    }
}
