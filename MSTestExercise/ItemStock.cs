using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTestExercise
{
    public class ItemStock
    {
        private readonly Dictionary<Item, int> _stock = new Dictionary<Item, int>();

        public int GetNum(Item item)
        {
            if (!_stock.ContainsKey(item)) return 0;

            return _stock[item];
        }

        public void Add(Item item)
        {
            if (!_stock.ContainsKey(item))
            {
                _stock.Add(item, 1);
                return;
            }
            _stock[item]++;
        }
    }

    public class Item
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
