using System.ComponentModel.DataAnnotations;

namespace SingleStone.API.Entities
{
    public class Address //street city state zip
    {
        [Required]
        [MaxLength(50)]
        public string Street { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [Required]
        [MaxLength(5)]
        public string Zip { get; set; }

    }
}
