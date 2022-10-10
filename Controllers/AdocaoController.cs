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
        public class AdocapController
        {
            private AdocaoServices _adocaoServices;

            public void AdocaoController()
            {
                _adocaoServices = new AdocaoServices();
            }

            public bool InsertAdocao(Adocao adocao)
            {
                return _adocaoServices.InsertAdocao(adocao);
            }

            public List<Adocao> GetAll()
            {
                return _adocaoServices.GetAll();
            }
        }
    }
}
