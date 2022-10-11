using System.Collections.Generic;

namespace UcuRideShare
{
    public class Pasajero : Usuario
    {
        public Pasajero(string nombre, string apellido, string cedula)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
        }
        public override void Calificar(Usuario conductor, double calificacion)
        {
            conductor.Calificaciones.Add(calificacion);
        }

    }
}