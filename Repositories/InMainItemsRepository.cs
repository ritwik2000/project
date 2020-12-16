using System;
using System.Collections.Generic;
using Catalogmain.Entities;
using System.Linq;
namespace Catalogmain.Repositories{
  

    public class InMainItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron", Price = 20, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Gold", Price = 30, CreatedDate = DateTimeOffset.UtcNow }


        };
        public IEnumerable<Item> GetItems()
        {
            return items;
        }
        public Item GetItem(Guid id)
        {
            return items.Where(items => items.Id == id).SingleOrDefault();

        }

        public void CrateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index= items.FindIndex(existingItem => existingItem.Id==item.Id);
            items[index]=item;
        }
        public void DeleteItem(Guid id){
            var index=items.FindIndex(existingItem=>existingItem.Id==id);
            items.RemoveAt(index);
        }
    }
}