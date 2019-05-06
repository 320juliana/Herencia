using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Nombre { get; set; }
        public int Ruedas { get; set; }
        public double Valor { get; set; }
        public double Velocidad { get; set; }
        public virtual void MiVehiculoDice()
        {
           
            Console.WriteLine($"Mi Vehiculo es {Nombre}");
        }
        public virtual void MiVehiculoDice(string modelo)
        {

            Console.WriteLine($"Mi Vehiculo es {Nombre}");
        }
        public virtual void MiVehiculoDice(int modelo)
        {

            Console.WriteLine($"Mi Vehiculo es {Nombre}");
        }
        public virtual  void Frenar()
        {
            
            Console.WriteLine("Desea Frenar? digite si/no");
            var result = Console.ReadLine();
           
               
               while (result == "si")
                {
                Console.WriteLine("Desea Frenar? digite si/no");
                 result = Console.ReadLine();
                Velocidad--;
                Console.WriteLine($"la velocidad es {Velocidad}");


            }
            
                
            
        }
    }
}
