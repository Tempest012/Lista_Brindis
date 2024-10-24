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

        public int count(int n=0)
        {
            nodo act;
            act= inicio;
            

            if (act == null)
            {
                Console.WriteLine("La lista esta vacía");
                Console.WriteLine(n);
                return 0;
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
                return n;
            }
           
        }

        public int Find(int posi)
        {
            nodo act;
            act = inicio;
            int i = 1;
            if (act==null)
            {
                Console.WriteLine("La lista esta vacía");
                return -1;
            }
            else
            {
                while (act != null && i < posi)
                {
                    act = act.Sig;
                    i++;
                }
                if (act == null)
                {
                    Console.WriteLine($"No hay nodo en la posición {posi}");
                    return -1;
                }
                else
                {
                    Console.WriteLine($"El valor es {act.Valor}");
                    return act.Valor;
                }
            }
           
            
        }

        public int findValue(int numero)
        {
            nodo act;
            act = inicio;
            int i = 1;

            if (act == null)
            {
                Console.WriteLine("La lista esta vacía");
                return 0;
            }
            else
            {

                while (act != null && act.Valor!=numero)
                {
                    act = act.Sig;
                    i++;
                }
                if(act == null)
                {
                    Console.WriteLine("No encontrado");
                    return -1;
                }
                else
                {
                    Console.WriteLine($"El valor esta en la posición {i}");
                }
                return i;
            }
        }
        public bool Delete(int posicion)
        {
            nodo act;
            act = inicio;
            nodo ant;
            ant = null;
            int i = 1;

            if (act == null)
            {
                Console.WriteLine("La lista esta vacía");
                return false;
            }
            else if (posicion==1)
            {
                inicio = inicio.Sig;
                Console.WriteLine("Nodo eliminado");
                return true;
            }
            else
            {
                while(act != null && i<posicion)
                {
                    ant = act;
                    act = act.Sig;
                    i++;
                }
                if(act == null)
                {
                    Console.WriteLine("Nodo no eliminado");
                    return false;
                }
                else
                {
                    ant.Sig = act.Sig;
                    Console.WriteLine("Nodo eliminado");
                    return true;
                }
            }
        }

        public bool Changer(int pos, int nuevoValor)
        {
            nodo act;
            act= inicio;
            int i = 1;
            
            
            if(act == null)
            {
                Console.WriteLine("La lista esta vacía");
                return false;
            }
            else
            {
                while (act != null && i < pos)
                {
                    act = act.Sig;
                    i++;
                }
                if (act == null)
                {
                    Console.WriteLine("No se modifico");
                    return false;
                }
                else
                {
                    

                    act.Valor = nuevoValor;
                    Console.WriteLine("Nodo Modificado exitosamente");

                    return true;
                }
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
                    Console.WriteLine($"[{act.Valor}]");
                    act=act.Sig;
                }
            }
        }

    }
}
