using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        //Construtor
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //Retornar uma lista com todos os vendedores do BD
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();//Seller -> acessa a fonte de dados relacionada a tabela de vendedores e converte para lista
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
