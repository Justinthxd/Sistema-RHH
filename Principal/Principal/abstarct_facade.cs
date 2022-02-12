using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    public class Facade
    {
        Contratar contratar = new Contratar();
        Vacaciones vacaciones = new Vacaciones();
        Permiso permiso = new Permiso();
        Desvincular desvincular = new Desvincular();
        Nomina nomina = new Nomina();


        public void Contratar(List<Empleado> list) 
        {
            contratar.Contratar_Empleado(list);
        }
        public void Vacaciones(List<Empleado> list) 
        {
            vacaciones.Tomar_Vacaciones(list);
        }
        public void Permiso(List<Empleado> list) 
        {
            permiso.Tomar_Permiso(list);
        }
        public void Desvincular(List<Empleado> list) 
        {
            desvincular.Desvincular_Empleado(list);
        }
        public void Pago(List<Empleado> list)
        {
            nomina.Pago(list);
        }
        public void Imprimir(List<Empleado> list)
        {
            nomina.Imprimir(list);
        }
    }
}
