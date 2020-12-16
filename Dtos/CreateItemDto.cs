using System.ComponentModel.DataAnnotations;
namespace Catalogmain.Dtos{
    public record CreateItemDto{
        [Required]
          public string Name { get; init; }
          [Required]
        public decimal Price { get; init; }


    }
}