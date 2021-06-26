using System.Collections.Generic;

namespace ConsignmentShop
{
    public class Vendor
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public Vendor(string name) {
            this.Items = new List<Item>();
            this.Name = name;
        }
        
    }
}
