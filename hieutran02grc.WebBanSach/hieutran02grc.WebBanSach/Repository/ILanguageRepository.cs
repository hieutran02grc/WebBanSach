using System.Collections.Generic;
using System.Threading.Tasks;
using hieutran02grc.WebBanSach.Models;

namespace hieutran02grc.WebBanSach.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}
