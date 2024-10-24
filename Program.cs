using Lista_Brindis;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lista lista = new lista();

            int opcion=0;

            while(opcion != 8)
            {
                Console.WriteLine("1.- Insertar Nodo");
                Console.WriteLine("2.- Imprimir Tamaño");
                Console.WriteLine("3.- Buscar Nodo");
                Console.WriteLine("4.- Borrar Nodo");
                Console.WriteLine("5.- Modificar Nodo");
                Console.WriteLine("6.- Buscar Valor");
                Console.WriteLine("7.- Imprimir Lista");
                Console.WriteLine("8.- Salir");
                opcion=Convert.ToInt32(Console.ReadLine()); 

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Usted eligió la opción 1");
                        Console.WriteLine("Dame valor del Nodo");
                        int num=Convert.ToInt32(Console.ReadLine());
                        lista.Add(num);
                        break;

                        case 2:
                        Console.WriteLine("Usted eligió la opción 2");
                        lista.count();
                        break; 

                    case 3:
                        Console.WriteLine("Usted eligió la opción 3");
                        Console.WriteLine("Dame posición");
                        int posi=Convert.ToInt32(Console.ReadLine());
                        lista.Find(posi);
                        break;

                        case 4:
                        Console.WriteLine("Usted eligió la opción 4");
                        Console.WriteLine("Dame la posición nodo");
                        int posicion=Convert.ToInt32(Console.ReadLine());
                        lista.Delete(posicion);
                        break;

                        case 5:
                        Console.WriteLine("Usted eligió la opción 5");
                        Console.WriteLine("Dame posición");
                        int pos=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el nuevo valor para nodo");
                        int nuevoValor = Convert.ToInt32(Console.ReadLine());
                        lista.Changer(pos,nuevoValor);
                        break;

                        case 6:
                        Console.WriteLine("Usted eligió la opción 6");
                        Console.WriteLine("Dame valor");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        lista.findValue(numero);
                        break;

                        case 7:
                        Console.WriteLine("Usted eligió la opción 7");

                        lista.Print();
                        break;

                        case 8:

                        break;

                    default:
                        Console.WriteLine("Opción Incorrecta");
                        break;
                }
            }
        }
    }
}