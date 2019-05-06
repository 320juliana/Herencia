using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Retroescabadora:Vehiculo
    {
        public int NumPalas { get; set; }

        public Retroescabadora(string nombre)
        {
            Nombre = nombre;
            
        }

        public override void MiVehiculoDice()
        {
            base.MiVehiculoDice();
        }


    }


    
}
