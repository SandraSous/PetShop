using PetShop.Models;
using PetShop.src.Contrato.Repository;

namespace PetShop.src.Repository {
    public class AnimalRepository : IAnimaisRepository {
        private List<Animal> _animais = [
            new Animal{
                 id = 1,
                 especie = "Cachorro",
                 raca = "Vira lata"
             }
             ];
        public void Create(Animal animal) {
            _animais.Add(animal);
        }

        public void Delete(int id) {
            var animal = _animais.FirstOrDefault(x => x.id == id);
            _animais.Remove(animal!);
        }

        public Animal Get(int id) {
            var animal = _animais.FirstOrDefault(x => x.id == id);
            return (animal!);
        }

        public List<Animal> List() {
            return  _animais;
        }

        public Animal Update(int id, Animal animal) {
            var animalDb = _animais.Where(x => x.id == id).FirstOrDefault();
            animalDb!.raca = animal.raca;
            animalDb.especie = animal.especie;
            return animalDb;
        }

       
    }
}
