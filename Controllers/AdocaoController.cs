using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using static Service.AdocaoService;

namespace Controllers
{
    public class AdocaoController
    {
        public class AdotanteController
        {
            private AdocaoServices _adocaoServices;

            public AdotanteController()
            {
                _adocaoServices = new AdocaoServices();
            }

            public bool InsertAdotante(Adocao adocao)
            {
                return _adocaoServices.InsertAdotante(adocao);
            }

            public List<Adocao> GetAll()
            {
                return _adocaoServices.GetAll();
            }
        }
    }
}
