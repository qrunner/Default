using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Mcs.Model
{
    [Table(Name = "mcat")]
    public class MenuCategory
    {
        [Key]
        public int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public int? Parent_Id { get; set; }

        [Column]
        public int Place_Id { get; set; }

        [Column]
        public bool Archived { get; set; }
    }
}