using System.Collections.Generic;

namespace ConsignmentShop
{
    public class Vendor
    {
        public string Name { get; set; }
        private readonly List<Item> _items;

        Vendor(string name) {
            this._items = new List<Item>();
            this.Name = name;
        }
        
    }
}
