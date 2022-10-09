using System;
using System.Collections.Generic;
using Interfaces;
using Models;
using Service;

namespace Controllers
{
    public class PetControllers
    {
        private IPetService _petServices;

        public void PetController()
        {
            _petServices = new PetServices();
        }

        public bool InsertPet(Pet pet)
        {
            return _petServices.InsertPet(pet);
        }

        public List<Pet> GetAll()
        {
            return _petServices.GetAll();
        }
    }
}
