﻿using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScreenSound.Banco
{
    class ArtistaDAL : DAL<Artista>
    {
        public ArtistaDAL(ScreenSoundContext context) : base(context) { }

        //public override IEnumerable<Artista> Listar()
        //{         
        //    return context.Artistas.ToList();
            
        //    //var lista = new List<Artista>();
        //    //connection.Open();

        //    //string sql = "SELECT * FROM Artistas";
        //    //SqlCommand command = new SqlCommand(sql, connection);
        //    //using SqlDataReader dataReader = command.ExecuteReader();

        //    //while (dataReader.Read())
        //    //{
        //    //    string nomeArtista = Convert.ToString(dataReader["Nome"]);
        //    //    string bioArtista = Convert.ToString(dataReader["Bio"]);
        //    //    int idArtista = Convert.ToInt32(dataReader["Id"]);
        //    //    Artista artista = new(nomeArtista, bioArtista) { Id = idArtista };

        //    //    lista.Add(artista);
        //    //}

        //    //return lista;
        //}

        //public override void Adicionar(Artista artista)
        //{           
        //    context.Artistas.Add(artista);
        //    context.SaveChanges();

        //    //string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
        //    //SqlCommand command = new SqlCommand(sql, connection);

        //    //command.Parameters.AddWithValue("@nome", artista.Nome);
        //    //command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    //command.Parameters.AddWithValue("@bio", artista.Bio);

        //    //int retorno = command.ExecuteNonQuery();
        //    //Console.WriteLine($"Linhas afetadas: {retorno}");
        //}

        //public override void Atualizar(Artista artista)
        //{
        //    context.Artistas.Update(artista);
        //    context.SaveChanges();

        //    //using var connection = new ScreenSoundContext().ObterConexao();
        //    //connection.Open();

        //    //string sql = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";
        //    //SqlCommand command = new SqlCommand(sql, connection);

        //    //command.Parameters.AddWithValue("@nome", artista.Nome);
        //    //command.Parameters.AddWithValue("@bio", artista.Bio);
        //    //command.Parameters.AddWithValue("@id", artista.Id);

        //    //int resultado = command.ExecuteNonQuery();
        //    //Console.WriteLine($"Linhas afetadas: {resultado}");
        //}

        //public override void Deletar(Artista artista)
        //{
        //    context.Artistas.Remove(artista);
        //    context.SaveChanges();

        //    //using var connection = new ScreenSoundContext().ObterConexao();
        //    //connection.Open();

        //    //string sql = $"DELETE FROM Artistas WHERE Id = @id";
        //    //SqlCommand command = new SqlCommand(sql, connection);

        //    //command.Parameters.AddWithValue("@id", artista.Id);

        //    //int retorno = command.ExecuteNonQuery();

        //    //Console.WriteLine($"Linhas afetadas: {retorno}");
        //}

        //public Artista? BuscarArtistaPeloNome(string nome)
        //{
        //    return context.Artistas.FirstOrDefault(a => a.Equals(nome));
        //}
    }
}
