using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBD
{
    public class RepIngredientes
    {
        public Table<Ingrediente> Tabla;

        public RepIngredientes(Table<Ingrediente> tabla)
        {
            Tabla = tabla;
        }

        public Ingrediente getIngrediente(int id)
        {
            var query = from i in Tabla where i.Id == id select i;
            Ingrediente ingrediente = IngredienteFactory.createIngrediente();
            foreach (var item in query)
            {
                ingrediente = IngredienteFactory.createIngrediente(item.Id, item.Name, item.Precio);
            }
            return ingrediente;
        }

        public List<Ingrediente> getAll()
        {
            List<Ingrediente> listIngredientes = new List<Ingrediente>();
            var query = from i in Tabla select i;
            foreach (var item in query)
            {
                listIngredientes.Add(getIngrediente(item.Id));
            }
            return listIngredientes;
        }

        public void addIngrediente(Ingrediente ingrediente)
        {
            //TODO
        }

        public void addAllIngredientes(IList<Ingrediente> ingredientes)
        {
            foreach (var item in ingredientes)
            {
                addIngrediente(item);
            }
        }

    }
}
