using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_examen_programación_II
{
    internal class Menu
    {

        //atributos
        static public int opcion = 0;

        //métodos
        public Menu() { }
        public static void Desplegar()
        {
            do
            {
                Console.WriteLine("1 - inicializar");
                Console.WriteLine("2 - agregar empleados");
                Console.WriteLine("3 - consultar empleados");
                Console.WriteLine("4 - modificar empleados");
                Console.WriteLine("5 - borrar empleados");
                Console.WriteLine("6 - reportes");
                Console.WriteLine("7 - salir");
                int.TryParse(Console.ReadLine(), out opcion); // no se caiga
                switch (opcion)
                {

                    case 1: Empleado.Inicializar(); break;
                    case 2: Empleado.Ingresar(); break;
                    case 3: Empleado.Consultar(Empleado.Buscar()); break;
                    case 4: Empleado.Modificar(Empleado.Buscar()); break;
                    case 5:  break;
                    case 6: reporte.submenu(); break;
                    
                    default:
                        Console.WriteLine("Número incorrecto");
                        break;


                }
            } while (opcion != 7);
        }
    }
}

