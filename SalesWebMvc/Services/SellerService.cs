using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;

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
        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();//Seller -> acessa a fonte de dados relacionada a tabela de vendedores e converte para lista
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
           await _context.SaveChangesAsync();
        }
        public async Task <Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);//removeu do dbset 
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)//Any - > serve para ver se existe algum registro no BD
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
               await _context.SaveChangesAsync();
            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
                    
        }
    }
}
