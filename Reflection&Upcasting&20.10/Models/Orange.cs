using System;
namespace Reflection_Upcasting_20._10.Models
{
	public class Orange:Fruit
	{
        private int VitaminC;

        public Orange(double price, string sort, int vitaminC) : base(price, sort)
        {
            VitaminC = vitaminC;
        }

        public override void Taste()
        {
            Console.WriteLine("Turshmeze dadir.");
        }
    }
}

