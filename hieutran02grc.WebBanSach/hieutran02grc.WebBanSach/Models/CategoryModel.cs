using System.ComponentModel.DataAnnotations;

namespace hieutran02grc.WebBanSach.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
