using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Habanero.DB;
using Models;

namespace Services
{
    internal class PetServices
    {
        static string _conexao;

        public PetServices()
        {
            _conexao = DatabaseConfig.GetConexao();
        }

        public bool InsertAnimal(Pet animal)
        {
            using (var db = new SqlConnection(_conexao))
            {
                db.Open();
                db.Execute(Pet.INSERT, animal);
                return true;
            }
        }

        public List<Pet> GetAll()
        {
            using (var db = new SqlConnection(_conexao))
            {
                db.Open();
                var animal = db.Query<Pet>(Pet.SELECT);
                return (List<Pet>)pet;
            }
        }
    }
}
