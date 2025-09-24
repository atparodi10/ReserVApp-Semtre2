using System;

namespace ClinicaOdontologica
{
    public static class Registro
    {
        public static void RegistrarPaciente()
        {
            // Declarar el objeto nuevoPaciente a partir de la estructura Paciente
            Paciente  nuevoPaciente = new Paciente();
            
            // Pedir nombre, edad y tratamiento (Limpieza, Extracción, Ortodoncia); y almacenarlo en nuevoPaciente
            Console.WriteLine("Ingrese el nombre: ");
            nuevoPaciente.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad: ");
            int edad;
            while (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Edad inválida. Intente nuevamente: ");
            }
            nuevoPaciente.Edad = edad;

            Console.WriteLine("Ingrese el tratamiento: ");
            nuevoPaciente.Tratamiento = Console.ReadLine();

            Pacientes.listaPacientes.Add(nuevoPaciente);

            // Agregar nuvoPaciente a ListaPacientes
        }
        public static void MostrarPacientes()
        {
           foreach (var item in Pacientes.listaPacientes)
           {
             Console.WriteLine(string.Format("El nombre es {0} - La edad es: {1} - El tratamiento es: {2}", item.Nombre, item.Edad, item.Tratamiento));
           }
        }
    }
}