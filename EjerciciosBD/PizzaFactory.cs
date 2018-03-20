using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBD
{
    public class PizzaFactory
    {
        public static Pizza createPizza()
        {
            return new Pizza();
        }
        public static Pizza createPizza(int id, String name)
        {
            return new Pizza(id,name);
        }
    }
}
