using System.ComponentModel.DataAnnotations;


namespace Estudo.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public decimal Valor { get; private set; }

        public int Quantidade { get; private set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
