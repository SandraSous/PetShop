using Dapper;
using PetShop.Data;
using PetShop.Models;
using PetShop.src.Contrato.Repository;
using System.Runtime.CompilerServices;

namespace PetShop.src.Repository {
    public class ClienteRepository : IClienteRepository {

        private readonly DapperContext _dapperContext;

        public ClienteRepository(DapperContext dapperContext) {
            _dapperContext = dapperContext;
        }

        public async Task Create(Cliente cliente) {
            using (var connection = _dapperContext.CreateConnection()) {
                var sql = "INSERT INTO Cliente (Nome, Telefone) VALUES (@Nome, @Telefone)";
                await connection.ExecuteAsync(sql, cliente);

            }
        }

        public async Task Delete(int id) {
            using (var connection = _dapperContext.CreateConnection()) {
                var sql = "DELETE FROM Cliente WHERE Id = @Id";
                await connection.ExecuteAsync(sql, new { id });
            }
        }

        public async Task<Cliente?> Get(int id) {
            using (var connection = _dapperContext.CreateConnection()) {
                var query = @"SELECT 
                 Id   
                ,Nome
                ,Telefone
                FROM Cliente WHERE Id = @Id";
                var clientes = await connection.QueryAsync<Cliente>(query, new { id });
                if (clientes != null) {
                    return clientes?.FirstOrDefault();
                }
                return null;
            }
        }

        public async Task<List<Cliente>> List() {
            string query = @"SELECT Id
              ,Nome
              ,Telefone
              FROM Cliente";

            using (var connection = _dapperContext.CreateConnection()) {
                var listaClientes = await connection.QueryAsync<Cliente>(query);
                return listaClientes.ToList();
            }
        }

        public async Task Update(int id, Cliente cliente) {
            using (var connection = _dapperContext.CreateConnection()) {
                await connection.ExecuteAsync(
                    "UPDATE Animal SET Nome=@Nome, Telefone = @Telefone WHERE Id=@Id",
                    new { id, cliente.Nome });
            }
        }


    }
}

