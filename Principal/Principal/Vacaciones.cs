using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    public class Vacaciones
    {

        //DateTime fechaUno = Convert.ToDateTime("2017-12-24 13:30:15");
        //DateTime fechaDos = Convert.ToDateTime("2018-06-15 09:30:00");

        public Vacaciones()
        {
        }

        public void Tomar_Vacaciones(List<Empleado> list)
        {
            string cedula;
            DateTime inicio;
            DateTime fin;
            int x = 0;
            

            Console.WriteLine("Digite su cedula: ");
            cedula = Console.ReadLine();


            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.cedula == cedula)
                    {
                        Console.WriteLine("Hola "+item.nombre);
                        Console.WriteLine("Inicio: ");
                        inicio = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Fin: ");
                        fin = DateTime.Parse(Console.ReadLine());

                        TimeSpan difFechas = fin - inicio;

                        int dias = difFechas.Days;
                        Console.WriteLine("La cantidad de dias son: " + dias);
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
