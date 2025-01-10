using Microsoft.Data.SqlClient;

namespace ScreenSound.Banco
{
    class Connection
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Screen_Sound;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }        
    }
}
