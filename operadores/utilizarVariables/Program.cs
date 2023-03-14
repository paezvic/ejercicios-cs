// See https://aka.ms/new-console-template for more information

//esta parte del ejercicio es para describir el carro

Console.WriteLine("vamos a describir tu carro");
Console.WriteLine("ingresa el color de las puertas: ");
string puerta = Console.ReadLine();
Console.WriteLine("ingresa el tamaño de las ruedas: ");
int rueda = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingresa la marca del carro: ");
string marca = Console.ReadLine();

Console.WriteLine("el carro tiene las puertas de color: " + puerta);
Console.WriteLine("y las ruedas son de: " + rueda + " pulgadas de tamaño");
Console.WriteLine("y su marca es: " + marca);


// esta parte del ejercicio es para describir la mesa
Console.WriteLine("ahora vamos a describir tu mesa.");
Console.WriteLine("ingresa el peso de la mesa: ");
int peso = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingresa el largo de tu mesa: ");
float largo = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("ingresa el material de la mesa: ");
string material = Console.ReadLine();
Console.WriteLine("ingresa el color de la mesa: ");
string color = Console.ReadLine();

Console.WriteLine("la mesa pesa: " + peso + " kilos");
Console.WriteLine("y su largo es: " + largo + " centimetros");
Console.WriteLine("y su material es: " + material);
Console.WriteLine("y su color es: " + color);


//esta parte del ejercicio es para validar operadores logicos
Console.WriteLine("ingrese un numero:");
int num =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese un caracter:");
char a = Convert.ToChar(Console.ReadLine()) ;

Console.WriteLine("true si el numero es mayor o igual a 18: " + (num >= 18));
Console.WriteLine("true si el caracter es una a: " + (a == 'a'));
Console.WriteLine("true si el numero es mayor o igual a 18 y si el caracter es una a: " + (num >= 12 && a == 'a'));
Console.WriteLine("true si  una de las dos se cumple: " + (num >= 18 || a == 'a'));
