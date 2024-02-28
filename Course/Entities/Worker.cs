using System.Collections.Generic;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } //associação entre dois tipos (composição de objetos)
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        } 
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) // para cada HourContract na minha lista de contratos
            {
                if (contract.Date.Year == year && contract.Date.Month == month) // se o ano do meu contrato for igual ao ano do contrato que recebi como argumento, significa que esse contrato vai entrar na soma
                {
                    sum += contract.TotalValue(); // soma recebe ela mesmo + valor do contrato
                }
            }
            return sum;
        }

    }
}
