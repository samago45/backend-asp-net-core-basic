using System.ComponentModel.DataAnnotations;

namespace webClientsApi.Entity
{
    public class Client : BaseEntity
    {
        [Required]
        public string name { get; set; } = String.Empty;
        [Required]
        public  string LasName { get; set; } = String.Empty;


        
    }
}
