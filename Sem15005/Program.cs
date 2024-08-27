using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem15005
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lista ls = new Lista();
            int op = 0;
            ls.insertar(10);
            ls.insertar(2);
            ls.insertar(19);
            ls.insertar(4);
            ls.insertar(12);
            ls.insertar(11);
            while (op != 4)
            {
                Console.Clear();
                Console.WriteLine("------MENÚ------");
                Console.WriteLine("[1]Mostrar lista");
                Console.WriteLine("[2]Insertar elemento");
                Console.WriteLine("[3]Buscar elemento");
                Console.WriteLine("[4]Salir");
                Console.WriteLine("----------------");
                Console.Write("Ingresar opción: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("------LISTA------");
                        ls.mostrar();
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Presionar botón para volver");
                        Console.ReadKey();
                        

                        break;
                    case 2:
                        Console.WriteLine("-----AGREGAR-----");
                        Console.WriteLine("Agregar número: ");
                        int nunum = int.Parse(Console.ReadLine());
                        ls.insertar(nunum);
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Presionar botón para volver");
                        Console.ReadKey();
                        
                        break;
                    case 3:
                        Console.WriteLine("-----BUSCAR-----");
                        Console.Write("Buscar número:");
                        int buscar = int.Parse(Console.ReadLine());
                        ls.buscar(buscar);
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Presionar botón para volver");
                        Console.ReadKey();
                        break;
                }
            }



















            
           
            
            




        } 
    }
}
