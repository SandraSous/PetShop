using PetShop.Models;

namespace PetShop.src.Contrato.Repository;
public interface IServicoRepository
{
    void Create(Servico servico);
    Servico Update(int id, Servico servico);
    void Delete(int id);
    Servico Get(int id);
    List<Servico> List();

}
