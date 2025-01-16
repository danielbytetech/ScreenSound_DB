using Microsoft.EntityFrameworkCore.Migrations;

namespace ScreenSound.Migrations
{
    public partial class AtualizandoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 1 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 2 WHERE Id IN (2, 5)");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 3 WHERE Id IN (3, 6)");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 4 WHERE Id = 4");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 7 WHERE Id = 7");

            migrationBuilder.Sql("DELETE FROM Artistas WHERE Id IN (5,6)");            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
