// See https://aka.ms/new-console-template for more information
//ejercicio 1 escribir un programa que reciba nombre y lo imprima por pantalla
Console.WriteLine("introduce tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Hola "+ nombre);

//ejercicio dos escribir un ejercicio que reciba la hora y la muestre por pantalla
string datetime = DateTime.Now.ToString("hh:mm:ss tt");
Console.WriteLine(datetime);