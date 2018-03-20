using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;


namespace EjerciciosBD
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataContext("C:\\Users\\Fhree\\Documents\\Pizzeria.mdf");
            var RepPizza = new RepPizzas(db.GetTable<Pizza>());
            var RepIngrediente = new RepIngredientes(db.GetTable<Ingrediente>());

            listarPizzas(RepPizza.getAll());

            Console.WriteLine("Pulsa cualquier tecla para cerrar la aplicación");
            Console.ReadKey();
        }

        static void listarPizzas(List<Pizza> listPizza)
        {
            foreach (var item in listPizza)
            {
                Console.WriteLine("Pizza: "+item.Name+", con id: "+item.Id+" y precio: "+item.getPrecio().ToString());
            }
        }
    }
}
