using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();//Associação de 1 para muitos

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)//Adicionar vendedor
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)//Remove vendedor
        {
            Sales.Remove(sr);
        }

        //Calculamos o total de vendas de um vendedor em um determinado intervalo de datas
        public double TotalSalles(DateTime initial, DateTime final)
        {
            //Sales -> chama colecção sales(lista de vendas associadas com o vendedor )
            //Where ->Filtrar a lista de vendas p/obter uma nova lista contendo apenas as vendas no intervalo de data
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);//soma das vendas
        }


    }
}
