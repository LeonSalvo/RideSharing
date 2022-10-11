using System.Collections.Generic;

namespace UcuRideShare
{
    public abstract class Conductor : Usuario
    {
        public string Vehiculo {get;set;}
        public string Biografia{get;set;}
    
        public override void Calificar(Usuario pasajero, double calificacion)
        {
            pasajero.Calificaciones.Add(calificacion);
        }
    }
}