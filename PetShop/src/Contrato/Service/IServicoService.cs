using PetShop.Models;

namespace PetShop.src.Contrato.Service;
public interface IServicoService
{
    void Create(Servico servico);
    void Update(int id, Servico servico);
    void Delete(int id);
    Servico Get(int id);
    List<Servico> List();

}
