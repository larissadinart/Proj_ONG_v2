using System.Collections.Generic;
using Models;

namespace Service.Interfaces
{
    public interface IAdocaoServices
    {
        public interface IAdocaoService
        {
            bool InsertAdotante(Adocao adocao);
            List<Adocao> GetAll();
        }
    }
}