using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBD
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public float Precio { get; set; }

        public Ingrediente() { }

        public Ingrediente(int id, String name, float precio)
        {
            Id = id;
            Name = name;
            Precio = precio;
        }
        public float GetPrecio()
        {
            //TODO
            return 5;
        }
    }
}