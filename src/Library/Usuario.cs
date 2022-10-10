using System;
using System.Collections.Generic;

namespace UcuRideShare
{
    public abstract class Usuario
    {
        string Nombre {get;set;}
        string Apellido {get;set;}

        string Cedula {get;set;}
        public List<double> Calificaciones {get;set;}
        public virtual void Calificar(Usuario usuario, double calificacion)
        {

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