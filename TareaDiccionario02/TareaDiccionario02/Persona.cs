using System;
using System.Collections.Generic;
using System.Text;

namespace TareaDiccionario02
{
    class Persona
    {
        public string nombre    { get; set; }
        public string apellido  { get; set; }
        public int    edad      { get; set; }

        public override string ToString()
        {
            return $"nombre: {nombre}, apellido: {apellido}, edad: {edad}";
        }
    }
}
