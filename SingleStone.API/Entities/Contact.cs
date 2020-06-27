using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SingleStone.API.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Name name { get; set; }

        [Required]
        public Address address { get; set; }

        [Required]
        public List<Phone> phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

    }
}
