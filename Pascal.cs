namespace Csharp{
    class Pascal{
        static void Main(string[] args){
            int tamaño = 0;
            int[] arreglo = new int[1];
            // Mostramos un mensaje y pedimos datos
            Console.WriteLine("Ingrese el numero de pisos");
            tamaño = Convert.ToInt16(Console.ReadLine());
            // Declaramos el primer ciclo for que va a recorrer los datos ingresados que se almacenaron en la variable pascal
            for (int i = 1; i <= tamaño; i++)
            {
                // Colocamos un arreglo, ponemos la variable i del ciclo el cual sera el tamaño que tendra el arreglo cada vez que se ejecute el ciclo
                int[]pascal = new int[i];
                // Ciclo para decrementar para formar el triangulo 
                for (int j = tamaño; j < i; j--)
                {
                    Console.Write(" ");
                }
                // Ciclo para generar la suma de las cifras
                for (int k = 0; k < i; k++)
                {
                    // Condicion que evalua la variable del ciclo
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        // Sumamos los numeros que estan en cada posicion
                        // del arreglo para formar el triangulo
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write("["+ pascal[k] +"]");
                }
                arreglo = pascal;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    
}

