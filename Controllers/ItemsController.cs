using Microsoft.AspNetCore.Mvc;
using Catalogmain.Repositories;
using System;
using System.Collections.Generic;
using Catalogmain.Entities;
using System.Linq;
using Catalogmain.Dtos;

namespace Catalogmain.Controllers{
    [ApiController]
    [Route("item")]
    public class ItemsController:ControllerBase
    {
        private readonly IItemsRepository repository;
        public ItemsController(IItemsRepository repository){
            this.repository=repository;

        }
        [HttpGet]
        public IEnumerable<ItemDto> GetItems(){
            var items=repository.GetItems().Select(items=>new ItemDto{
                Id=items.Id,
                Name=items.Name,
                Price=items.Price,
                CreatedDate=items.CreatedDate

            });
            return items;

        }
        [HttpGet("{id}")]
        public Item GetItems(Guid id){
            var item=repository.GetItem(id);
            return item;

        }
        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto itemDto){
            Item item=new(){
                Id=Guid.NewGuid(),
                Name=itemDto.Name,
                Price=itemDto.Price,
                CreatedDate=DateTimeOffset.UtcNow


            };
            repository.CrateItem(item);
            return CreatedAtAction(nameof(GetItems),new{id=item.Id},item.ASDto());

        }
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(Guid id){
            var existingItem=repository.GetItem(id);
            if(existingItem is null){
                return NotFound();
            }
            repository.DeleteItem(id);
            return NoContent();

        }
    }
}