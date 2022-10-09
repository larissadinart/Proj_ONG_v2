using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;
using Models.BancoModel;
using Service.Interfaces;

namespace Service
{
    public class AdocaoService
    {
        public class AdocaoServices : IAdocaoServices
        {
            private string _conexao;

            public AdocaoServices()
            {
                _conexao = BancoConfig.GetConexao();
            }

            public bool DeleteAdocao(Adocao adocao)
            {
                using (var bd = new SqlConnection(_conexao))
                {
                    bd.Open();
                    bd.Execute(Adocao.DELETE, adocao);
                    return true;
                }
            }
            public List<Adocao> GetAll()
            {
                using (var db = new SqlConnection(_conexao))
                {
                    db.Open();
                    var adotantes = db.Query<Adocao>(Adocao.SELECT);
                    return (List<Adocao>)adotantes;
                }
            }


            public bool InsertAdocao(Adocao adotante)
            {
                using (var bd = new SqlConnection(_conexao))
                {
                    bd.Open();
                    bd.Execute(Adotante.INSERT, adotante);
                    return true;
                }
            }
        }
    }
}
