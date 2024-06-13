using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;

namespace PetShop.src.Services;
public class ClienteService : IClienteService {
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository) {
        _clienteRepository = clienteRepository;
    }

    public void Create(Cliente cliente) {
        _clienteRepository.Create(cliente);
    }

    public void Delete(int id) {
    
        _clienteRepository.Delete(id);
    }

    public Cliente Get(int id) {
        return _clienteRepository.Get(id);
    }

    public  List<Cliente> List() {
       return _clienteRepository.List();
    }

    public void Update(int id, Cliente cliente) {
        _clienteRepository.Update(id, cliente);
    }
}
