// See https://aka.ms/new-console-template for more information

Console.WriteLine("ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("ingresa tu apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("ingresa tu edad");
int edad = Convert.ToInt32( Console.ReadLine() );

Console.Write(nombre + " " + apellido + " de " + edad + " años" );
Console.WriteLine(" sabe programar");
