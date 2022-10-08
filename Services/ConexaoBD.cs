using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    public class ConexaoBD
    {
        readonly string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:.\Services\Banco\MieAu.mdf;Integrated Security=True;Connect Timeout=30;";
        readonly SqlConnection conn;

        public ConexaoBD()
        {
            conn = new SqlConnection(conexao);
        }
    }
}

