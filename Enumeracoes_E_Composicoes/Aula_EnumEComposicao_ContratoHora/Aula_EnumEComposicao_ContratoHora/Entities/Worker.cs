using Aula_EnumEComposicao_ContratoHora.Entities.Enums;
using System.Collections.Generic;

namespace Aula_EnumEComposicao_ContratoHora.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //Associação da Classe Worker com a Department
        public Department Department { get; set; }
        //Associação de um trabalhador para N contratos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                 if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                    
                } 
            }
            return sum; 
        }
    }
}
