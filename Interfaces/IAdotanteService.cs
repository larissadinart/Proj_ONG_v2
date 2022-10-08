using System;
using Models;

namespace Interfaces
{
    public interface IAdotanteService
    {
        bool InsertAdotante(Adotante adotante);
        List<Adotante> GetAll();
    }
}
