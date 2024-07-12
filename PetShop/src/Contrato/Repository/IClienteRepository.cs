using PetShop.Models;

namespace PetShop.src.Contrato.Repository;
public interface IClienteRepository {
    Task Create(Cliente cliente);
    Task Update(int Id, Cliente cliente);
    Task Delete(int Id);
    Task<Cliente?> Get(int Id);
   Task <List<Cliente>> List();

}

