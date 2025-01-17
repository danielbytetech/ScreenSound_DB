﻿using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;

namespace ScreenSound.Menus
{

    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        public virtual void Executar(DAL<Artista> artistaDAL)
        {
            Console.Clear();
        }
    }
}