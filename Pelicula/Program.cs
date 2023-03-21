using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        public string titulo;
        public Int16 año;
        public String pais;
        public string director;

        //Constructores
      
      public Pelicula()
      {

      }
        //Métodos
     
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            //Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.titulo = ("Promare");
            p1.año = (2019);
            p1.Imprime();
            Pelicula p2 = new Pelicula();
            p2.titulo = ("Method");
            p2.año = (2017);
            p2.Imprime();
        }
    }
}
