using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    public class Empleado
    {
        public string cedula{ get; set; }
        public string nombre { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }
        public double salario_neto { get; set; }
        public double incentivo { get; set; }
        public double descuento { get; set; }
        public double afp { get; set; }
        public double ars { get; set; }

        public Empleado()
        {

        }

        public Empleado(string cedula, string nombre, string departamento, string cargo, double salario)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.departamento = departamento;
            this.cargo = cargo;
            this.salario = salario;
        }
    }
}
