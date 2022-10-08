using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Habanero.DB;
using Interfaces;
using Models;

namespace Services
{
    public class AdotanteServices
    {
        public class AdotanteServices : IAdotanteService
        {
            private string _conexao;

            public AdotanteServices()
            {
                _conexao = DatabaseConfig.GetConexao();
            }

            public bool InsertAdotante(Adotante adotante)
            {
                using (var db = new SqlConnection(_conexao))
                {
                    db.Open();
                    db.Execute(Adotante.INSERT, adotante);
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
        }

    }
