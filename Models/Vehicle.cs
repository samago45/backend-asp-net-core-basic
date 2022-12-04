using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace webClientsApi.Entity
{
    public class Vehicle : BaseEntity
    {

        [Required]
        public string Brand { get; set; } = String.Empty;
        [Required]
        public string Model { get; set; } = String.Empty;

      

    }
}
