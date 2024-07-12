using PetShop.Models;

namespace PetShop.src.Contrato.Service;
public interface IAnimaisService {
    Task Create(Animal animal);
    Task Update(int Id, Animal animal);
    Task Delete(int Id);
    Task<Animal?> Get(int Id);
    Task<List<Animal>> List();
    Task<IEnumerable<Animal>?> GetAnimalByCliente(int Id);
}
