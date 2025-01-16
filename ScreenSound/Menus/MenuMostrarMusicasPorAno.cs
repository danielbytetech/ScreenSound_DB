using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    class MenuMostrarMusicasPorAno : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Exibir músicas por ano de lançamento");
            Console.Write("Insira o ano que deseja saber: ");
            string anoLancamento = Console.ReadLine()!;
            var musicaDAL = new DAL<Musica>(new ScreenSoundContext());
            var recuperarAnoLancamento = musicaDAL.ListarPor(a => a.AnoLancamento == Convert.ToInt32(anoLancamento));
            if(recuperarAnoLancamento.Any())
            {
                Console.WriteLine($"\nMúsicas do ano {anoLancamento}:");
                foreach(var musica in recuperarAnoLancamento)
                {
                    musica.ExibirFichaTecnica();
                }
                Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO ano {anoLancamento} não foi encontrada!");
                Console.WriteLine("Digite alguma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
