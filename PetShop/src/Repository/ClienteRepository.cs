using PetShop.Models;
using PetShop.src.Contrato.Repository;
using System.Runtime.CompilerServices;

namespace PetShop.src.Repository {
    public class ClienteRepository : IClienteRepository {

        private List<Cliente> _clientes = [
            new Cliente{

             id = 1,
            nome = "Sara",
            telefone = "12345678"


            }
            ];
        public void Create(Cliente cliente) {
            _clientes.Add(cliente);
            
        }

        public void Delete(int id) {
           
            var cliente = _clientes.FirstOrDefault(x => x.id == id);
            _clientes.Remove(cliente!);
           
        }

        public Cliente Get(int id) {
            var cliente = _clientes.FirstOrDefault(x => x.id == id);
            return cliente!;
        }

        public List<Cliente> List() {
            return _clientes;
        }



        public void Update(int id, Cliente cliente) {
            var clienteDb = _clientes.Where(x => x.id == id).FirstOrDefault();
            clienteDb!.nome = cliente.nome;
            clienteDb.telefone = cliente.telefone;
            
        }

    }
}

