using Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User : BaseEntity<long>
    {
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [Required]
        [StringLength(500)]
        public string PasswordHash { get; set; }
        [Required]
        [StringLength(200)]
        public string FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset DateTimeOffset { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
