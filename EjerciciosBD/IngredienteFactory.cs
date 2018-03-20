using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBD
{
    public class IngredienteFactory
    {
        public static Ingrediente createIngrediente()
        {
            return new Ingrediente();
        }
        public static Ingrediente createIngrediente(int id, String name, float precio)
        {
            return new Ingrediente(id, name, precio);
        }
    }
}
