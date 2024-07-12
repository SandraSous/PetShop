using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;
using PetShop.src.Repository;

namespace PetShop.src.Services;
public class ClienteService : IClienteService {
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository) {
        _clienteRepository = clienteRepository;

    }
    
    public async Task Create(Cliente cliente) {
       await _clienteRepository.Create(cliente);
    }

    public async Task Delete(int id) {
    
      await  _clienteRepository.Delete(id);
    }

    public async Task<Cliente?> Get(int id) {
        return await _clienteRepository.Get(id);
    }

    public  async Task<List<Cliente>> List() {
       return await _clienteRepository.List();
    }

    public async Task Update(int id, Cliente cliente) {
       await _clienteRepository.Update(id, cliente);
    }
}
