using System.Collections.Generic;
using Models;
using Service;

namespace Controllers
{
    public class AdotanteControllers
    {
        public class AdotanteController
        {
            private AdotanteServices _adotanteServices;

            public AdotanteController()
            {
                _adotanteServices = new AdotanteServices();
            }

            public bool InsertAdotante(Adotante adotante)
            {
                return _adotanteServices.InsertAdotante(adotante);
            }

            public List<Adotante> GetAll()
            {
                return _adotanteServices.GetAll();
            }
        }
    }
}
