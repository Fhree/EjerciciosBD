﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjerciciosBD
{
    class Program
    {
        static void Main(string[] args)
        {
            var guid = Guid.NewGuid();
            Console.Write(guid.ToString());
            Console.ReadKey();
        }
    }
}
