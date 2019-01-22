using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App1.Models;

namespace App1.Services
{
    class MockBeerDataStore : IDataStore<Beer>
    {
        List<Beer> beers;
        List<Beer> myBeers;

        public MockBeerDataStore()
        {
            myBeers = new List<Beer>();
            beers = new List<Beer>();
            var mockBeers = new List<Beer>
            {
                new Beer
                {
                    Name = "Tyskie",
                    Description =
                        "Gronie to wzorcowy przykład jasnego, pełnego piwa, które od lat cieszy się uznaniem nie tylko w Polsce, ale i na całym świecie."
                }
            };
            foreach (var beer in mockBeers)
            {
                beers.Add(beer);
            }
        }

        public async Task<bool> AddItemAsync(Beer item)
        {
            beers.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Beer item)
        {
            var oldItem = beers.Where((Beer arg) => arg.Id == item.Id).FirstOrDefault();
            beers.Remove(oldItem);
            beers.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = beers.Where((Beer arg) => arg.Id == id).FirstOrDefault();
            beers.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Beer> GetItemAsync(int id)
        {
            return await Task.FromResult(beers.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Beer>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(beers);
        }


        public async Task<IEnumerable<Beer>> GetMyBeersAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(myBeers);
        }


        public async Task<bool> AddMyBeer(Beer beer)
        {
            myBeers.Add(beer);

            return await Task.FromResult(true);
        }
    }
}