using App1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.Services
{
    class MockBeerDataStore : IDataStore<Beer>
    {
        List<Beer> beers;

        public MockBeerDataStore()
        {
            beers = new List<Beer>();
            var mockBeers = new List<Beer>
            {
                new Beer { Id = Guid.NewGuid().ToString(), Name = "first beer name", Description = "Beer description" },

            };
            foreach (var beer in mockBeers)
            {
                beers.Add(beer);
            }


        }

        public Task<bool> AddItemAsync(Beer item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Beer> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Beer>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Beer item)
        {
            throw new NotImplementedException();
        }
    }
}
