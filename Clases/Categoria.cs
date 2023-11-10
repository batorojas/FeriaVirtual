using System;

namespace Clases
{
    public class Categoria
    {
        private int idCategoria;
        private String nombreCategoria;
        
        
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
    }
}