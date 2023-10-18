using ExercEscreveCSVConsole.Services;
using System;

namespace ExercEscreveCSVConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCustomer addCostumer = new AddCustomer();

            Console.WriteLine("Insira a quantidade de dados que gostaria de inserir no vetor no seguinte formato: name, CPF");
            
            string userInput = Console.ReadLine();

            string[] separator = userInput.Split(", ");

            addCostumer.AddQtd(int.Parse(separator[0]), int.Parse(separator[1]));

            Console.WriteLine(addCostumer.AddCustomerVectorSize());

        }
    }
}