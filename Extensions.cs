using Catalogmain.Dtos;
using Catalogmain.Entities;
namespace Catalogmain{
    public static class Extensions{
        public static ItemDto ASDto(this Item items){
            return new ItemDto{
                Id=items.Id,
                Name=items.Name,
                Price=items.Price,
                CreatedDate=items.CreatedDate

            };
        }
    }

}