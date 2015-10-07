using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Mcs.Model
{
    [Table(Name = "Dish")]
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Description { get; set; }

        [Column]
        public double Price { get; set; }

        [Column]
        public int Mcat_Id { get; set; }

        [Column]
        public bool Archived { get; set; }        
    }
}
