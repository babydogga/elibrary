using System.ComponentModel.DataAnnotations;

namespace elibrary.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //relacje

        public List<Autor_Ksiazka> Autor_Ksiazki { get; set; }
    }
}

