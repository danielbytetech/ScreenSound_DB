using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    class MusicaDAL : DAL<Musica>
    {        
        public MusicaDAL(ScreenSoundContext context) : base(context) { }
       
        public Musica? BuscarMusicaPeloNome(string nome)
        {
            return context.Musicas.FirstOrDefault(a => a.Equals(nome));
        }
    }
}

