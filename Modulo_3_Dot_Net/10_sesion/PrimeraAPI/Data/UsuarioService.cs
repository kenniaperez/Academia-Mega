using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using PrimeraAPI.Models;
using Microsoft.Extensions.Configuration;

//crear modelo de usuarios 

namespace PrimeraAPI.Data
{
    public class UsuariosService
    {
        private readonly string _connectionString;

        public UsuariosService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("TiendaDB");
        }

        //Función para hashear la contraseña
        private string Hash(string pass)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
            return Convert.ToBase64String(bytes);
        }

        public async Task<bool> RegistroAsync(string username, string password)
        {
            var hash = Hash(password);
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            var cmd = new SqlConnection(
            "Insert INTO Usuarios(NombreUsuario, PasswordHash) VALUES(@user, @pass)", connection
            );
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", hash);

            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch(SqlException ex) when (ex.Number == 2627)
            {
                return false;
            }

        }

    }
}