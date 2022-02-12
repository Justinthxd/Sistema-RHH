using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    public class Permiso
    {
        public Permiso()
        {
        }

        public void Tomar_Permiso(List<Empleado> list)
        {
            string cedula;
            DateTime fecha;
            int x = 0;

            Console.WriteLine("Digite su cedula: ");
            cedula = Console.ReadLine();
  

            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.cedula == cedula)
                    {
                        Console.WriteLine("Fecha: ");
                        fecha = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Permiso realizado para: " + fecha);
                        x = 1;
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
