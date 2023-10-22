using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_examen_programación_II
{
    internal class reporte
    {
        //atributos

        public static byte opcion = 0;

        public static void submenu() //submenú
        {
            do
            {
                Console.WriteLine("1 - consulta empleado por cédula");
                Console.WriteLine("2 - todos los empleados");
                Console.WriteLine("3 - promedio salarios");
                Console.WriteLine("4 - salario más alto y más bajo");
                Console.WriteLine("5 - salir");
                byte.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: Empleado.Reporteconfiltrocedula(); break;
                    case 2: Empleado.Reportedetodos(); break;
                    case 3: Empleado.Reportedetodos(); break;
                    default:
                        break;
                }
            } while (opcion != 5);
        }
    }
}
