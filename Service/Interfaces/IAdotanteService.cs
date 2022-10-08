using System;
using System.Collections.Generic;
using Models;

namespace Interfaces
{
    public interface IAdotanteService
    {
        bool InsertAdotante(Adotante adotante);
        List<Adotante> GetAll();
    }
}
