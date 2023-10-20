using ExercEscreveCSVConsole.Services;
using System;

namespace ExercEscreveCSVConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Insere o tamanho do vetor
                AddCustomer addCostumer = new AddCustomer();

                Console.WriteLine("Insira a quantidade de dados que gostaria de inserir no vetor no seguinte formato: quantidade nome, quantidade CPF");

                string userQtd = Console.ReadLine();

                string[] separator = userQtd.Split(", ");

                addCostumer.AddQtd(int.Parse(separator[0]), int.Parse(separator[1]));

                Console.WriteLine(addCostumer.AddCustomerVectorSize());

                //Insere os dados do nome
                Console.WriteLine("Você deve inserir os dados agora. Caso queira sair, digite -1");
                /*
                while () {
                }*/


            }
            catch (Exception e)
            {
                Console.WriteLine("Aconteceu um erro!");
                Console.WriteLine(e.Message);
            }

        }
    }
}