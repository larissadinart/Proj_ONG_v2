﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Interfaces
{
    public interface IPetService
    {
        bool InsertAnimal(Pet pet);
        List<Pet> GetAll();
    }
}

