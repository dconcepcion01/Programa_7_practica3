using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_7_practica3
{
    class Program
    {
        static void Main(string[] args)
        {

            //menu de opciones

            Console.WriteLine("SELECCIONE UNA LA OPCION DESEADA DIGITANDO EL NUMERO QUE LE ANTECEDE");

            Console.WriteLine("1. Convertir a grados  Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir a pesos");
            Console.WriteLine("3. Convertir a pies");
            Console.WriteLine("4. Salir");

            //validando opciones
            int opcionseleccionada = Convert.ToInt32(Console.ReadLine());

            if (opcionseleccionada  !=1)
            {
                if (opcionseleccionada != 2)
                {
                    if (opcionseleccionada != 3)
                    {
                        
                    Console.WriteLine("Opcion incorrecta...");
                        Console.ReadKey();

                        return;
                        
                    }
                    
                }


            }
            //funciones
            switch (opcionseleccionada )
            {
                case 1:

                    grado();
                    break;
                    


                case 2:
                    moneda();
                    break;
                   




                case 3:
                    medida();
                    break;

                              
                           
            }


        }
        static void grado()
        {
            double celsius = 0, fahre = 0;

            Console.WriteLine("Digite los grados Celsius que desea convertir");
            celsius = Convert.ToDouble(Console.ReadLine());

            

            fahre = (celsius * 9) / 5 + 32;

            Console.WriteLine("El Resultado es " + fahre);

            Console.ReadLine();
        }

        static void moneda()
        {
            double  taza=0, dolar=0, peso=0;

            Console.WriteLine("Digite taza del dolar");
            taza = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la cantidad de dolar que desea cambiar");
            dolar = Convert.ToDouble(Console.ReadLine());

            peso = dolar * taza;

            Console.WriteLine("El total del cambio es :$ " + peso);

            Console.ReadLine();

        }

        static void medida()
        {
            double metro=0, pies=0;

            Console.WriteLine("Digite la cantidad de metro que desea convertir a pies");
            metro = Convert.ToDouble(Console.ReadLine());

            pies = metro * 3.28084;

            Console.WriteLine("La cantidad de pies es...."+ pies );
            Console.ReadLine();
        }
        
     
    }
}
