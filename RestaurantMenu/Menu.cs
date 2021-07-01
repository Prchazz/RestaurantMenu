using System;
using System.IO;

namespace RestaurantMenu
{
    public class Menu
    {
        public string FoodCatagories { get; set; }
        public static Menu appetizers = new Menu("Appetizers");
        public static Menu mainCourse = new Menu("Main Course");
        public static Menu dessert = new Menu("Dessert");
        public static Menu newItems = new Menu("**Brand New Selection**");
        public Menu(string afood)
        {
            FoodCatagories = afood;
        }
        public static string GetTimeStamp ( DateTime value )
        {
            return value.ToString("yyyy/MM/dd/HHmm");
        }
        public static void PrintMenu()
        {
            Console.WriteLine("\tTacos 'n More");
            Console.WriteLine(appetizers.FoodCatagories);
            Console.WriteLine($"{MenuItem.jalapeno.Food}\n{MenuItem.jalapeno.FoodDescription}\nPrice: ${MenuItem.jalapeno.FoodPrice}\n");
            Console.WriteLine($"{MenuItem.stuffedPeppers.Food}\n{MenuItem.stuffedPeppers.FoodDescription}\nPrice: ${MenuItem.stuffedPeppers.FoodPrice}\n");
            Console.WriteLine(mainCourse.FoodCatagories);
            Console.WriteLine($"{MenuItem.tacosCarneAsada.Food}\n{MenuItem.tacosCarneAsada.FoodDescription}\nPrice: ${MenuItem.tacosCarneAsada.FoodPrice}\n");
            Console.WriteLine($"{MenuItem.torta.Food}\n{MenuItem.torta.FoodDescription}\nPrice: ${MenuItem.torta.FoodPrice}\n");
            Console.WriteLine(dessert.FoodCatagories);
            Console.WriteLine($"{MenuItem.friedIceCream.Food}\n{MenuItem.friedIceCream.FoodDescription}\nPrice: ${MenuItem.friedIceCream.FoodPrice}\n");
        }


    }
}
