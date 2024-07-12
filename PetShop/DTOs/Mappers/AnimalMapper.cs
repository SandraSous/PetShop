using PetShop.Models;

namespace PetShop.DTOs.Mappers; 
public static class AnimalMapper {

    public static AnimalDTO ToAnimalDTO(Animal animal) {

        return new AnimalDTO {

            Id = animal.Id,
            Raca = animal.Raca,
            Especie = animal.Especie,
            ClienteId = animal.ClienteId
        };
    }

}
