using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem15005
{
   public class Lista
    {
        public Nodo primero = null;
        public void insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = num;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temp = primero;
                while (temp.sig  != null )
                {
                    temp = temp.sig; 
                }
                temp.sig = nuevo;
            }
        }
        public void mostrar()
        {
            Nodo temp = primero;
            while (temp!= null)
            {
                Console.Write(temp.dato);
                if (temp.sig != null)
                {
                    Console.Write("->");
                }
                        
               
                temp = temp.sig;
            }

            Console.WriteLine(" ");

        }
        public void buscar(int busc)
        {
            Nodo temp = primero;
            int cont = 0;
            int espacio = 0;
            while (temp!=null)
            {
                espacio++;
                if (temp.dato == busc)
                {
                    Console.WriteLine("Elemento encontrado en espacio:"+espacio);
                    cont = 1;
                }
                
                temp = temp.sig;
            }
            if (cont == 0)
            {
                Console.WriteLine("Elemento no encontrado");
            }
        }
    } 
}
