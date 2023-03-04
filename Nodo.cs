using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresHanio
{
    internal class Nodo
    {
            private Object objtcontenido;
            private Nodo nodoAntes;
            private Nodo nodoFuera;

            public Nodo(Object objtcontenido, Nodo nodoAntes, Nodo nodoFuera)
            {
                this.objtcontenido = objtcontenido;
                this.nodoAntes = nodoAntes;
                this.nodoFuera = nodoFuera;
            }

            public Object getObjtcontenido()
            {
                return objtcontenido;
            }

            public void setObjtcontenido(Object objtcontenido)
            {
                this.objtcontenido = objtcontenido;
            }

            public Nodo getNodoAntes()
            {
                return nodoAntes;
            }

            public void setNodoAntes(Nodo nodoAntes)
            {
                this.nodoAntes = nodoAntes;
            }

            public Nodo getNodoFuera()
            {
                return nodoFuera;
            }

            public void setNodoFuera(Nodo nodoFuera)
            {
                this.nodoFuera = nodoFuera;
            }

        }


    }
