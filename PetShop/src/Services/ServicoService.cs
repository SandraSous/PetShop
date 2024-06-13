using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;

namespace PetShop.src.Services;
public class ServicoService : IServicoService {
    private readonly IServicoRepository _servicoRepository;

    public ServicoService(IServicoRepository servicoRepository) {
        _servicoRepository = servicoRepository;
    }
    public void Create(Servico servico) {
        _servicoRepository.Create(servico);
    }

    public void Delete(int id) {
        _servicoRepository.Delete(id);
    }

    public Servico Get(int id) {
        return _servicoRepository.Get(id);
    }

    public List<Servico> List() {
        return _servicoRepository.List();
    }

    public void Update(int id, Servico servico) {
        _servicoRepository.Update(id, servico);
    }
}
