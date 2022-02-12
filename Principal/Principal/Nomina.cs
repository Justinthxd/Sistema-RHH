using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;

namespace Principal
{
    public class Nomina
    {
        public Nomina()
        {
        }

        public void Consultar_Nomina(List<Empleado> list)
        {
            string cedula;
            string concepto;
            int x = 0;
            int y = 0;

            Console.WriteLine("Digite su cedula: ");
            cedula = Console.ReadLine();

            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.cedula == cedula)
                    {
                        Console.WriteLine("1. Añadir Incentivo");
                        Console.WriteLine("2. Añadir Descuento");
                        y = Int32.Parse(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                Console.WriteLine("Digite el monto: ");
                                item.incentivo = double.Parse(Console.ReadLine());
                                Console.WriteLine("Concepto: ");
                                concepto = Console.ReadLine();
                                Console.WriteLine("Incentivo añadido.");
                                x = 1;
                                break;
                            case 2:
                                Console.WriteLine("Digite el monto: ");
                                item.descuento = double.Parse(Console.ReadLine());
                                Console.WriteLine("Concepto: ");
                                concepto = Console.ReadLine();
                                Console.WriteLine("Descuento añadido.");
                                x = 1;
                                break;
                            default: x = 1; break;
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

        public void Pago(List<Empleado> list)
        {
            double afp = 0;
            double ars = 0;

            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    item.afp = item.salario * 0.0287;
                    item.ars = item.salario * 0.0301;
                    item.salario_neto = item.salario;
                    item.salario_neto -= (item.afp + item.ars);
                    if (item.incentivo <= 0)
                    {
                        Console.WriteLine(item.nombre + " no tiene incentivo");
                    }
                    if (item.descuento <= 0)
                    {
                        Console.WriteLine(item.nombre + " no tiene descuento");
                    }
                    
                    Console.WriteLine("La paga de " + item.nombre + " es de " + item.salario_neto + "$");
                }
            }
            else
            {
                Console.WriteLine("No hay empleados.");
            }
        }



        public void Imprimir(List<Empleado> list)
        {
            int i = 1;

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    xlWorkSheet.Cells[1, 1] = "Cedula";
                    xlWorkSheet.Cells[1, 2] = "Nombre";
                    xlWorkSheet.Cells[1, 3] = "Departamento";
                    xlWorkSheet.Cells[1, 4] = "Cargo";
                    xlWorkSheet.Cells[1, 5] = "Salario";
                    xlWorkSheet.Cells[1, 6] = "AFP";
                    xlWorkSheet.Cells[1, 7] = "ARS";
                    xlWorkSheet.Cells[1, 8] = "Salario Neto";

                    xlWorkSheet.Cells[i + 1, 1] = item.cedula;
                    xlWorkSheet.Cells[i + 1, 2] = item.nombre;
                    xlWorkSheet.Cells[i + 1, 3] = item.departamento;
                    xlWorkSheet.Cells[i + 1, 4] = item.cargo;
                    xlWorkSheet.Cells[i + 1, 5] = item.salario;
                    xlWorkSheet.Cells[i + 1, 6] = item.afp;
                    xlWorkSheet.Cells[i + 1, 7] = item.ars;
                    xlWorkSheet.Cells[i + 1, 8] = item.salario_neto;
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay empleados.");
            }

            xlWorkBook.SaveAs("C:\\Users\\HP\\Desktop\\csharp-Excel.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }
    }
}
