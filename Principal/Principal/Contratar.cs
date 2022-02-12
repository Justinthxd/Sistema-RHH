using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    class Contratar
    {
        public Contratar()
        {
        }

        public void Contratar_Empleado(List<Empleado> list)
        {
            Empleado e = new Empleado();

            Console.WriteLine("Cedula");
            e.cedula = Console.ReadLine();
            Console.WriteLine("Nombre");
            e.nombre = Console.ReadLine();
            Console.WriteLine("Departamento");
            e.departamento = Console.ReadLine();
            Console.WriteLine("Cargo");
            e.cargo = Console.ReadLine();
            Console.WriteLine("Salario");
            e.salario = double.Parse(Console.ReadLine());

            list.Add(e);
        }
    }
}
