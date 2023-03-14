// See https://aka.ms/new-console-template for more information

//ejercicio 1: hacer una tabla de multiplicar

Console.WriteLine("Ingrese el numero a multiplicar:");
int numMultiplicar = Convert.ToInt32(Console.ReadLine());
int num = 1;
int result = 0;
while (num <= 10)
{
    result = numMultiplicar * num;
    Console.WriteLine($"{numMultiplicar} X {num} = {result}");
    num++;
    result = 0;
}

/* ejercicio 2Escribe un programa que realice estos pasos:
    Reciba al menos un número por consola
    Determine si el número es positivo o negativo
    Presente un contador para cada tipo (positivo y negativo).*/


Console.WriteLine("Ingrese la cantidad de numeros que desea ingresar:");
int numIngresar = Convert.ToInt32(Console.ReadLine());
int cont = 0;
int contpos = 0;
int contneg = 0;
int cont0 = 0;
do
{
    cont++;
    Console.WriteLine($"Ingrese por favor el numero {cont} :");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 != 0)
    {
        if (num1 < 0)
        {
            contneg++;
        }
        else
        {
            contpos++;
        }
    }
    else
    {
        cont0++;
    }
} while (cont <= numIngresar - 1);
Console.WriteLine($"ingreso {contpos} numeros positivos");
Console.WriteLine($"ingreso {contneg} numeros negativos");
Console.WriteLine($"ingreso {cont0} ceros");


/*ejercicio 3
 Dibuje en consola con un mismo caracter, por ejemplo *, 
 un rectángulo de las dimensiones introducidas y use el 
 tercer dato para discernir si el rectángulo está relleno 
 (tiene más * dentro) o no.
 En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
 */

Console.WriteLine("Ingrese el ancho:");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el alto:");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese 1 si desea el rectángulo relleno, 0 en caso contrario:");
bool relleno = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Ingrese el número de figuras que desea dibujar:");
int cantidadFiguras = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < cantidadFiguras; i++)
{
    if (ancho == alto)
    {
        //dibujar cuadrado   
        for (int j = 0; j < alto; j++)
        {
            for (int k = 0; k < alto; k++)
            {
                if (relleno || j == 0 || k == 0 || j == alto - 1 || k == alto - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    else
    {
        //dibujar rectangulo
        for (int j = 0; j < alto; j++)
        {
            for (int k = 0; k < ancho; k++)
            {
                if (relleno || j == 0 || k == 0 || j == alto - 1 || k == ancho - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}