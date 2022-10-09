using System;

namespace Models
{
    public class Pet
    {
        public readonly static string INSERT = "INSERT Pet VALUES(@FAMILIA, @RACA, @SEXO, @NOME)";
        public readonly static string SELECT = "SELECT * FROM Pet";
        public readonly static string DELETE = "DELETE Pet WHERE CHIP = @CHIP";

        public int Chip { get; set; }
        public string Familia { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }

        public Pet(string familia,string  raca,string sexo,string nome)
        {
            this.Nome = nome;   
            this.Familia = familia;
            this.Raca = raca;   
            this.Sexo = sexo;   

        }
        public override string ToString()
        {
            return $"CHIP: {Chip}\nNome: {Nome}\nFamilia: {Familia}\nRaça: {Raca}\nSexo: {Sexo}\n";
        }
    }
}
