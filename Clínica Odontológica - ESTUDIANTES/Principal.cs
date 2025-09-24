using System;
namespace ClinicaOdontologica
{
    class Principal
    {
        static void Main()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("\nClínica Odontológica");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Mostrar pacientes");
                Console.WriteLine("3. Calcular costo de un tratamiento");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Registro.RegistrarPaciente();
                        break;
                    case 2:
                        Registro.MostrarPacientes();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el tratamiento (Limpieza, extraccion, ortodoncia)");
                        string trat = Console.ReadLine();
                        double costo = Calculos.CalcularCosto(trat);
                        Console.WriteLine(string.Format("El costo es: {0}", costo));
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);

        }
    }
}