using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBD
{
    public class Pizza
    {
        public String Name { get; set; }

        public String getPrecio()
        {
            float precioTotal = 0;
            List<Ingrediente> listIngredientes = getIngredientes();
            foreach (var ingrediente in listIngredientes)
            {
                precioTotal += ingrediente.GetPrecio();
            }
            return precioTotal.ToString();
        }

        public List<Ingrediente> getIngredientes()
        {
            //TODO 
            return null;
        }

    }
}
