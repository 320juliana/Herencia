using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Auto:Vehiculo
       
    {
        public string Airbag { get; set; }
       

        public Auto(string nombre)
        {
            Nombre = nombre;

        }
        public override void MiVehiculoDice()
        {
            Console.WriteLine("Este auto es genial");
            base.MiVehiculoDice();
        }
       


    }
    
}
