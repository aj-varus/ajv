using System.Collections.Generic;

namespace ConsignmentShop
{
    public static class Ledger
    {
        public static List<LineItem> LineItems;

        static Ledger() {
            LineItems = new List<LineItem>();
        }
    }
}