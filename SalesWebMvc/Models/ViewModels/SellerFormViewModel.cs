using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel//tela cadastro vendedor
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
