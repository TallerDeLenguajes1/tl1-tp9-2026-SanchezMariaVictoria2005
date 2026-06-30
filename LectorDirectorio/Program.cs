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
        var directorios = Directory.GetDirectories(direccion);//obtengo todos los subdirectorios
        var archivos = Directory.GetFiles(direccion); //obtengo todos los archivos de ese directorio
    }
    else
    {
        Console.WriteLine("la ruta ingresada no es valida");
    }
}while(validarDireccion == false);
