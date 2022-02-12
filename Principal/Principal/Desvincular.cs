using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    public class Desvincular
    {
        public Desvincular()
        {
        }

        public void Desvincular_Empleado(List<Empleado> list)
        {
            string cedula;
            string causa;
            int x = 0;
            string y;

            Console.WriteLine("Digite su cedula: ");
            cedula = Console.ReadLine();

            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.cedula == cedula)
                    {
                        Console.WriteLine("Desea eliminar a " + item.nombre + "? [si] [no]");
                        y = Console.ReadLine();
                        if(y == "si") 
                        {
                            Console.WriteLine("Digite la causa: ");
                            causa = Console.ReadLine();
                            Console.WriteLine(item.nombre + " fue desvinculado/a.");
                            list.Remove(item);
                            x = 1;
                            break;
                        }
                        else
                        {
                            x = 1;
                            break;
                        }
                    }
                }
                if (x == 0)
                {
                    Console.WriteLine("Ese empleado no existe.");
                }
            }
            else
            {
                Console.WriteLine("No hay empleados.");
            }
        }
    }
}
