using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace discountController.Models
{
    public class Item
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
