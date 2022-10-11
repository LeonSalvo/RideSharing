using System;
using System.Collections.Generic;
namespace UcuRideShare
{
    public class ConductorPool : Conductor
    {
        public int Capacidad{get;set;}
        public ConductorPool(string nombre, string apellido, string cedula, string vehiculo, string biografia, int capacidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Vehiculo = vehiculo;
            this.Biografia = biografia;
            this.Capacidad = capacidad;

        }
    }
    
}
 