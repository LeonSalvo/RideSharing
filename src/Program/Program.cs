using System;
using System.Collections;
using TwitterUCU;

namespace UcuRideShare
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario pasajero1 = new Pasajero("Armando", "Esteban Quito", "11111111");
            Usuario pasajero2 = new Pasajero("Marcelo", "Iripino", "22222222");
            Usuario pasajero3 = new Pasajero("Juan", "Maffei", "33333333");
            Usuario conductor1 = new ConductorPool("Bruno", "Zefferino", "44444444", "Corsita", "Me llamo Bruno =)", 3);
            UcuRideSharing rideshare = new UcuRideSharing();

            string foto = @"prueba1.jpg";
            string foto2 = @"prueba2.jpg";

            
            rideshare.Add(pasajero1, foto);
            rideshare.Add(pasajero2, foto);
            rideshare.Add(pasajero3, foto);
            rideshare.Add(conductor1, foto2);

            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!


            using System;
            using System.Threading.Tasks;

            namespace TwitterUCU
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        var twitter = new TwitterImage();
                        Console.WriteLine(twitter.PublishToTwitter("New Employee 2! ",@"bill2.jpg"));
                        var twitterDirectMessage = new TwitterMessage();
                        Console.WriteLine(twitterDirectMessage.SendMessage("Hola!", "1396065818"));
                    }
                }

            */
        }
    }
}
