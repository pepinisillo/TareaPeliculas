using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        private string titulo;
        private Int16 año;
        private String pais;
        private string director;

        //Constructores
  
        //Métodos

     //get
     public string GetTitulo(){return titulo;}
     public Int16 GetAño(){return año;}
     public string GetPais(){return pais;}
     public string GetDirector(){return director;}
     //set
     public void SetTitulo(string titulo){this.titulo = titulo;}
     public void SetAño(Int16 año){this.año = año;}
     public void SetPais(string pais){this.pais = pais;}
     public void SetDirector(string director){this.director = director;}
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
           // Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Promare");
            p1.SetAño(2019);
            //p1.set_pais("Japón");
            //p1.set_director("Hiroyuki Imaishi");
            //Console.WriteLine("{0}({1}){2}{3}", p1.GetTitulo(), p1.GetAño(), p1.SetPais(), p1.GetDirector());
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Method");
            p2.SetAño(2017);
            //p2.set_pais("Corea del Sur");
            //p2.set_director("Bang Eun-jin");
            //Console.WriteLine("{0}({1}){2}{3}", p2.GetTitulo(), p2.GetAño(), p2.GetPais(), p2.GetDirector());
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());

        }
    }
}

