using System;
using System.Collections.Generic;

namespace TareaDiccionario02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Persona> diccionarioPersona = new Dictionary<string, Persona>();

            diccionarioPersona.Add("MAGGIE", new Persona() { nombre = "Maggieee", apellido = "Simpson", edad = 1 });
            diccionarioPersona.Add("LISA", new Persona() { nombre = "Lisaaa", apellido = "Simpson", edad = 8 });
            diccionarioPersona.Add("BART", new Persona() { nombre = "Bartoon", apellido = "Simpson", edad = 12 });
            diccionarioPersona.Add("MARGE", new Persona() { nombre = "Margeee", apellido = "Bouvier", edad = 33 });
            diccionarioPersona.Add("HOMERO", new Persona() { nombre = "Homeroo", apellido = "Simpson", edad = 35 });

            foreach (var k in diccionarioPersona.Keys)
            {
                Console.WriteLine("Llave existente segun el personaje es :{0} ", k);
            }
            /*-----Las llaves asignadas a cada personaje estan en MAYUSCULA ----------*/
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("La llave segun la edad es:     {0}", diccionarioPersona["MAGGIE"].edad);
            Console.WriteLine("La llave segun el apellido es: {0}", diccionarioPersona["MARGE"].apellido);
            Console.WriteLine("La llave segun el nombre es:   {0}", diccionarioPersona["BART"].nombre);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Datos segun la llave asignada son: {0}", diccionarioPersona["BART"].ToString());
            Console.WriteLine("Datos segun la llave asignada son: {0}", diccionarioPersona["MARGE"].ToString());
            Console.WriteLine("Datos segun la llave asignada son: {0}", diccionarioPersona["HOMERO"].ToString());
            Console.WriteLine("Datos segun la llave asignada son: {0}", diccionarioPersona["LISA"].ToString());
            Console.WriteLine("Datos segun la llave asignada son: {0}", diccionarioPersona["MAGGIE"].ToString());
        }
    }
}
