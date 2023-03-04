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
    internal class Disco
    {
        public Button b;

        bool mousepresi;  // para mover el mouse y se vaya guardando la posicion cuando suelto el mouse;
        private int btnlocaX;
        private int btnlocaY;


        private int posicionbotnx; //alamacena la posicion del boton 
        private int posicionbotny;//por si acaso no se pueda colocar en la torre



        private int base1x, base2x, base3x, tamanioBase,basey; // para validar si pone en las pilas
       
        private int pilaenlaqueesta;
        private int pilaenlaqueestaba;

        public Pila pilaTorreA;
        public Pila pilaTorreB;
        public Pila pilaTorreC;

        public static int contador;//movimeintos

        
        public Disco(Pila A, Pila B, Pila C,int base1x,int base2x,int base3x,int basey, int tamanioBase)
        {
            pilaTorreA= A;  
            pilaTorreB= B;
            pilaTorreC= C;
            this.b = new Button();
            this.b.Width = 100;
            pilaTorreA.push(this.b);
            this.b.MouseDown += new MouseEventHandler(EventoMouseDown);// se activen los mouse aplastar
            this.b.MouseUp += new MouseEventHandler(EventoMouseUp); //se activa el mouse soltar
            this.b.MouseMove += new MouseEventHandler(EventoMouseMove);// se activa el mouse mover
            pilaenlaqueesta = 1;
            this.mousepresi = false;//avisa si el mouse esta presionado o no

            this.base1x = base1x;
            this.base2x = base2x;
            this.base3x = base3x;
            this.tamanioBase = tamanioBase;//para ver cuando acaba una pila
            this.basey = basey;
          
            
        }

        public void EventoMouseDown(object sender, MouseEventArgs e)
        {
            mousepresi = true;
            //para que se mueva el mouse ,eso del video
            btnlocaX = e.X;
            btnlocaY = e.Y;
            //Guarda la posicion de donde estaba por si acaso no se pueda colocar
            posicionbotnx = b.Left;
            posicionbotny = b.Top;
            // guarada en el atributo en la pila en la que se encontraba
            pilaenlaqueestaba = CalculaPilaendonde();
          

        }

        //suelto el mouse
        public void EventoMouseUp(object sender, MouseEventArgs e)
        { 
            //el mouse ya no esta presionado
            mousepresi = false;
            //veo en que pila esta 
            //0==no esta en nninguna;
            //1==pilaA;
            //2==pilaB
            MessageBox.Show("estaba en la pila :"+pilaenlaqueestaba);
            
            pilaenlaqueesta = CalculaPilaendonde();

            MessageBox.Show("estoy en la pila :"+Convert.ToString(pilaenlaqueesta));
            
            if (pushh() != true)//Si es que no se pudo lo coloco en la posicion en la que estaba; 
            {

                this.b.Left = posicionbotnx;
                this.b.Top = posicionbotny;
            }
            else
            {

                if (pilaenlaqueestaba != 0) //no es necesairo porque si hizo push es que si estaba en alguna pila
                {
                    contador++;//aumentando el movimiento
                        if (pilaenlaqueestaba == 1)
                        {

                            pilaTorreA.Pop();
                       
                            valer(pilaTorreA);//para habilitar el boton que queda al tope de la pila

                        }
                        else
                        {
                            if (pilaenlaqueestaba == 2)
                            {
                                pilaTorreB.Pop();
                                valer(pilaTorreB);
                            }
                            else
                            {
                          
                                pilaTorreC.Pop(); //eliminar el boton
                                                  //pilaTorreC.Valer();
                                valer(pilaTorreC);// habilitar el boton ultimo boton 
                           
                        }

                        }
                    MessageBox.Show("Movimeinto:" + contador);
                }
                }

            }
        
        public void EventoMouseMove(object sender, MouseEventArgs e)
        {

            if (mousepresi == true)
            {
            
               b.Left = e.X + b.Left - btnlocaX; 
               b.Top = e.Y + b.Top - btnlocaY;
            }
        }

        public void valer(Pila p) {

            if (p.Contador >= 1)
            {
                Button dprueba;
                dprueba = (Button)(p.peek());
                dprueba.Enabled = true;
            }

        }

        public bool pushh()
           
        {
            int tamaniodisco;
            tamaniodisco = this.b.Width;//largo del disco
            
            if (pilaenlaqueesta == 1)
            {
                if (pilaTorreA.IsEmpty() == true)//si la pila esta vacia pone nomas
                {

                    pilaTorreA.push(this.b);
                    this.b.Left = ((base1x +( tamanioBase / 2)) - (tamaniodisco / 2));//posicion correcta
                    this.b.Top = (basey- (pilaTorreA.Contador * 30));
                   
                    return true;
                }
                else
                {
                    //si esta con algo comprueba que el dato que vaya a poner no sea mas grande que el ultimo de esa pila
                    if (Convert.ToInt16(((Button)pilaTorreA.peek()).Text) > Convert.ToInt16(this.b.Text))
                    {
                       ((Button)(pilaTorreA.peek())).Enabled = false;//desabilita el boton de abajo
                        pilaTorreA.push(this.b);
                        this.b.Left = ((base1x + (tamanioBase / 2)) - (tamaniodisco / 2));
                        this.b.Top = (basey - (pilaTorreA.Contador * 30));
                        return true;


                    }
                    return false;
                    


                }



            }
            else
            {
                if (pilaenlaqueesta == 2)
                {
                    if (pilaTorreB.IsEmpty() == true)
                    {
                       pilaTorreB.push(this.b);

                        this.b.Left = ((base2x + (tamanioBase / 2)) - (tamaniodisco / 2));
                        this.b.Top = (basey - (pilaTorreB.Contador * 30));
                       
                        return true;
                    }
                    else
                    {

                        if (Convert.ToInt16(((Button)pilaTorreB.peek()).Text) > Convert.ToInt16(this.b.Text))
                        {
                           

                            ((Button)(pilaTorreB.peek())).Enabled = false;
                            pilaTorreB.push(this.b);
                          
                            this.b.Left = ((base2x + (tamanioBase / 2)) - (tamaniodisco / 2));
                            this.b.Top = (basey - (pilaTorreB.Contador * 30));
                            return true;

                        }
                        return false;


                    }
                  
                }
                else
                {
                    if (pilaenlaqueesta == 3)
                    {
                        if (pilaTorreC.IsEmpty() == true)
                        {
                            pilaTorreC.push(this.b);
                            this.b.Left = ((base3x + (tamanioBase / 2)) - (tamaniodisco / 2)); //posiciones
                            this.b.Top = (basey - (pilaTorreC.Contador * 30));
                            return true;
                        }
                        else
                        {
                            if (Convert.ToInt16(((Button)pilaTorreC.peek()).Text) > Convert.ToInt16(this.b.Text))
                            {
                                ((Button)(pilaTorreC.peek())).Enabled = false;
                                pilaTorreC.push(this.b);
                                this.b.Left = ((base3x + (tamanioBase / 2)) - (tamaniodisco / 2));
                                this.b.Top = (basey - (pilaTorreC.Contador * 30));
                                
                                return true;


                            }
                            return false;


                        }
                        
                    }
                }
                return false;

            }
        }

        public int CalculaPilaendonde()
        {

            int resp = 0; //en que pila se encunetra el boton
            int finbase1,finbase2,finbase3;
            finbase1 = base1x + tamanioBase; //calcular el rango de la pila1
            finbase2 = base2x + tamanioBase;
            finbase3 = base3x + tamanioBase;

            int lef, top; //para no llamar a la posicion del boton , le almaceno
            lef = b.Left;
            top = b.Top;
            //if (lef > base1x && lef < finbase1 && top < posfiny && top > posinicioy)
            if (lef > base1x && lef < finbase1)
            {
                resp = 1;
            }
            else
            {
                if (lef > base2x && lef < finbase2)
                {
                    resp = 2;
                }
                else
                {
                    if (lef >base3x && lef < finbase3)
                    {
                        resp = 3;
                    }

                }
            }
            return resp;
        }

     



   
       
    }
}
  
