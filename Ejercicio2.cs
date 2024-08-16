string usuario, contrasena;
bool comprobacion1, comprobacion2;
Console.WriteLine("------------------------------------------------");
for (int  i= 0;  i < 3;i ++)
{
    try
    {
        Console.WriteLine("Usuario:");
        usuario = Console.ReadLine();
        Console.WriteLine("Clave:");
        contrasena = Console.ReadLine();
        Console.WriteLine("------------------------------------------------");
        //string.IsNullOrWhiteSpace(usuario) evalua si el valor de usuario es nulo o espacio vacio
        //string.IsNullOrWhiteSpace(contrasena) evalua si el valor de clave es nulo o espacio vacio
        //si uno o ambos datos son nulos o espacios vacios entonces el programa genera un error.
        comprobacion1 = (string.IsNullOrWhiteSpace(usuario) | string.IsNullOrWhiteSpace(contrasena));
         if (comprobacion1 == false)
        {
            //usuario.Equals("PROGRA1") lee si lo que se ingreso en usuario es igual al usuario dado
            //contrasena.Equals("K0m1d4") lee si lo que se ingreson en contrasena es igual al usuario dado
            //si el siguiente IF se evalua como true entonces se ingresaron las credenciales correctas
            //en caso contrario da error.
            if (comprobacion2 = usuario.Equals("PROGRA1") && contrasena.Equals("K0m1d4"))
            {
                //Si las credenciales ingresadas son correctas se muestra este mensaje.
                 Console.WriteLine("Credenciales correctas. Adios!");
                 Console.WriteLine("------------------------------------------------");
                break;
            }
            else
            {
                 //Si las credenciales no son espacios en blanco y tampoco no son correctas se genera una excepcion
                 // la palabra throw significa lanzar, se lanza una excepcion para que el programa salte al catch.
                 throw new Exception();
            }
        }
         else
         {
            {
                //Si al menos se da el caso que uno de los valores para el usuario o contrasena son nulos o invalidos
                //entonces el programa tambien lanza una exepcion para poder pedir valores denuevo.
                 throw new Exception();
            }
          }

    }
    catch
    {
        Console.WriteLine("Error: Ha ingresado campos nulos o credenciales invalidas, intente de nuevo por favor.\nNota: Tiene 3 intentos. Ha usado " + (i+1) + " intento(s).\t");
        Console.WriteLine("------------------------------------------------");
    }
}
