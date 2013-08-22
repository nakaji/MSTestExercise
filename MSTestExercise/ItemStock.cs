using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTestExercise
{
    public class ItemStock
    {
        private int num=0;

        public int GetNum(Item item)
        {
            return num;
        }

        public void Add(Item item)
        {
            num++;
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
