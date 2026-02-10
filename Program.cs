using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Mensaje de bienvenida
        Console.WriteLine("\n -- Sistema de Bella Napoli --");
        Console.WriteLine(" Bienvenidos a Pizza Bella Napoli, \n ordene la pizza que tenemos disponibles de nuestro siguiente menu:");
        Console.WriteLine(" 1- Pizza Vegetaria\n 2- Pizza no vegetariana");
        Console.WriteLine(" [PD: Todas nuestras pizzas incluyen de base: Tomate y Mozzarella. 🍅🧀]");

        // Lista de ingredientes dependiente del tipo de pizza
        List<string> IngredientesVegetarianos = ["Pimiento 🫑", "Tofu 🧊"];
        List<string> IngredientesNoVegetarianos = ["Peperoni 🍕", "Jamón 🍖", "Salmón 🐟"];
        
        int Opcion_Usuario;

        do {
        Console.Write("\n Opcion: ");
        Opcion_Usuario = int.Parse(Console.ReadLine()!)-1;

        switch (Opcion_Usuario)
        {
            case 0:
            SeleccionarIngrediente(IngredientesVegetarianos, "Vegetariano");
            break;

            case 1:
            SeleccionarIngrediente(IngredientesNoVegetarianos, "No vegetariano");
            break;

            default:
            Console.WriteLine("\n Este valor no esta entre las opciones disponibles, elige nuevamente.");
            break;
        }
        }while(Opcion_Usuario != 0 && Opcion_Usuario != 1);
    }


    // Metodo que se encarga de la seleccion del ingrediente extra y de mostrar la factura
    static void SeleccionarIngrediente(List<string> ingrediente, string tipoPizza)
    {
            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine(" A continuacion te mostraremos los ingredientes disponibles: ");

            // Presentamos todos los ingredientes extras que tenemos
            int contador = 1;
            foreach(string i in ingrediente)
            {
                Console.Write($" {contador++}- ");
                Console.WriteLine(i);
            }

            Console.Write("\n Elige por el ingrediente extra que deseas en la pizza: ");
            int IngredienteExtra = int.Parse(Console.ReadLine()!) - 1;
            Console.WriteLine("---------------------------------------------------------------\n");

            // Se usa el valor del usuario como índice para buscar el ingrediente en la lista
            string ingredienteSeleccionado = ingrediente[IngredienteExtra];

            Console.WriteLine("\n|-----------------------------------------------|");
            Console.WriteLine("                -- Factura --                  ");
            Console.WriteLine($"              Pizza {tipoPizza}             ");
            Console.WriteLine("  Ingredientes Base: Tomate y Mozzarella. 🍅🧀 ");
            Console.WriteLine($"         Ingrediente Extra: {ingredienteSeleccionado}           ");
            Console.WriteLine("|-----------------------------------------------|\n");
    }
}