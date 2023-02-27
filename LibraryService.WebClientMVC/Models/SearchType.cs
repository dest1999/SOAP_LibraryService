using System.ComponentModel.DataAnnotations;

namespace LibraryService.WebClientMVC.Models
{
    public enum SearchType
    {
        [Display(Name ="Название")]
        Title,
        [Display(Name = "Автор")]
        Author,
        [Display(Name = "Категория")]
        Category
    }
}
