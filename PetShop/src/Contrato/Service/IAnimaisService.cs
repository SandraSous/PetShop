﻿using PetShop.Models;

namespace PetShop.src.Contrato.Service;
public interface IAnimaisService
{
    Task Create(Animal animal);
    Task Update(int id, Animal animal);
    Task Delete(int id);
    Task<Animal> Get(int id);
   Task <List<Animal>> List();
}
