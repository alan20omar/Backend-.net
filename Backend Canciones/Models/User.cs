using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Backend_Canciones.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(40)]
        public string Name { get; set; }

        [Required, MaxLength(40)]
        public string Last_name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required, Range(0, 1), DefaultValue(true)]
        public double Volume { get; set; }

        [Required, DefaultValue(true)]
        public bool Active { get; set; }

        [DefaultValue("[]")]
        public string Play_queue { get; set; }
    }
}
