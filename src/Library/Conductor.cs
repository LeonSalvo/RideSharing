using System.Collections.Generic;

namespace UcuRideShare
{
    public abstract class Conductor : Usuario
    {
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string Cedula {get;set;}
        public string Vehiculo {get;set;}
        public string Biografia{get;set;}
        public List<double> Calificaciones {get;set;} = new List<double>();
        
        public override void Calificar(Usuario pasajero, double calificacion)
        {
            pasajero.Calificaciones.Add(calificacion);
        }
    }
}