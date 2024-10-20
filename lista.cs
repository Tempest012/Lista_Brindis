using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Brindis
{
    internal class lista
    {
        private nodo inicio;

        public lista()
        {
            inicio = null;
        }

        public void Add(int num)
        {
            nodo nuevo = new nodo(num);

            if (inicio == null)
            {
                inicio= nuevo;
            }
            else
            {
                nodo act=inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig=nuevo;
            }
        }

        public void count(int n=0)
        {
            nodo act;
            act= inicio;
            

            if (act == null)
            {
                Console.WriteLine("La lista esta vacía");
                Console.WriteLine(n);
            }
            else
            {
                n++;
                while(act.Sig != null)
                {
                    act= act.Sig;
                    
                    n++;
                }
                Console.WriteLine($"La lista tiene {n} nodo"); 
            }
           
        }

        public void Find(int posi)
        {
            nodo act;
            act = inicio;
            int i = 1;
            if (act==null)
            {
                Console.WriteLine("La lista esta vacía");
            }
            while (act != null && i < posi)
            {
                act=act.Sig;
                i++;
            }
            if(act==null)
            {
                Console.WriteLine($"No hay nodo en la posición {posi}");
            }
            else
            {
                Console.WriteLine($"El valor es {act.Valor}");
            }
            
        }

        public void findValue(int numero)
        {
            nodo act;
            act = inicio;
            int i = 0;
            bool encontrado = false;

            if (act == null)
            {
                Console.WriteLine("La lista esta vacía");
            }
            else
            {

                while (act != null && encontrado != true)
                {

                    i++;
                    if (act.Valor == numero)
                    {

                        Console.WriteLine($"La posición es {i}");
                        encontrado = true;
                    }
                   
                    act = act.Sig;
                }
            }
        }

        public void Changer(int pos)
        {
            nodo act;
            act= inicio;
            int i = 1;
            int nuevoValor;
            
            if(act == null)
            {
                Console.WriteLine("La lista esta vacía");
            }
            while (act != null && i < pos)
            {
                act = act.Sig;
                i++;
            }
            if (act == null)
            {
                Console.WriteLine($"No hay nodo en la posición {pos}");
            }
            else
            {
                Console.WriteLine("Ingrese el nuevo valor para nodo");
                nuevoValor=Convert.ToInt32(Console.ReadLine());

                act.Valor = nuevoValor;
                Console.WriteLine($"El valor del nodo en la posición {pos} ha sido modificado a: {nuevoValor}");

            }

        }
        public void Print()
        {
            nodo act;
            act=inicio;

            if(act == null)
            {
                Console.WriteLine("La lista esta vacía");
            }
            else
            {
                while(act!=null)
                {
                    Console.WriteLine($"{act.Valor}");
                    act=act.Sig;
                }
            }
        }

    }
}
