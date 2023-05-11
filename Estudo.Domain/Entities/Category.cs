using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estudo.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get;  set; } = string.Empty;

        public bool Status { get;  set; }

        public List<Product> Products { get; set; }
    }
}
