using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Dependência para o DBContext.
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //Retorna lista com todos os vendedores no banco de dados.
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
