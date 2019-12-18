using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaller(Seller seller)
        {
            //Pega lista de vendedores e adiciona nela
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime inicial, DateTime final)
        {
            //Pegar lista de vendedores do departamento e soma total de venda de cada vendedor 

            return Sellers.Sum(seller => seller.TotalSalles(inicial, final));//pegou cada vendedor da lista chamando o TotalSales do vendedor naquele perido I/Final, faz soma do resultado p/tds vendedores do departmento
        }
    }
}
