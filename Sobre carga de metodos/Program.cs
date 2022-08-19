using System;

namespace Sobre_carga_de_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable para recibir desde "Concatenar"
            string nombreYApellido;

            //Instancia
            Nombres nombres = new Nombres();

            nombreYApellido = nombres.Concatenar("Leticia", "Guzmán", "Valdez");
            Random random = new Random();
            //Mostrando las cadenas concatenadas
            Console.WriteLine(random.Next(10, 20));
        }
    }
    class Nombres
    {
        //Método
        public string Concatenar(string nombrePa, string apellidoPa)
        {
            string nombreApellido;
            nombreApellido = nombrePa + " " + apellidoPa;
            return nombreApellido;
        }

        //Sobrecarga del metodo concatenar
        public string Concatenar(string nombrePa, string apellidoPa, string segundoApellidoPa)
        {
            string nombreApellido;
            nombreApellido = nombrePa + " " + apellidoPa+ " "+ segundoApellidoPa;
            return nombreApellido;
        }
    }
}
