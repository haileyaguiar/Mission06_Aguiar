using System.ComponentModel.DataAnnotations;

namespace Mission06_Aguiar.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo {  get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }
        


    }
}
