using Dapper;
using Microsoft.Data.SqlClient;
using PetShop.Data;
using PetShop.Models;
using PetShop.src.Contrato.Repository;
using System.Reflection.Metadata.Ecma335;

namespace PetShop.src.Repository {
    public class AnimalRepository : IAnimailRepository {

        private readonly DapperContext _dapperContext;


        public AnimalRepository(DapperContext dapperContext) {
            _dapperContext = dapperContext;
        }

        public Task Create(Animal animal) {
            throw new NotImplementedException();
        }

        public Task Delete(int id) {
            throw new NotImplementedException();
        }

        public Task<Animal> Get(int id) {
            throw new NotImplementedException();
        }

        public async Task<List<Animal>> List() {
            string query = @"SELECT id
              ,raca
              ,especie
              FROM Animal";

            using (var connection = _dapperContext.CreateConnection()) {
                var listaAnimais = await connection.QueryAsync<Animal>(query);
                return listaAnimais.ToList();
            }
        }

        public async Task Update(int id, Animal animal) {

            using (var connection = _dapperContext.CreateConnection()) {
                await connection.ExecuteAsync(
                    "UPDATE Animal SET raca=@raca, especie = @especie WHERE Id=@Id",
                    new { id, animal.raca });
            }
        }

    }
}
