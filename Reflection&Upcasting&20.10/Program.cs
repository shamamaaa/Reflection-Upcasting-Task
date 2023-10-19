using System.Reflection;
using Reflection_Upcasting_20._10.Models;

namespace Reflection_Upcasting_20._10;
class Program
{
    static void Main(string[] args)
    {

        Apple apple = new Apple(1.5, "Fuji", 40, 50);
        Orange orange = new Orange(2.8, "Cara-Cara", 120);
        Pineapple pineapple = new Pineapple(5.5, "Sugarloaf", 42, 51);
        Fruit[] basket = { apple, orange, pineapple };

        Console.WriteLine("--------------------");

        foreach (Fruit fruit in basket)
        {

            Type type = fruit.GetType();
            Console.WriteLine("Type: " + fruit.GetType().Name);
            FieldInfo[] basefields = typeof(Fruit).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);  //base classin fieldlerin
            foreach (FieldInfo field in basefields)
            {

                Console.WriteLine($"{field.Name}: {field.GetValue(fruit)}");

            }
            FieldInfo[] fields = fruit.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);  
            foreach (FieldInfo field in fields)
            {

                Console.WriteLine($"{field.Name}: {field.GetValue(fruit)}");

            }
            fruit.Taste();
            Console.WriteLine("--------------------");
        }

        Console.ReadLine();

    }
}

