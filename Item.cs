namespace ConsignmentShop
{
    public class Item 
    {
        public string Name { get; set; }
        public double Price { get; set; }

        Status status;

        Item(string name, double price) {
            this.Name = name;
            this.Price = price;
            status = Status.No;

        }


    }
}
