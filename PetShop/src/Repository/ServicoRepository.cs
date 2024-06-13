using PetShop.Models;
using PetShop.src.Contrato.Repository;

namespace PetShop.src.Repository;
public class ServicoRepository : IServicoRepository {
    private List<Servico> _servicos = [
           new Servico{

             id = 1,
            descricao = "Sara",
            valor = 10


            }
           ];

    public void Create(Servico servico) {
        _servicos.Add(servico!);
    }

    public void Delete(int id) {
        var servico = _servicos.FirstOrDefault(x => x.id == id);
        _servicos.Remove(servico!);
    }

    public Servico Get(int id) {
        var servico = _servicos.FirstOrDefault(x => x.id == id);
        return servico!;
    }

    public List<Servico> List() {

        return _servicos;
    }

    public Servico Update(int id, Servico servico) {
        var servicoDb = _servicos.Where(x => x.id == id).FirstOrDefault();
        servicoDb!.id = servico.id;
        servicoDb.descricao = servico.descricao;
        servicoDb.valor = servico.valor;
        return servicoDb;

    }


}
