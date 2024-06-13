﻿using PetShop.Models;

namespace PetShop.src.Contrato.Repository;
public interface IClienteRepository
{
    void Create(Cliente cliente);
    void Update(int id, Cliente cliente);
    void Delete(int id);
    Cliente Get(int id);
    List<Cliente> List();
    
}

