using System.ComponentModel.DataAnnotations;

namespace Abp.BookStore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}