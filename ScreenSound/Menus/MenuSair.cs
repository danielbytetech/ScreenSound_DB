using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;

namespace ScreenSound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            Console.WriteLine("Tchau tchau :)");
        }
    }
}
