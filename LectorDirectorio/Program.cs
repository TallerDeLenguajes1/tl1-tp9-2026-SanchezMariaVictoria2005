Console.WriteLine("Hello, World!");

string direccion;
bool validarDireccion = false;

do
{
    Console.WriteLine("ingrese la ruta del directorio");
    direccion = Console.ReadLine();

    if (Directory.Exists(direccion))
    {
        validarDireccion = true;
    }
}while(validarDireccion == false);
