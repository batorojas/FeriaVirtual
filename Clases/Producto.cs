using System;

namespace Clases
{
    public class Producto
    {
        private int idProducto;
        private int idCategoria;
        private String nombreProducto;
        private int precio;
        private int idCalidad;
        private float porcentajeMerma;
        
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Precio { get => precio; set => precio = value; }
        public int IdCalidad { get => idCalidad; set => idCalidad = value; }
        public float PorcentajeMerma { get => porcentajeMerma; set => porcentajeMerma = value; }
    }
}