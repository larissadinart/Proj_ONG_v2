using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Interfaces
{
    public interface IPetService
    {
        List<Pet> GetAll();
        public bool InsertPet(Pet pet);
        public bool DeletePet(Pet pet);
        public bool UpdatePet(Pet pet);
    }
}

