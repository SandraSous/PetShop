using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;

namespace PetShop.src.Services;
public class AnimalService : IAnimaisService {
    private readonly IAnimaisRepository _animalRepository;

    public AnimalService(IAnimaisRepository animalRepository) {
        _animalRepository = animalRepository;

    }
    
    public void Create(Animal animal) {
          _animalRepository.Create(animal);  
    }

    public void Delete(int id) {
        _animalRepository.Delete(id);
    }

    public Animal Get(int id) {
       return _animalRepository.Get(id);
        
    }

    public List<Animal> List() {
        return _animalRepository.List();
    }

    public void Update(int id, Animal animal) {
        _animalRepository.Update(id, animal);
    }
}
