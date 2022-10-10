using System;
using System.Collections.Generic;
namespace UcuRideShare
{
    public class ConductorPool : Conductor
    {
        string Nombre {get;set;}
        string Apellido {get;set;}
        string Cedula {get;set;}
        string Vehiculo {get;set;}
        string Biografia{get;set;}
        int Capacidad{get;set;}
        public List<double> Calificaciones {get;set;} = new List<double>();
        
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
 