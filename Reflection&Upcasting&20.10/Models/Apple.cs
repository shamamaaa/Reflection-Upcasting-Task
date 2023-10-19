using System;
namespace Reflection_Upcasting_20._10.Models
{
    public class Apple : Fruit
    {
        private int VitaminA;
        private int VitaminB;

        public Apple(double price, string sort, int vitaminA, int vitaminB) : base(price, sort)
		{
			VitaminA=vitaminA;
			VitaminB=vitaminB;
		}


        public override void Taste()
        {
            Console.WriteLine("Shirin turs dadir.");
        }
}
}

