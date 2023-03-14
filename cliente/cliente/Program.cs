// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese su nombre comleto");
string nombre = Console.ReadLine();
Console.WriteLine("ingrese su numero telefonico");
int num = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("ingrese su direccion");
string dir = Console.ReadLine();
Console.WriteLine("ingrese su email:");
string email = Console.ReadLine();
Console.WriteLine("es nuevo cliente si o no");
string nuevo = Console.ReadLine();

cliente nuevoCliente = new cliente(nombre,num,dir,email,nuevo);
Console.WriteLine(nuevoCliente);

public struct cliente
{
    public cliente(string nombreCompleto, int telefono, string direccion, string email, String nuevo)
    {
        NombreCompleto = nombreCompleto;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        Nuevo = nuevo;
    }

    public string NombreCompleto { get; set; }
    public int Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public string Nuevo { get; set; }

    public override string ToString() => $" su nombre es {NombreCompleto} " +
                                         $"\n su telefono es {Telefono} " +
                                         $"\n su direccion es {Direccion} " +
                                         $"\n su email es {Email}" +
                                         $"\n es cliente nuevo {Nuevo} ";
    
}