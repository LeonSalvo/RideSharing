using System;
using System.Collections.Generic;
namespace UcuRideShare
{
    public class ConductorComun : Conductor
    {
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string Cedula {get;set;}
        public string Vehiculo {get;set;}
        public string Biografia{get;set;}
        public List<double> Calificaciones {get;set;} = new List<double>();
        
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
 