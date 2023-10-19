using System;
namespace Reflection_Upcasting_20._10.Models
{
	public class Pineapple:Fruit
	{
        private int VitaminE;
        private int VitaminD;

        public Pineapple(double price, string sort, int vitaminE, int vitaminD) : base(price, sort)
		{
			VitaminE = vitaminE;
			VitaminD = vitaminD;
		}

        public override void Taste()
        {
            Console.WriteLine("Tropik dadir."); 
        }
    }
}

