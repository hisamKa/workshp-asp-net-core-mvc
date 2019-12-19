﻿using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);//removeu do dbset 
            _context.SaveChanges();
        }
    }
}
