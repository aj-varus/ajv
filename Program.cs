using System;
using System.Collections.Generic;

namespace ConsignmentShop
{   
    public class LineItem 
    {
        public double ShareToStore { get; set; }
        public double ShareToVendor { get; set; }
    }

    public class Ledger
    {
        private readonly List<LineItem> _lineItems;

        Ledger() {
            _lineItems = new List<LineItem>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
