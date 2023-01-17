using hieutran02grc.WebBanSach.Models;

namespace hieutran02grc.WebBanSach.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetCategorys();
    }
}
