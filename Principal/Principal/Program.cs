using System;
using System.Collections.Generic;

namespace Principal
{
    class Program
    {
       static void Main (string[] args)
       {
            Facade aux = new Facade();

            List<Empleado> list = new List<Empleado>();

            int opc = 1;

            while (opc != 0)
            {
                Console.WriteLine("1. Contratacion");
                Console.WriteLine("2. Desvincular");
                Console.WriteLine("3. Pago");
                Console.WriteLine("4. Imprimir Nomina");
                Console.WriteLine("0. Salir");
                opc = Int32.Parse(Console.ReadLine());



                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        aux.Contratar(list);
                        break;
                    case 2:
                        Console.Clear();
                        aux.Desvincular(list);
                        break;
                    case 3:
                        Console.Clear();
                        aux.Pago(list);
                        break;
                    case 4:
                        Console.Clear();
                        aux.Imprimir(list);
                        break;
                    default: break;
                }
                
            }
        }
    }
}
