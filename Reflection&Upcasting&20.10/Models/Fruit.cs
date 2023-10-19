using System;
namespace Reflection_Upcasting_20._10.Models
{
	public abstract class Fruit
	{
        private double Price;  //Field adlarini _ ile vermisdim amma ekrana cixaranda seliqesiz gorsenir deye deyishdim.
        private string Sort;
        public Fruit(double price, string sort)
        {
            Price = price;
            Sort = sort;
        }

        public abstract void Taste();
    }
}

