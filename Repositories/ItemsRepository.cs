using Catalogmain.Entities;
using System;
using System.Collections.Generic;
namespace Catalogmain.Repositories{
      public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        void CrateItem(Item item);

        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}