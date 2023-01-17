using hieutran02grc.WebBanSach.Data;
using hieutran02grc.WebBanSach.Models;
using Microsoft.EntityFrameworkCore;

namespace hieutran02grc.WebBanSach.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookStoreContext _context = null;

        public CategoryRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryModel>> GetCategorys()
        {
            return await _context.Category.Select(x => new CategoryModel()
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToListAsync();
        }

       

     
    }
}
