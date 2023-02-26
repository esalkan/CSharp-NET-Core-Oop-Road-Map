using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_09_ExerciseProject
{
    public class Product : BaseClass
    {
        public string brand { get; set; } // Let the product be added within the brands we have specified.
        public string model { get; set; }

        private decimal _buyingPrice;
        public decimal buyingPrice
        {
            get
            {
                return _buyingPrice;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Purchase price cannot be less than or equal to zero...");
                }
                else
                {
                    _buyingPrice = value;
                }
            }
        }    // Purchase price cannot be less than or equal to zero

        private decimal _sellingPrice;
        public decimal sellingPrice
        {
            get { return _sellingPrice; }
            set
            {
                if (value <= _buyingPrice)
                {
                    Console.WriteLine("Selling price cannot be less than or equal to Buying Price");
                }
                else
                {
                    _sellingPrice = value;
                }
            }
        }   // Selling price cannot be less than or equal to purchase price.

        public decimal _campaignPrice;
        public decimal campaignPrice 
        {
            get { return _campaignPrice; }  
            set 
            {
                if (value <= 0 )
                {
                    Console.WriteLine("Campaign price cannot be less than or equal to zero...");
                }
                else
                {
                    _campaignPrice = value; 
                }
            }
        }  // Campaign price cannot be less than or equal to zero.

    }
}
