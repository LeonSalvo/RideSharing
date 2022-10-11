using System;
using TwitterUCU;
using System.Collections.Generic;
using CognitiveCoreUCU;
using System.Drawing;

namespace UcuRideShare
{
    public class UcuRideSharing
    {
        public List<Usuario> Usuarios {get;set;} = new List<Usuario>();
        public void Add(Usuario usuario, string direccionFoto)
        {
            CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow);
            cog.Recognize(direccionFoto);

            if (cog.FaceFound == true && cog.SmileFound == true)
            {
                this.Usuarios.Add(usuario);
                var twitter = new TwitterImage();
                Console.WriteLine(twitter.PublishToTwitter($"New Employee {usuario.Nombre} {usuario.Apellido}! ", direccionFoto));
                var twitterDirectMessage = new TwitterMessage();
                Console.WriteLine(twitterDirectMessage.SendMessage("Hola!", "1396065818"));
            }
            else
            {
                Console.WriteLine("Cara o sonrisa no detectada");
            }
        }
    }
}