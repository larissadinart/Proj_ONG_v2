using Dapper;
using Interfaces;
using Habanero.DB;
using Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using Models.BancoModel;

namespace Service
{
    public class PetServices : IPetService
    {
        private string _conexao;

        public PetServices()
        {
            _conexao = BancoConfig.GetConexao();
        }

        public bool InsertPet(Pet pet)
        {
            using (var bd = new SqlConnection(_conexao))
            {
                bd.Open();
                bd.Execute(Pet.INSERT, pet);
                return true;
            }
        }

        public bool DeletePet(Pet pet)
        {
            using (var bd = new SqlConnection(_conexao))
            {
                bd.Open();
                bd.Execute(Pet.DELETE, pet);
                return true;
            }
        }

        public List<Pet> GetAll()
        {
            using (var db = new SqlConnection(_conexao))
            {
                db.Open();
                var pets = db.Query<Adotante>(Pet.SELECT);
                return (List<Pet>)pets;
            }
        }
    }
}
