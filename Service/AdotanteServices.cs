using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Interfaces;
using Models;
using Models.BancoModel;

namespace Service
{
    public class AdotanteServices
    {
        public class AdotanteService : IAdotanteService
        {
            private string _conexao;

            public AdotanteService()
            {
                _conexao = BancoConfig.GetConexao();
            }

            public bool DeletePet(Pet adotante)
            {
                using (var bd = new SqlConnection(_conexao))
                {
                    bd.Open();
                    bd.Execute(Pet.DELETE, adotante);
                    return true;
                }
            }
            public List<Adotante> GetAll()
            {
                using (var db = new SqlConnection(_conexao))
                {
                    db.Open();
                    var adotantes = db.Query<Adotante>(Adotante.SELECT);
                    return (List<Adotante>)adotantes;
                }
            }

            public bool InsertAdotante(Adotante adotante)
            {
                using(var bd = new SqlConnection(_conexao))
            {
                    bd.Open();
                    bd.Execute(Pet.INSERT, adotante);
                    return true;
                }
            }
        }
    }
}