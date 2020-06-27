using System.ComponentModel.DataAnnotations;

namespace SingleStone.API.Entities
{
    public class Name
    {
        [Required]
        [MaxLength(50)]
        public string First { get; set; }

        [Required]
        [MaxLength(50)]
        public string Middle { get; set; }

        [Required]
        [MaxLength(50)]
        public string Last { get; set; }

    }
}
