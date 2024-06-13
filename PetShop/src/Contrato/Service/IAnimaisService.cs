using PetShop.Models;

namespace PetShop.src.Contrato.Service;
public interface IAnimaisService
{
    void Create(Animal animal);
    void Update(int id, Animal animal);
    void Delete(int id);
    Animal Get(int id);
    List<Animal> List();
}
