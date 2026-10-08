using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Examen       Progra 2        Cid Guzman Chaverri

namespace CidGuzman
{
    internal class Program
    {

        static int N = 12;
        static string[] listaNombres = new string[N];
        static int[] listaUrgencias = new int[N];
        static int cantPacientes = 0;

        static void Menu()
        {
            Console.WriteLine("1-Registrar paciente");
            Console.WriteLine("2-Consultar pacientes");
            Console.WriteLine("3-Modificar urgencia");
            Console.WriteLine("4-Eliminar paciente");
            Console.WriteLine("5-Salir");
            Console.Write("Seleccione una opcion: ");
        }

        static void RegistroPaciente()
        {
            string nombre = string.Empty;
            int nivUrgencia = 0;

            if (cantPacientes < N)
            {
                Console.Write("Ingrese el nombre del paciente: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese el nivel de urgencia del paciente (1 - 5): ");
                nivUrgencia = int.Parse(Console.ReadLine());

                while (nivUrgencia < 1 || nivUrgencia > 5)
                {
                    Console.WriteLine("Nivel de urgencia invalido.");
                    Console.Write("Ingrese un valor entre 1 y 5: ");
                    nivUrgencia = int.Parse(Console.ReadLine());
                }

                listaNombres[cantPacientes] = nombre;
                listaUrgencias[cantPacientes] = nivUrgencia;

                cantPacientes++;

                Console.WriteLine("Paciente registrado.");
            }
            else
            {
                Console.WriteLine("No hay espacio para agregar un paciente.");
            }
        }

        static void ConsultaPaciente()
        {
            int i = 0;

            if (cantPacientes > 0)
            {
                for (i = 0; i < cantPacientes; i++)
                {
                    Console.WriteLine("Posicion del paciente: " + i);
                    Console.WriteLine("Nombre del paciente: " + listaNombres[i]);
                    Console.WriteLine("Nivel de urgencia: " + listaUrgencias[i]);
                    Console.WriteLine();
                }

                Console.WriteLine("Cantidad de pacientes: " + cantPacientes + "\n");
            }
            else
            {
                Console.WriteLine("Aun no hay pacientes.");
            }
        }

        static void ModificarUrgencia()
        {
            int i = 0;
            int posicion = 0;
            int nivUrgencia = 0;

            if (cantPacientes > 0)
            {
                for (i = 0; i < cantPacientes; i++)
                {
                    Console.WriteLine("Posicion: " + i);
                    Console.WriteLine("Nombre del paciente: " + listaNombres[i]);
                    Console.WriteLine("Urgencia: " + listaUrgencias[i] + "\n");
                }

                Console.Write("Ingrese la posicion del paciente a modificar el nivel de urgencia: ");
                posicion = int.Parse(Console.ReadLine());

                if (posicion >= 0 && posicion < cantPacientes)
                {
                    Console.Write("Ingrese el nivel de urgencia (1-5): ");
                    nivUrgencia = int.Parse(Console.ReadLine());

                    while (nivUrgencia < 1 || nivUrgencia > 5)
                    {
                        Console.WriteLine("Nivel de urgencia invalido.");
                        Console.Write("Ingrese un valor entre 1 y 5: ");
                        nivUrgencia = int.Parse(Console.ReadLine());
                    }

                    listaUrgencias[posicion] = nivUrgencia;

                    Console.WriteLine("El nivel de urgencia se modifico.");
                }
                else
                {
                    Console.WriteLine("La posicion no es valida.");
                }
            }
            else
            {
                Console.WriteLine("Aun no hay pacientes.");
            }
        }

        static void EliminarPaciente()
        {
            int i = 0;
            int posicion = 0;

            if (cantPacientes > 0)
            {
                for (i = 0; i < cantPacientes; i++)
                {
                    Console.WriteLine("Posicion: " + i);
                    Console.WriteLine("Nombre del paciente: " + listaNombres[i]);
                    Console.WriteLine("Urgencia: " + listaUrgencias[i] + "\n");
                }

                Console.Write("Ingrese la posicion del paciente a eliminar: ");
                posicion = int.Parse(Console.ReadLine());

                if (posicion >= 0 && posicion < cantPacientes)
                {
                    for (i = posicion; i < cantPacientes - 1; i++)
                    {
                        listaNombres[i] = listaNombres[i + 1];
                        listaUrgencias[i] = listaUrgencias[i + 1];
                    }

                    cantPacientes--;

                    Console.WriteLine("Paciente eliminado.");
                }
                else
                {
                    Console.WriteLine("La posicion no es valida.");
                }
            }
            else
            {
                Console.WriteLine("Aun no hay pacientes.");
            }
        }

        static void Main(string[] args)
        {

            int opcion = 0;

            do
            {
                Menu();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:
                        RegistroPaciente();
                        break;

                    case 2:
                        ConsultaPaciente();
                        break;

                    case 3:
                        ModificarUrgencia();
                        break;

                    case 4:
                        EliminarPaciente();
                        break;

                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;

                }
            } while (opcion != 5);

        }
    }
}
