using System;

namespace appconsolearreglo.cs
{
    class Program
    {
        private static string nombre, edad, cita;
        
        static void Main(string[] args)
        {
            persona[] arreglo = new persona[2];
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("¿cual es tu nombre?");
                nombre = Console.ReadLine();
                Console.WriteLine("¿cual es tu edad?");
                edad = Console.ReadLine();
                Console.WriteLine("cuando es tu cita?");
                cita = Console.ReadLine();
                arreglo[i] = new persona();
                arreglo[i].Nombre = nombre;
                arreglo[i].Edad = edad;
                arreglo[i].Cita = cita;

            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine((i + 1) + arreglo[i].ToString());
            }
            Console.ReadKey();

        }
    }
}
