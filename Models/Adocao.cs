using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Adocao
    {
        public readonly static string INSERT = "INSERT Adocao VALUES(@Chip, @Cpf, @Data_adocao)";
        public readonly static string SELECT = "SELECT * FROM Adocao";
        public readonly static string DELETE = "DELETE Adocao WHERE CPF = @CPF";

        public int Chip { get; set; }
        public String Cpf { get; set; }
        public DateTime Data_adocao { get; set; }

        public Adocao(int chip, string cpf, DateTime data)
        {
            this.Chip = chip;
            this.Cpf = cpf;
            this.Data_adocao = data;
        }
        public override string ToString()
        {
            return $"Chip do Pet: {Chip}\n Cpf do Adotante: {Cpf}\nData de Adoção: {Data_adocao}";
        }
    }
}
