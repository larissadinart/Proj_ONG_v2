using System;
using Models;
using static Controllers.PetControllers;

namespace P_MieAu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Pet:\n\n");
            Pet pet = new()
            {
                Familia = "Cachorro",
                Raca = "SRD",
                Sexo = "F",
                Nome = "Amora"
            };

            Adotante adotante = new()
            {
                Cpf = "41863339809",
                Nome = "Larissa Perez",
                Data_Nasc = 11/07/1991,
                Sexo = "Feminino",
                Logradouro = "Av.Dr.Vital Brasil",
                Numero = 300,
                Bairro = "Jd Marivan",
                Cidade = "Araraqrara",
                Telefone = "16997400669"
            };
        }
        new AdotanteController().InsertAdotante(adotante);

        new AdotanteController().GetAll().ForEach(x => Console.WriteLine(x.ToString()));

            new PetController().InsertPet(pet);

        new AnimalController().GetAll().ForEach(x => Console.WriteLine(x.ToString()));

    }
}

