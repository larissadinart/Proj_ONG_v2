using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Adotante
    {
        public readonly static string INSERT = "INSERT Adotante VALUES(@CPF, @NOME, @Data_Nasc, @SEXO, @LOGRADOURO, @NUMERO, @BAIRRO, @CIDADE, @TELEFONE)";
        public readonly static string SELECT = "SELECT * FROM Pessoa";
        public readonly static string DELETE = "DELETE Pessoa WHERE CPF = @CPF";

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }

        public Adotante(string cpf, string nome,DateTime data,string sx, string logradouro,int num,string bairro,string cidade,string tel)
        {
            this.Cpf = Cpf;
            this.Nome = Nome;
            this.Data_Nasc = data;
            this.Sexo = sx;
            this.Logradouro = logradouro;   
            this.Numero = num;  
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Telefone = Telefone;
        }
        public override string ToString()
        {
            return $"CPF: {Cpf}\nNome: {Nome}\nData_Nasc: {Data_Nasc.ToShortDateString()}\nSexo: {Sexo}\nEndereço: {Logradouro},{Numero}, {Bairro}, {Cidade}\n";
        }
    }
}
