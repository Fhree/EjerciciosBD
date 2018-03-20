using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBD
{
    public class RepPizzas
    {
        public Table<Pizza> Tabla;

        public RepPizzas(Table<Pizza> tabla)
        {
            Tabla = tabla;
        }

        public Pizza getPizza(int id)
        {
            var query = from p in Tabla where p.Id == id select p;
            Pizza pizza = PizzaFactory.createPizza();
            foreach (var item in query)
            {
               pizza = PizzaFactory.createPizza(item.Id, item.Name);
            }
            return pizza;
        }

        public List<Pizza> getAll()
        {
            List<Pizza> listPizzas = new List<Pizza>();
            var query = from p in Tabla select p;
            foreach (var item in query)
            {
                listPizzas.Add(getPizza(item.Id));
            }
            return listPizzas;
        }

        public void add(Pizza pizza)
        {
            //TODO
        }

        public void addAll(IList<Pizza> pizza)
        {
            foreach (var item in pizza)
            {
                add(item);
            }
        }
    }
}
