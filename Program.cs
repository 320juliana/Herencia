using System;
using System.Collections.Generic;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>(); 
            var auto = new Auto("deportivo");
            var moto = new Moto("Señoritera");
            var retroescabadora = new Retroescabadora("Grande");
    moto.MiVehiculoDice();
                retroescabadora.MiVehiculoDice();
                auto.MiVehiculoDice();
                auto.Marca = "Chevrolet";
                auto.Modelo = "Camaro";
                auto.Velocidad = 50;

              auto.Frenar();
           
            
            
            Console.WriteLine($"Marca: {auto.Marca}");
            Console.WriteLine($"Modelo: {auto.Modelo}");

           
            Program pro = new Program();
            pro.MostrarMsj();
            MostrarVehiculo(moto);
            MostrarVehiculo(new Retroescabadora("Cat"));
            vehiculos.Add(new Moto("Akt"));
            DefinirVenta(auto, 54000000);
            DefinirVenta(retroescabadora, 4000000);
            vehiculos.Add(auto);
            vehiculos.Add(moto);
            vehiculos.Add(retroescabadora);
            ListarVehiculos(vehiculos);
            Console.ReadKey();
            
        }
        public static void ListarVehiculos(List<Vehiculo> vehiculos)
        {
            Console.WriteLine("***Listado de vehiculos***");
            foreach (var item in vehiculos)
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
                Console.WriteLine($"Modelo: {item.Modelo}");
                Console.WriteLine($"Marca: {item.Marca}");
                Console.WriteLine($"Ruedas: {item.Ruedas}");
                Console.WriteLine($"Venta: {item.Valor}");

            }



        }
        public void MostrarMsj()
        {

        }
        public static void MostrarVehiculo(Vehiculo miVehiculo)
        {
            miVehiculo.MiVehiculoDice();
        }
        public static void  DefinirVenta(Vehiculo vehiculo, double valor)
        {
            vehiculo.Valor = valor;
        }
    }
}
