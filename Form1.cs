using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace TorresHanio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int NumMinMov = 0;
        Pila pilaTorreA;
        Pila pilaTorreB;
        Pila pilaTorreC;
        int NumDiscos;

        int tambase = 150;
        int z = 300;
        int posx = 100;
        int posy = 350;
        int[] posicionesbase = new int[3];
        Disco[] ArregloDiscos;



        private void btnJugar_Click(object sender, EventArgs e)
        {
            //obtener el valor del numero de discos
            NumDiscos = Convert.ToInt16(txtTamaño.Text);


            if (ArregloDiscos == null && NumDiscos > 0 && NumDiscos <= 10)//para que no se creen uno encima de otro , primero debe reiniciar
            {


                tambase = 150;
                z = 300;
                posx = 100;
                posy = 400;



                //Formato a las torres (bases y palos)

                for (int i = 0; i < 3; i++)
                {

                    Button basse, altura;

                    basse = new Button();
                    basse.Width = tambase;
                    basse.Height = 10;
                    basse.Left = posx;
                    basse.Top = posy;
                    basse.BackColor = Color.Black;
                    basse.Enabled = false;

                    altura = new Button();
                    altura.Height = z;
                    altura.Width = 10;
                    altura.Left = posx - 2 + (tambase / 2); //posx-2 es porque con posx quedaba una mitad mas grande
                    altura.Top = posy - (z - 2);//-2 para que no quede espacio en blaco
                    altura.BackColor = Color.Black;
                    altura.Enabled = false;//no puedan 

                    Controls.Add(basse);
                    Controls.Add(altura);
                    posx = posx + tambase + 150;  //para la siguiente base
                    posicionesbase[i] = basse.Left; // guardo el punto x de las bases 


                }

                //Calcular numero de movimientos objetivo
                NumMinMov = (int)Math.Pow(2, NumDiscos) - 1;
                lblNmin.Text = Convert.ToString(NumMinMov);
                //para el nuemro que contendran lso discos
                int cont;
                cont = NumDiscos;
                //crear las pilas 
                pilaTorreA = new Pila();
                pilaTorreB = new Pila();
                pilaTorreC = new Pila();
                //  Crear arreglo de discos

                Disco daux;
                ArregloDiscos = new Disco[NumDiscos];

                //para poner el color con numeros aletorio
                Random r;
                r = new Random();

                //inicia en 1 por la posicion en als que se coloca los botones inicio en 1 porque quiero el primer disco tenga -10
                for (int i = 1; i <= NumDiscos; i++)
                {
                    //creo un nuevo disco con todos los parametros 
                    daux = new Disco(pilaTorreA, pilaTorreB, pilaTorreC, posicionesbase[0], posicionesbase[1], posicionesbase[2], posy, tambase);
                    //guardo en la posicion correspondiente
                    ArregloDiscos[i - 1] = daux;

                    //desabilitar los botones que no sean el primero
                    if (cont != 1)
                    {
                        daux.b.Enabled = false;
                    }

                    //modificar el largo e irlo decrementando en cada disco
                    daux.b.Width = tambase - (i * 10);


                    daux.b.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                    //posicionarlo
                    daux.b.Top = (posy) - ((i) * 30);
                    daux.b.Left = posicionesbase[0] + (5 * i);//solo se crea ne torreA
                    daux.b.Text = Convert.ToString(cont);
                    // Anadirlo al form
                    Controls.Add(daux.b);
                    //para qeu se pongan al frnet del otro boton de la altura
                    daux.b.BringToFront();

                    cont--;



                }
            }
            else
            {
                MessageBox.Show("Error :\n" + "1.-Para un nuevo juego seleccione reiniciar\n" + "2.-Revise la cantidad de discos");
            }




        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Disco.contador = 0;
            pilaTorreA.Clean();
            pilaTorreB.Clean();
            pilaTorreC.Clean();
            if (ArregloDiscos != null) //para que no reinicio muchas veces
            {
                

                //limpia las torres y el numero de movimietos
                for (int i = 0; i < NumDiscos; i++)
                {

                    ArregloDiscos[i].b.Dispose();//para eliminar ?
                    (ArregloDiscos[i]) = null;
                }
                ArregloDiscos = null;
                NumDiscos = 0;
            }

        }




        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (pilaTorreC.Contador == NumDiscos && Disco.contador >= NumMinMov)
            {
                MessageBox.Show("FELICIDADES:\n" + "Relleno exitoso");
            }
            else
            {
                MessageBox.Show("Mala suerte:\n" + "Todos los discos no se encuentran en la torre 3");
            }

            //if (pilaTorreC.Contador == NumDiscos)
            //{
            //    bool correcto;
            //     correcto = true;
            //     Nodo nodoaux = pilaTorreC.NODOFIN;
            //     Button baux1,baux2;

            //    for (int i = 0; i < pilaTorreC.Contador - 1; i++)
            //     {
            //          baux1 = (Button)nodoaux.getObjtcontenido();
            //         baux2 = (Button)nodoaux.getNodoAntes().getObjtcontenido();
            //          if (Convert.ToInt16(baux1.Text) > (Convert.ToInt16(baux2.Text)))
            //          {

            //              correcto = false;
            //              i = pilaTorreC.Contador;
            //              Console.WriteLine("ya esta mal");
            //          }
            //          nodoaux = nodoaux.getNodoAntes();
            //      }
            //      if (correcto == true)
            //      {
            //          MessageBox.Show("RELLENO EXITOSO");
            //      }
            //      else
            //      {
            //          MessageBox.Show("Pila MAL LLENADA");
            //      }

            //  }
            //  else
            //  {
            //      MessageBox.Show("Torre C no llena");
            //  }
        }

        //Para recursividad y saber a que pila del arreglo pila va 
        private int NumeroBase(Pila p)
        {
            int baseee;
            if (p == pilaTorreA)
            {
                baseee = 0;
            }
            else
            {
                if (p == pilaTorreB)
                {
                    baseee = 1;
                }
                else
                {
                    baseee = 2;
                }


            }
            return baseee;
        }


        private void hanoi(int n, Pila origen, Pila auxiliar, Pila destino)
        {

            if (n > 0)
            {
                hanoi(n - 1, origen, destino, auxiliar);
                destino.push(origen.Pop());

                Movimientp(NumDiscos - n, posicionesbase[NumeroBase(destino)], destino);

                hanoi(n - 1, auxiliar, origen, destino);

            }
        }


        //numero  de disco,base a la que va y la pila a la que va
        private void Movimientp(int n, int basse1, Pila p)
        {
            ArregloDiscos[n].b.Left = ((basse1 + (tambase / 2)) - (ArregloDiscos[n].b.Width / 2));
            ArregloDiscos[n].b.Top = (posy - (p.Contador * 30));
            Disco.contador++;
            this.Refresh();
            Thread.Sleep((tiempo * 200));
            this.Refresh();
        }

        private void btnSolucion_Click(object sender, EventArgs e)

        {
            if (pilaTorreA != null) //por siacaso antes de jugar me ponga solucion
            {
                if (pilaTorreA.Contador != NumDiscos)
                {
                    MessageBox.Show("Todos los discos deben estar en la pila 1");
                }
                else
                {
                    if (pilaTorreA.Contador != 0)
                    {
                        hanoi(NumDiscos, pilaTorreA, pilaTorreB, pilaTorreC);
                        MessageBox.Show("PILA1: " + pilaTorreA.Contador + "PILA: " + pilaTorreB.Contador + "PILA3 :" + pilaTorreC.Contador);
                        //    lblNmovimientos.Text = "" + ContNumMov;
                    }
                    else
                    {
                        MessageBox.Show("PIla sin discos");
                    }
                }
            }
        }
        int tiempo = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {





        }
        //mueve esa flevhita
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tiempo = trackBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
