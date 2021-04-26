using System.ComponentModel.DataAnnotations;

namespace Haha.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}