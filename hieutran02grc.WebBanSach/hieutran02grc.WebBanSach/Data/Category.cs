namespace hieutran02grc.WebBanSach.Data
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Books> Books { get; set; }
    }
}
