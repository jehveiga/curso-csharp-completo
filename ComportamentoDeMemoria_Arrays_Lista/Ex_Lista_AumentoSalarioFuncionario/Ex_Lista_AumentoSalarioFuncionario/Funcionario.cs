using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Lista_AumentoSalarioFuncionario
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentagem)
        {
            Salary += Salary * (porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
