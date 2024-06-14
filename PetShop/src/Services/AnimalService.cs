using PetShop.Models;
using PetShop.src.Contrato.Repository;
using PetShop.src.Contrato.Service;

namespace PetShop.src.Services;
public class AnimalService : IAnimaisService {
    private readonly IAnimailRepository _animalRepository;

    public AnimalService(IAnimailRepository animalRepository) {
        _animalRepository = animalRepository;

    }

    public async Task Create(Animal animal) {
        await _animalRepository.Create(animal);
    }

    public async Task Delete(int id) {
        await _animalRepository.Delete(id);
    }

    public Task<Animal> Get(int id) {
        return _animalRepository.Get(id);

    }

    public Task<List<Animal>> List() {
        return _animalRepository.List();
    }

    public async Task Update(int id, Animal animal) {
        await _animalRepository.Update(id, animal);
    }
}
