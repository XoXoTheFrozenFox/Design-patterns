using Orgoffering.Data;
using Orgoffering.Models;

namespace Orgoffering.Repository
{
    public class ProductRepository
    {
        protected readonly DesignPatternsContext _context = new DesignPatternsContext();

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’

    }
}
