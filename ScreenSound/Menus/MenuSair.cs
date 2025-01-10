using ScreenSound.Modelos;
using System;
using System.Collections.Generic;

namespace ScreenSound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Artista> artistasRegistrados)
        {
            Console.WriteLine("Tchau tchau :)");
        }
    }
}
