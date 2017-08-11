using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("NewsletterMembers")]
    public class NewsletterMember
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public NewsletterMember(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public NewsletterMember()
        {
        }
    }
}
