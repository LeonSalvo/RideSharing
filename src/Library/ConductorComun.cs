using System;
using System.Collections.Generic;
namespace UcuRideShare
{
    public class ConductorComun : Conductor
    {
        public ConductorComun(string nombre, string apellido, string cedula, string vehiculo, string biografia)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Vehiculo = vehiculo;
            this.Biografia = biografia;

        }
    }
    
}
 