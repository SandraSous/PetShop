using PetShop.Models;

namespace PetShop.src.Contrato.Service;
public interface IClienteService {
    Task Create(Cliente cliente);
    Task Update(int Id, Cliente cliente);
    Task Delete(int Id);
    Task<Cliente?> Get(int Id);
    Task<List<Cliente>> List();
}
