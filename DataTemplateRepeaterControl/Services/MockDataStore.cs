using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataTemplateRepeaterControl.Models;

namespace DataTemplateRepeaterControl.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> _items;

        public MockDataStore()
        {
            _items = new List<Item>();
            var mockItems = new List<Item>
            {
                new ItemA { Id = Guid.NewGuid().ToString(), Text = "Canada Birth Certificate", Description="Credential A", },
                new ItemA { Id = Guid.NewGuid().ToString(), Text = "MasterCard", Description="Credential B" },
                new ItemA { Id = Guid.NewGuid().ToString(), Text = "Starbucks", Description="Credential Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor", },
                new ItemA { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="Credential C" },
                new ItemA { Id = Guid.NewGuid().ToString(), Text = "Seventh item", Description="Credential C" },
                new ItemA { Id = Guid.NewGuid().ToString(), Text = "Eighth item", Description="Credential C" },
                new ItemA { Id = Guid.NewGuid().ToString(), Text = "Ninth item", Description="Credential C" },
            };

            foreach (var item in mockItems)
            {
                _items.Add(item);
            }
        }
        
        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_items);
        }
    }
}