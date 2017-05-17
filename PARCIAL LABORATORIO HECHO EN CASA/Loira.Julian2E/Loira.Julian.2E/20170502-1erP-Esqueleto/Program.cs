using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace _20170502_1erP_Esqueleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo e = new Grupo("Río");
            string datosEquipo = "";
            // Instancio 6 elementos
            Perro obj1 = new Perro("Moro", "Pitbull");
            Perro obj2 = new Perro("Julio", "Cruza", 13, false);
            Mascota obj3 = new Perro("Ramón", "Salchicha", 2, true);
            Gato obj4 = new Gato("José", "Angora");
            Mascota obj5 = new Gato("Hernán", "Cruza");
            Mascota obj6 = new Gato("Fer", "Siames");
            //obj2.Ficha();
            //Console.WriteLine("Nombre: {0} y raza: {1}", obj1.Nombre, obj1.Raza);
            // Agrego jugadores
            e += obj1;
            e += obj2;
            e += obj3;
            e += obj4;
            //e += new Gato("José", "Angora");
            e += obj5;
            e += obj6;
            // Muestro el equipo
            datosEquipo = e;
            Console.WriteLine(datosEquipo);
            Console.ReadKey();
            Console.Clear();

            // Quito jugadores
            e = e - obj3;
            e = e - new Gato("Fer", "Siames");
            // Cambio el deporte
            e.Tipo = Grupo.TipoManada.Mixta;
            // Muestro el equipo
            datosEquipo = e;
            Console.WriteLine(datosEquipo);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine((int)obj2);
            Console.WriteLine(obj1.Equals(obj6) ? "Iguales" : "No iguales");
            Console.WriteLine(obj1.Equals(new Perro("Moro", "Pitbull")) ? "Iguales" : "No iguales");
            Console.ReadKey();
        }
    }
}
