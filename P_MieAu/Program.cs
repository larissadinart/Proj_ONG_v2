using System;
using Controllers;
using Models;
using static Controllers.AdotanteControllers;
using static Controllers.AdocaoController;

namespace P_MieAu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

            

            new AdotanteController().GetAll().ForEach(x => Console.WriteLine(x.ToString()));

            

            new PetControllers().GetAll().ForEach(x => Console.WriteLine(x.ToString()));

        }

        static void Menu()
        {
            Console.WriteLine("Bem vindo a Ong Mi&Au!\n\n");
            Console.WriteLine("Escolha a opção desejada: \n[1] Cadastrar Pet\n[2] Cadastrar Adotante\n[3] Gerar Adoção");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Cadastrar Pet:\n\n");
                    Console.WriteLine("Família: ");
                    string familia = Console.ReadLine();
                    Console.WriteLine("Raça: ");
                    string raca = Console.ReadLine();
                    Console.WriteLine("Sexo: ");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("Nome : ");
                    string nome = Console.ReadLine();
                    Pet pet = new(familia, raca, sexo, nome);
                    new PetControllers().InsertPet(pet);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Cadastrar Adotante: \n\n");
                    Console.WriteLine("Cpf: ");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("Nome: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Data de Nascimento: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Sexo: ");
                    string sx = Console.ReadLine();
                    Console.WriteLine("Logradouro: ");
                    string logradouro = Console.ReadLine();
                    Console.WriteLine("Numero: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bairro: ");
                    string bairro = Console.ReadLine();
                    Console.WriteLine("Cidade: ");
                    string cidade = Console.ReadLine();
                    Console.WriteLine("Telefone: ");
                    string tel = Console.ReadLine();
                    Adotante adotante = new(cpf, name, data, sx, logradouro, num, bairro, cidade, tel);
                    new AdotanteController().InsertAdotante(adotante);
                    break;
                case 3:
                    Console.WriteLine("Cadastrar adoção:\n\n");
                    Console.WriteLine("Digite o chip do animal que deseja adotar: ");
                    int chip = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o CPF do Adotante:");
                    string doc = Console.ReadLine();
                    DateTime date = DateTime.Now;
                    Adocao adocao = new(chip, doc, date);
                    new AdocaoController().InsertAdocao(adocao);
                    break;

            }

        }
    }
}

