using PetShop.Models;

namespace PetShop.src.Contrato.Repository;
public interface IServicoRepository {
    Task Create(Servico servico);
    Task Update(int Id, Servico servico);
    Task Delete(int Id);
    Task<Servico?> Get(int Id);
    Task<List<Servico>> List();
    Task<IEnumerable<Servico>> GetServicoByCliente(int Id);

}
