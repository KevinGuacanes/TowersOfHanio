using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorresHanio
{
    internal class Pila
    {

        private int cont;
        private Nodo nodoInicio;
        private Nodo nodoFin;

        public static int conta = 0;

        public Pila()
        {
            cont = 0;
            nodoFin = null;
            nodoInicio = null;
            Console.WriteLine("pila creada" + conta);
            conta++;
        }

        public bool push(Object obj)
        {

            if (cont == 0)
            {
                nodoInicio = new Nodo(obj, null, null);
                nodoFin = nodoInicio;
                cont++;
                Console.WriteLine("esta vacia pila");
                return true;
            }
            else
            {
                Nodo aux;
                aux = nodoFin;
                nodoFin = new Nodo(obj, aux, null);
                aux.setNodoFuera(nodoFin);
                cont++;

                return true;
            }
        }

        public Object Pop()
        {
            Object devuelve;
            devuelve = null;
            if (cont != 0)
            {
                devuelve = nodoFin.getObjtcontenido();
                nodoFin.setObjtcontenido(null);
                if (cont != 1)
                {
                    Nodo aux;
                    aux = nodoFin.getNodoAntes();
                    nodoFin.setNodoAntes(null);
                    nodoFin = aux;

                    nodoFin.setNodoFuera(null);
                }
                else
                {
                    nodoFin = null;
                    nodoInicio = null;
                }
                cont--;

            }
            else
            {
                Console.WriteLine("pila vacia");
            }
            return devuelve;

        }

        public void Imprimir()
        {

            if (cont != 0)
            {
                Nodo nodoaux = nodoInicio;

                for (int i = 0; i < cont; i++)
                {

                    Console.WriteLine(nodoaux.getObjtcontenido());
                    nodoaux = nodoaux.getNodoFuera();
                    //nodoaux = nodoaux.NODODENTRO;
                }
            }
            else
            {
                Console.WriteLine("PILA VACIAAA");
            }

        }



        public Nodo NODOINICIO
        {
            set
            {
                this.nodoInicio = value;
            }
            get
            {
                return this.nodoInicio;
            }
        }
        public Nodo NODOFIN
        {
            set
            {
                this.nodoFin = value;
            }
            get
            {
                return nodoFin;
            }
        }

        public int Contador
        {
            get
            {
                return cont;
            }
            set
            {
                cont = value;
            }
        }


        public Object peek()
        {


            Object resp;
            resp = null;
            if (IsEmpty() == false)
            {
                resp = nodoFin.getObjtcontenido();
            }
            return resp;
        }

        public bool IsEmpty()
        {
            if (cont == 0)
            {
                return true;
            }
            else { return false; }
        }
        public int tamanio()
        {
            return cont;
        }

        public void Clean()
        {

            while (this.cont >= 0 && this.cont != 0)
            {
                Pop();

            }

        }





        //Habilita el boton 
        public void Valer()
        {
            if (cont >= 1)
            {
                Button dprueba;
                dprueba = (Button)(this.peek());
                dprueba.Enabled = true;
            }

        }





    }

}
