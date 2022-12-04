using System.ComponentModel.DataAnnotations;

namespace webClientsApi.Entity
{
    public class BaseEntity
    {

        [Key]
        [Required]
        public int Id { get; set; }
    }
}
