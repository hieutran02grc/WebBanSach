using System.ComponentModel.DataAnnotations;

namespace hieutran02grc.WebBanSach.Enums
{
    public enum LanguageEnum
    {
        [Display(Name = "Hindi language")]
        Hindi = 10,
        [Display(Name = "English language")]
        English = 11,
        [Display(Name = "German language")]
        German = 12,
        [Display(Name = "Chinese language")]
        Chinese = 13,
        [Display(Name = "Urdu language")]
        Urdu = 14
    }
}
