using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    public class Objeto
    {
        public string nombre { get; set; }
        public int edad { get; set; }

        public Objeto(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

    }
}
