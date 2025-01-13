﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    class ScreenSoundContext : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Screen_Sound;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        //public SqlConnection ObterConexao()
        //{
        //    return new SqlConnection(connectionString);
        //}        
    }
}
