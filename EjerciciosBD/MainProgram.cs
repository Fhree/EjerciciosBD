using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Data;

namespace EjerciciosBD
{
    class MainProgram
    {
        public static readonly String PATHJSON = @"C:\Users\Usuario\Source\Repos\EjerciciosBD\EjerciciosBD\preguntas.json";

        static void Main(string[] args)
        {

            createMenu(PreguntaSQL.fromJSON(File.ReadAllText(PATHJSON)));

            /*using (var db = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Usuario\\Documents\\Pizzeria.mdf;Integrated Security=True;Connect Timeout=30"))
             {
                 db.Open();
                 
                 
            }//Recordatorio -> llamada al dispose() de forma automática
            
            
             var RepPizza = new RepPizzas(db.GetTable<Pizza>());
             var RepIngrediente = new RepIngredientes(db.GetTable<Ingrediente>());

             listarPizzas(RepPizza.getAll());*/

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

        static void createMenu(List<PreguntaSQL> listPreguntas)
        {
            foreach (var item in listPreguntas)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }     
}
