using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
          
  
                // 1. un programa que pida al usuario 4 numeros, los memorice ( utilizando un array), calcule su 
                // su media aritmetica y despues muestre en pantalla la media y los datos tecleados.

                int[] nu = new int[4];

                Console.WriteLine(" ingrese los numeros para calcular la media aritmetica \n");

                for (int i = 0; i < nu.Length; i++)
                {

                    nu[i] = Convert.ToByte(Console.ReadLine());



                }

                int media = (nu.Sum()) / 4;

                Console.WriteLine(" la media aritmetica es: " + media);







                // 2. un programa que pida al usuario 5 numeros reales ( pista: necesitamos un array de "float" )
                // y luego los muestre en el orden contrario al que se introdujeron.


                float[] contrario = new float[5];


                Console.WriteLine(" ingrese los numero");

                for (int i = 0; i < contrario.Length; i++)
                {
                    contrario[i] = Convert.ToInt32(Console.ReadLine());

                }


                for (int j = 4; j >= 0; j--)
                {
                    Console.WriteLine(contrario[j]);
                }





                // 3 un programa que almacene en un array el numero de dia que tiene cada mes (ssupondremos que es un 
                // año no bisiesto) y pida al usuario el numero del mes y muestre en pantalla el numero de dia de ese mes




                int[] meses = new int[13];
                meses[1] = 31;
                meses[2] = 28;
                meses[3] = 31;
                meses[4] = 30;
                meses[5] = 31;
                meses[6] = 30;
                meses[7] = 31;
                meses[8] = 31;
                meses[9] = 30;
                meses[10] = 31;
                meses[11] = 30;
                meses[12] = 31;

                Console.WriteLine(" ingrese el numero que pertenece al Mes ");
                int mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(meses[mes] + "dias");


                Console.Read();




                // 4. un programa que pida al usuario 10 numeros y luego calcule y muestre cual es el mayor de todos 


                float[] numero = new float[10];
                float mayor = 0;



                for (int i = 0; i < numero.Length; i++)
                {

                    Console.WriteLine("ingrese los numeros");
                    numero[i] = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine(" no has introducido un valor numerico");



                }
                for (int i = 0; i < numero.Length; i++)
                {
                    if (numero[i] > mayor)
                    {
                        mayor = numero[i];
                    }


                }

                Console.WriteLine($" \n el numero mayor es: {mayor} ");






                // 5. un programa que prepare espacio para un maximo de 100 nombres .  el el usuario debera introducir un 
                // nombre cada vez, hasta que se pulse intro momento sin teclear nada, moemento en el que dejara 
                // de pedir nombre y se mostrara en pantalla la lista de los nombres que se han introducidos


                string[] nom = new string[100];

                for (int i = 0; i < nom.Length; i++)
                {
                    Console.WriteLine(" ingrese un nombre para guardar en el arreglo " + (i + 1));
                    nom[i] = Console.ReadLine();

                    if (nom[i] == "")
                    {
                        break;
                    }

                }
                Console.WriteLine("los nombres que ingresaste son: ");

                for (int i = 0; i < nom.Length; i++)
                {
                    Console.WriteLine(nom[i]);
                }

            }
        }
    }
