using System.ComponentModel.DataAnnotations;

namespace SingleStone.API.Entities
{
    public class Phone
    {
        [Required]
        [MaxLength(50)]
        public string Number { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

    }
}
