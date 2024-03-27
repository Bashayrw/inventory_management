using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace sda_onsite_2_inventory_management.src
{
    public enum SortOrder
    {
        ASC,
        DESC
    }
    public class Store
    {
        private List<Item> _items;
        private readonly string _name;
        private readonly int _maxCapacity;

        // var store1 = new Store("manuel")
        public Store(string name, int maxCapacity)
        {
            _name = name;
            _items = []; // automatically give the empty array of items
            _maxCapacity = maxCapacity;
        }
        public List<Item> GetItems()
        {
            return _items;
        }
        public int GetMaxCapacity()
        {
            return _maxCapacity;
        }

        public bool AddItems(Item newItem)
        {
            int availableSpace = GetMaxCapacity() - GetCurrentVolume();
            Console.WriteLine($"available space{availableSpace}");

            if (availableSpace < newItem.GetQuantity())
            {
                throw new Exception("sorry, there is no more space");
            }

            Item? foundItem = _items.Find(item => item.GetName() == newItem.GetName());

            if (foundItem is null)
            {
                _items.Add(newItem);
                return true;
            }
            return false;

        }
        public bool RemoveItems(Item newItem)
        {
            _items.Remove(newItem);
            return true;
        }

        public int GetCurrentVolume()
        {
            int totalAmount = 0;
            foreach (Item item in _items)
            {
                totalAmount += item.GetQuantity();
            }
            return totalAmount;
        }

        public Item? FindItemByName(string name)
        {
            var findItem = _items.Find(item => item.GetName() == name);
            // if we find the item, not null, then return the findItem
            if (findItem != null)
            {
                return findItem;
            }
            throw new ArgumentException("cannot find the item!!!");
        }

        public List<Item> SortByNameAsc()
        {
            return _items.OrderBy(item => item.GetName()).ToList();
        }

        public List<Item> SortByDate(SortOrder sort)
        {
            if (sort == SortOrder.ASC)
            {
                var asc = _items.OrderBy(item => item.GetCreatedAt()).ToList();
                return asc;
            }
            else
            {
                var desc = _items.OrderByDescending(item => item.GetCreatedAt()).ToList();
                return desc;
            }
        }

        


    }
}
