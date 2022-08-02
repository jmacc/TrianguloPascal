// See https://aka.ms/new-console-template for more information
//
int pisos = 0;
int[] arreglo = new int[1];
//mostramos el mensaje
Console.WriteLine("Ingrese el numero de pisos");
pisos = Convert.ToInt32(Console.ReadLine());

//creacion del ciclo for recorriendo el primer dato ingresado

for (int i = 1; i <= pisos; i++)
{
    //tendra el tamañano del arreglo del for
    int[] pascal = new int[i];

    //ciclo para decrementar
    for (int j = pisos; j < i; j--)
    {
        Console.Write(" ");
    }

    //CICLO PARA GENERAR SUMAS
    for (int k = 0; k < i; k++)
    {
        //condicion del for
        if (k == 0 || k == (i - 1))
        {
            pascal[k] = 1;
        }
        else {
            pascal[k] = arreglo[k] + arreglo[k - 1];
        }
        Console.Write("[" + pascal[k] + "]");
    }
    arreglo = pascal;
    Console.WriteLine(" ");
}

Console.ReadLine();