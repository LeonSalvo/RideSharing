using System.Collections.Generic;

namespace UcuRideShare
{
    public abstract class Conductor : Usuario
    {
        string Nombre {get;set;}
        string Apellido {get;set;}
        string Cedula {get;set;}
        string Vehiculo {get;set;}
        string Biografia{get;set;}
        public List<double> Calificaciones {get;set;} = new List<double>();
        
        public override void Calificar(Pasajero pasajero, double calificacion)
        {
            pasajero.Calificaciones.Add(calificacion);
        }
         public double GetCalificacion()
        {
            double SumaCalificaiones = 0;
            foreach(double calificaion in this.Calificaciones)
            {
                SumaCalificaiones += calificaion;
            }
            return SumaCalificaiones / this.Calificaciones.Count;
        }

    }
}