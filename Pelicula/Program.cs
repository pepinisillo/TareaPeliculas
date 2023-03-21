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
    public Pelicula()
        {
           
        }
    public Pelicula(string titulo, Int16 año)
        {
            this.titulo = titulo;
            this.año = año;
        }    

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

    //Métodos
    public void Imprime()
        {
           Console.WriteLine($"{titulo} ({año})");
        }
    public void ImprimeActores()
        {
            foreach (Actor actor in actores)
            {
                Console.WriteLine("{0} ({1})", actor.GetNombre(), actor.GetAño());
            }
        }
     public void AgregaActor(Actor actor)
        {
             actores.Add(actor);
        }
    }
    
    public class Actor
    {
        //Propiedades
    private string Nombre;
    private Int16 Año;

        //Constructores
    public Actor()
        {

        }
    public Actor(string Nombre, Int16 Año)
        {
            this.Nombre = Nombre;
            this.Año = Año;
        }

        //Métodos 
        public void Imprime()
        {
           Console.WriteLine($"{Nombre} ({Año})");
        }
    //get
    public string GetNombre(){return Nombre;}
    public Int16 GetAño(){return Año;}
    //set
    public void SetNombre(string Nombre){this.Nombre = Nombre;}
    public void SetAño(Int16 Año){this.Año = Año;}
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
            //actores
            Console.WriteLine("Actores de la película:");
            p1.AgregaActor(new Actor("Lio Fotia", 1999));
            p1.AgregaActor(new Actor("Galo Thymos", 1999));
            p1.ImprimeActores();

            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Method");
            p2.SetAño(2017);
            //p2.set_pais("Corea del Sur");
            //p2.set_director("Bang Eun-jin");
            //Console.WriteLine("{0}({1}){2}{3}", p2.GetTitulo(), p2.GetAño(), p2.GetPais(), p2.GetDirector());
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
             //actores
            Console.WriteLine("Actores de la película:");
            p2.AgregaActor(new Actor("Park Sung-woong", 1973));
            p2.AgregaActor(new Actor("Oh Seung-hoon", 1991));
            p2.ImprimeActores();

            //lista de películas
            //1.
            List<Pelicula> pelicula = new List<Pelicula>();
            pelicula.Add(new Pelicula("Sherk", 2001));
            pelicula.Add(new Pelicula("Sherk 2", 2004));
            pelicula.Add(new Pelicula("Sherk tercero", 2007));
            pelicula.Add(new Pelicula("Sherk Ogrorisa la Navidad", 2007));
            pelicula.Add(new Pelicula("Sherk para siempre", 2010));
            //2.
             foreach (Pelicula i in pelicula)
            {
                Console.WriteLine("{0} ({1})", i.GetTitulo(), i.GetAño());
            }
            
        }
    }
}

