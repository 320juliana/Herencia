using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Moto:Vehiculo
    {
        public int Chascos { get; set; }
        public int Chalecos { get; set; }

        public Moto(string nombre)
        {
            Nombre = nombre;
        }
        public override void MiVehiculoDice()
        {
            Console.WriteLine("Es mejor tener una Moto");
        }
    }
}
