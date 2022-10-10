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
        public virtual void GetCalificacion()
        {

        }

    }
}