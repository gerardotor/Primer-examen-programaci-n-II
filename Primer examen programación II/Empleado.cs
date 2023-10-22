using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_examen_programación_II
{
    internal class Empleado
    {
        //atributos
        public static int cant = 5;
        public static string[] cedula = new string[cant];
        public static string[] nombre = new string[cant];
        public static string[] direccion = new string[cant];
        public static int[] telefono = new int[cant];
        public static int[] salario = new int[cant];
        public static byte indice;
        public static byte i;
        public static int cont;
        private static object id;

        public Empleado()
        {
            cont = 1;
            indice = 0;
        }

        // métodos

        public static void Inicializar()
        {
            indice = 0;
            cedula = Enumerable.Repeat("", cant).ToArray();
            cedula = Enumerable.Repeat("", cant).ToArray();
            Console.WriteLine("los arreglos han sido inicializados");
        }

        //reporte con filtro
        public static void Reporteconfiltrocedula()
        {
            Console.WriteLine("digite cédula");
            string ced = Console.ReadLine();
            Boolean encontró = false;

            for (int i = 0; i < cant; i++)
            {
                if (cedula.Equals(Empleado.cedula[i]))
                {
                    Console.WriteLine($"cedula: {Empleado.cedula[i]}nombre: {nombre[i]}");
                    encontró = true;
                    break;
                }
            }

            if (encontró == false)
            {
                Console.WriteLine("cédula no existe");
            }
        }

        //reporte general
        public static void Reportedetodos()
        {
            Console.WriteLine("listar todos los empleados");

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine($"cedula: {Empleado.cedula[i]}nombre: {nombre[i]}");
            }
            Console.WriteLine("ultima linea");
        }

        //ingresar datos
        public static void Ingresar()
        {
            char respuesta = 'N';
            int cant = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Cedula {0}:", cant);
                cedula[i] = Console.ReadLine();
                Console.WriteLine("Nombre {0}:", cant);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Dirección {0}:", cant);
                direccion[i] = Console.ReadLine();
                Console.WriteLine("Teléfono {0}:", cant);
                int.TryParse(Console.ReadLine(), out telefono[indice]);
                Console.WriteLine("Salario {0}:", cant);
                int.TryParse(Console.ReadLine(), out salario[indice]);
                cant++;
                indice++;
                Console.WriteLine("desea ingresar otro (S/N)");

                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta != 'N');
        }

        public static void Consultar(string id)
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();

            for (int i = 0; i < cant; i++)
            {
                if (id.Equals(cedula[i]))
                {
                    Console.Write($"cedula: {cedula[i]}");
                    Console.Write($"nombre: {nombre[i]}");
                    Console.Write($"direccion: {direccion[i]}");
                    Console.Write($"telefono: {telefono[i]}");
                    Console.Write($"salario: {salario[i]}");
                    break;
                }
            }
        }

        public static string Buscar()
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();
            return ced;
        }

        public static void Modificar(string id)
        {

            for (int i = 0; i < cant; i++)
            {
                if (id.Equals(cedula[i]))
                {
                    Console.Write("Digite nueva cédula: ");
                    cedula[i] = Console.ReadLine();
                    Console.Write("Digite nuevo nombre: ");
                    nombre[i] = Console.ReadLine() ;
                    Console.Write("Digite nueva dirección: ");
                    direccion[i] = Console.ReadLine();
                    Console.Write("Digite nuevo teléfono: ");
                    telefono[i] = Console.Read();
                    Console.Write("Digite nuevo salario: ");
                    salario[i] = Console.Read();
                    break;
                }
            }

        }
    }
}

