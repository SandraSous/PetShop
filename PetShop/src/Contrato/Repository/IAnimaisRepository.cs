using PetShop.Models;

namespace PetShop.src.Contrato.Repository;
public interface IAnimaisRepository
{
    void Create(Animal animal);
    Animal Update(int id, Animal animal);
    void Delete(int id);
    Animal Get(int id);
    List<Animal> List();
}

