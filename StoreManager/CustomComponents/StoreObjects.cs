using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreObjects
{

    public class Item
    {
        public int Id { get; }
        public string Name { get; }
        public string Size { get; }
        public double Price { get; }

        public Item(int id, string name, string size, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Size = size;
            this.Price = price;
        }

        public CartItem ToCartItem()
        {
            return new CartItem(this.Id, this.Name, this.Size, this.Price);
        }

    }

    public class CartItem
    {
        public int Id { get; }
        public string Name { get; }
        public string Size { get; }
        public double Price;
        private int qty = 1;

        public CartItem(int id, string name, string size, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Size = size;
            this.Price = price;
        }

        public void IncrementQty()
        {
            qty++;
        }

        public void DecrementQty()
        {
            if (qty > 0)
            {
                qty--;
            }
        }

        public int Qty
        {
            get { return qty; }

        }
    }
}
