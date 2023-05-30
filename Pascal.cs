using System;

namespace Csharp{
    class Pascal{
    static void Main(string[] args){
            // Se declaran dos variables enteras: pisos y arreglo. pisos se utilizará para almacenar el tamaño del triángulo ingresado por el usuario, y arreglo se utiliza para almacenar los números generados en cada iteración del bucle.
            int pisos = 0;
            int[]arreglo = new int[1];
            // Se muestra un mensaje en la consola para que el usuario ingrese el tamaño del triángulo de Pascal
            Console.WriteLine("Ingrese el tamaño del triangulo pascal");
            // Se lee la entrada del usuario y se convierte a un número entero. El resultado se almacena en la variable pisos.
            pisos = Convert.ToInt16(Console.ReadLine());
            // Se inicia un bucle for que se ejecutará desde i = 1 hasta i <= pisos. Este bucle controla la generación de cada fila del triángulo.
            for (int i = 1; i <= pisos; i++)
            {
                // Dentro del bucle, se declara un nuevo arreglo pascal de enteros con un tamaño i. Este arreglo se utilizará para almacenar los números generados en cada fila del triángulo.
                int[]pascal = new int[i];
                // Se inicia otro bucle for que se ejecuta desde j = pisos hasta que j < i. Este bucle imprime espacios en blanco para darle forma al triángulo.
                for (int j = pisos; j < i; j--)
                {
                    Console.Write(" ");
                }
                // Después del bucle de espacios en blanco, se inicia otro bucle for que se ejecuta desde k = 0 hasta k < i. Este bucle genera los números de cada fila del triángulo.
                for (int k = 0; k < i; k++)
                {
                    // Dentro del bucle for, se verifica si k es igual a 0 o igual a i - 1. Si es así, se asigna el valor 1 a pascal[k], ya que estos números siempre serán 1 en el triángulo de Pascal
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }else{
                        // Si k no es igual a 0 ni igual a i - 1, se calcula el valor sumando los números en las posiciones correspondientes del arreglo arreglo. Esto se hace mediante la expresión pascal[k] = arreglo[k] + arreglo[k - 1];.
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    // Después de calcular el número, se imprime entre corchetes [ y ] el valor de pascal[k].
                    Console.Write("["+ pascal[k] +"]");
                }
                // Se asigna el arreglo pascal a arreglo, para que en la próxima iteración del bucle, los números generados se utilicen como base para calcular los siguientes números.
                arreglo = pascal;
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}

