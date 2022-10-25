using System.Reflection.Metadata;

class Program
{
    //    Gema Chamizo Fernández
    //    Enunciado Práctica:

    //1.1- Solicitar al usuario que introduzca una cadena de al menos 40 caracteres.
    //        Si la longitud de la cadena es menor de 40 caracteres, se mostrará un aviso al usuario, 
    //        informándole de la longitud actual, y solicitándole que vuelva a introducir una nueva cadena.
    //        Por ejemplo: "La cadena introducida posee únicamente XX caracteres. 
    //            Por favor, introduzca una nueva cadena con más de 40 caracteres: ".

    //1.2- Una vez tengamos la cadena con el tamaño mínimo deseado, aparecerá un menú para:

    //•Sustituir una palabra por otra.Para ello, se solicitará introducir, separadas por un espacio,
    //la palabra a sustituir, y la sustituta, mostrándose por pantalla el resultado final.

    //•Buscar texto en la cadena.Para ello, se solicitará introducir un texto para comprobar si existe o no.

    //•Buscar texto de inicio en la cadena.Para ello, se solicitará introducir un texto para comprobar
    //si la cadena comienza por el mismo.

    //1.3- Una vez haya terminado la acción seleccionada del menú, volvemos a solicitar una nueva cadena.



    static void Main(string[] args)
    {
        caracteres:
        Console.WriteLine("Por favor, introduzca una cadena de al menos 40 caracteres");
        string cadena = Console.ReadLine();
        int a = cadena.Length;

        if (a < 40)
        {
            Console.WriteLine($"La cadena introducida posee únicamente {a} caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres ");
        goto caracteres;
        }
        else
        {
            Console.WriteLine("Muy bien, todo correcto");
            opciones:
            Console.WriteLine("Ahora, tiene las siguientes opciones:");
            Console.WriteLine("1. Sustituir una palabra de la cadena por otra que usted desee");
            Console.WriteLine("2. Buscar texto en la cadena");
            Console.WriteLine("3. Buscar texto de inicio en la cadena");
            Console.WriteLine("¿Cuál elige?");
            string opcion = Console.ReadLine();
            int op = int.Parse(opcion);

            if (op == 1)
            {
            palabrita:
                Console.WriteLine("Ha escogido la opción 1. Escriba qué palabra desea sustituir.");
                string palabra = Console.ReadLine();
                bool b = cadena.Contains(palabra);

                if (b)
                { 
                    Console.WriteLine("¿Por qué palabra quiere cambiarla?");
                    string palabra2 = Console.ReadLine();
                    string cadena2 = cadena.Replace(palabra, palabra2);
                    Console.WriteLine($"Ahora su cadena es: {cadena2}");

                }

                else
                {
                    Console.WriteLine("Lo sentimos, no hemos podido encontrar esa palabra en su cadena.");
                    goto palabrita;

                }

            }
            else if (op == 2)
            { textito:
            Console.WriteLine("Escriba el texto que desee buscar.");
                string texto = Console.ReadLine();
                bool c = cadena.Contains(texto);

                if (c)
                {
                    Console.WriteLine("¡Enhorabuena! Ese texto se encuentra en la cadena.");
                }

                else 
                { 
                    Console.WriteLine("Lo sentimos, no hemos podido encontrar dicho texto.");
                    goto textito;
                }
            }
            else if (op == 3)
            { cadenita:
            Console.WriteLine("Escriba el texto inicial de la cadena.");
                string inicio = Console.ReadLine();
                int l = inicio.Length;
                string subcadena = cadena.Substring(0, l);

                if (inicio == subcadena)
                {
                    Console.WriteLine("Efectivamente, así empieza la cadena.");
                }

                else
                {
                    Console.WriteLine("¡Error! Hay algo que no coincide");
                    goto cadenita;
                }
            
            }
            else
            { 
                Console.WriteLine("Lo lamento, introduzca una opción válida");
                goto opciones;
            }

            Console.WriteLine("Comencemos de nuevo.");
            goto caracteres;

        }




    }
}
