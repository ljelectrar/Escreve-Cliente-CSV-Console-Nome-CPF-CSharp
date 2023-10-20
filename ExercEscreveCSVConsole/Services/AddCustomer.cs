using System;


namespace ExercEscreveCSVConsole.Services
{
    class AddCustomer
    {
        private string[] _costumerName;
        private string[] _customerCPF;

        private string[,] _AllDataCostumer;

       
        //Método que introduz o tamanho do vetor
        public void AddQtd(int addQtdName, int addQtdCPF)
        {
            _AllDataCostumer = new string[addQtdName, addQtdCPF];

            if (addQtdName != addQtdCPF) {
                Console.WriteLine("Atenção: atenção, a quantidade de número e cpf estão diferentes!" +
                    "\n Poderá haver ambiguidades no banco de dados!");
            }
        }

        public int AddCustomerVectorSize() {
            return _AllDataCostumer.Length; 
        }

        public void AddDataCostumer(string costumerName, string costumerCPF) 
        {
            AddDataName(costumerName);
            AddDataCPF(costumerCPF);
        }

        public void AddDataName(string name)
        {
            for (int i = 0; i < _costumerName.Length; i++)
            {
                _costumerName[i] = name;
            }

        }

        public void AddDataCPF(string CPF)
        {
            for (int i = 0; i < _customerCPF.Length; i++)
            {
                _customerCPF[i] = CPF;
            }
        }

    }
}
