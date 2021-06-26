namespace ConsignmentShop
{
    public class LineItem 
    {
        public double ShareToStore { get; set; }
        public double ShareToVendor { get; set; }

        public LineItem(double shareToStore, double shareToVendor)
        {
            this.ShareToStore = shareToStore;
            this.ShareToVendor = shareToVendor;
        }
    }
}