using System;
using System.Collections.Generic;

class Programa
{
    static void Main(string[] args)
    {
        // Catálogo de revistas en español
        List<string> catalogo = new List<string>
        {
            "Ecuador Debate",
            "Eutopía",
            "Mundos Plurales",
            "Íconos",
            "Vistazo",
            "Mundo Diners",
            "Estoa",
            "Ingenius",
            "NATURE",
            "SCIENCE"
        };

        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== Catálogo de Revistas ===");
            Console.WriteLine("1. Buscar revista");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
                opcion = 0;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el título de la revista a buscar: ");
                    string titulo = Console.ReadLine();
                    bool encontrado = Buscar(catalogo, titulo, 0);
                    Console.WriteLine(encontrado ? "Encontrado" : "No encontrado");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Presione una tecla...");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 2);
    }

    // Búsqueda recursiva
    static bool Buscar(List<string> catalogo, string titulo, int indice)
    {
        if (indice >= catalogo.Count)
            return false; // Llegamos al final sin encontrar

        if (catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
            return true; // Coincidencia encontrada

        return Buscar(catalogo, titulo, indice + 1);
    }
}
