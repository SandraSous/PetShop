using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;

namespace PetShop.src.Services;
public class ServicoService : IServicoService {
    private readonly IServicoRepository _servicoRepository;

    public ServicoService(IServicoRepository servicoRepository) {
        _servicoRepository = servicoRepository;
    }
    public async Task Create(Servico servico) {
       await _servicoRepository.Create(servico);
    }

    public async Task Delete(int id) {
       await _servicoRepository.Delete(id);
    }

    public async Task<Servico?> Get(int id) {
        return await _servicoRepository.Get(id);
    }

    public async Task<IEnumerable<Servico>?> GetServicoByCliente(int Id) {
        return await _servicoRepository.GetServicoByCliente(Id);
    }

    public async Task< List<Servico>> List() {
        return await _servicoRepository.List();
    }

    public async Task Update(int id, Servico servico) {
        await _servicoRepository.Update(id, servico);
    }
}
