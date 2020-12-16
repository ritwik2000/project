using System.ComponentModel.DataAnnotations;


    

namespace Catalogmain{
    public record UpdateItemDto{
        [Required]
          public string Name { get; init;}
          [Required]
        public decimal Price { get; init; }

    }
}