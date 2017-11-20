using System.Collections.Generic;

namespace RestaurantReceipt
{
    public class Tab
    {
        public List<double> items = new List<double>();
        
        public void Add(double number)
        {           
            items.Add(number);
        }

        public override string ToString()
        {
            return $"Items count: {items.Count}";
        }
    }
}