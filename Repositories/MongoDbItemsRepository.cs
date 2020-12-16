using System;
using System.Collections.Generic;
using Catalogmain.Entities;
using System.Linq;
using MongoDB.Driver;
namespace Catalogmain.Repositories{
    public class MongoDbItemsRepository:IItemsRepository
    {
        private const string databaseName="CatalogMain";
        private const string CollectionName="item";
        private readonly IMongoCollection<Item> itemsCollection;
        public MongoDbItemsRepository(IMongoClient mongoClient){
            IMongoDatabase database =mongoClient.GetDatabase(databaseName);
            itemsCollection=database.GetCollection<Item>(CollectionName)

        }
         public void CrateItem(Item item)
        {
            itemsCollection.InsertOne(item);
            
        }

        public void UpdateItem(Item item)
        {
            
        }
        public void DeleteItem(Guid id){
            
        }
    }

    
}