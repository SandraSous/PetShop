using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using PetShop.Data;
using PetShop.Models;
using PetShop.src.Contrato.Repository;
using System.Reflection.Metadata.Ecma335;

namespace PetShop.src.Repository {
    public class AnimalRepository : IAnimalRepository {

        private readonly DapperContext _dapperContext;


        public AnimalRepository(DapperContext dapperContext) {
            _dapperContext = dapperContext;
        }

        public async Task Create(Animal animal) {
            using (var connection = _dapperContext.CreateConnection()) {
                var sql = "INSERT INTO Animal (Raca, Especie) VALUES (@Raca, @Especie)";
                await connection.ExecuteAsync(sql, animal);

            }
                
        }

        public async Task Delete(int Id) {
         using (var connection = _dapperContext.CreateConnection()) {
                var sql = "DELETE FROM Animal WHERE Id = @Id";
                await connection.ExecuteAsync(sql, new {  Id });
            }
        }

        public async Task<Animal?> Get(int id) {
            using (var connection = _dapperContext.CreateConnection()) {
               var query = @"SELECT 
                 Id   
                ,Raca
                ,Especie
                FROM Animal WHERE Id = @Id";
                var animais = await connection.QueryAsync<Animal>(query, new {  id });
                if (animais != null) {
                    return animais?.FirstOrDefault();
                }
                return null;
            }
        }

        public async Task<IEnumerable<Animal>> GetAnimalByCliente(int id) {
            string query = @"SELECT Id
              ,Raca
              ,Especie
              ,ClienteId
              FROM Animal Where ClienteId=@Id";

            using (var connection = _dapperContext.CreateConnection()) {
                 return await connection.QueryAsync<Animal>(query, new { id });
                
            }
        }

        public async Task<List<Animal>> List() {
            string query = @"SELECT Id
              ,Raca
              ,Especie
              FROM Animal";

            using (var connection = _dapperContext.CreateConnection()) {
                var listaAnimais = await connection.QueryAsync<Animal>(query);
                return listaAnimais.ToList();
            }
        }

        public async Task Update(int id, Animal animal) {

            using (var connection = _dapperContext.CreateConnection()) {
                await connection.ExecuteAsync(
                    "UPDATE Animal SET Raca=@Raca, Especie = @Especie WHERE Id=@Id",
                    new { id, animal.Raca });
            }
        }

    }
}
