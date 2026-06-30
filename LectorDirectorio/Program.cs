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

        if (directorios.Length > 0) //funcionando
        {
            Console.WriteLine("LISTADO DE DIRECTORIOS");
             foreach (var directorio in directorios) //listo los subdirectorios
            {
                Console.WriteLine(Path.GetFileName(directorio));
            }
        }
        else
        {
            Console.WriteLine("no hay directorios");//funcionando
        }

        if (archivos.Length > 0)
        {
            Console.WriteLine("LISTADO DE ARCHIVOS");
            foreach (var archivo in archivos)//listo los archivos
            {
                var info = new FileInfo(archivo) ;
                var tama = info.Length/1024;

                Console.WriteLine($"nombre:{Path.GetFileName(archivo)} tamaño: {tama} KB");
            }
        }
        else
        {
            Console.WriteLine("no hay archivos");
        } 
       
       string nuevaRuta = "reporte_archivos.csv";

       using(var stream = new StreamWriter(nuevaRuta))
        {
            string nombre;
            stream.WriteLine("Archivo, Tamaño en KB, Fecha de ultima modificación");
            foreach(var archivo in archivos)
            {
                nombre = Path.GetFileNameWithoutExtension(archivo);
                var info = new FileInfo(archivo);
                var tama = info.Length / 1024;
                var ultimaFecha = info.LastWriteTime;
                stream.WriteLine($"{nombre},{tama},{ultimaFecha}");
            }

        }
    }
    else
    {
        Console.WriteLine("la ruta ingresada no es valida");
    }
}while(validarDireccion == false); //funciona
