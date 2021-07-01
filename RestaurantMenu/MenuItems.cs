using System;
using System.Text.RegularExpressions;
namespace RestaurantMenu
{
    public class MenuItem


    {
        public string Food { get; set; }
        public string FoodDescription { get; set; }
        public double FoodPrice { get; set; }
        public MenuItem(string afood, string afoodDescription, double afoodPrice)
        {
            Food = afood;
            FoodDescription = afoodDescription;
            FoodPrice = afoodPrice;

        }
        public static Regex rgx = new Regex("[^a-zA-Z]");
        public static MenuItem jalapeno = new MenuItem("Jalapeno poppers", "Jalapenos stuffed with cheese and fried.", 10);
        public static MenuItem stuffedPeppers = new MenuItem("Stuffed Peppers", "Peppers stuffed with ground beef, rice and cheese.", 8);
        public static MenuItem tacosCarneAsada = new MenuItem("Tacos Carne Asada ", "Marinated sirloin grilled to perfection. Comes with tortillas, Pico de Gallo, rice, and beans.", 10);
        public static MenuItem torta = new MenuItem("Torta", "Chopped grilled marinated sirloin on our famous torta bread. Comes with guacamole and Pico de Gallo.", 8);
        public static MenuItem friedIceCream = new MenuItem("Fried Ice Cream", "Encrusted fried ice cream", 5);
        public static string Rgx(string input)
        {
            string user = input.Trim();
            user = rgx.Replace(user, "").ToLower();
            return user;
        }

        public static void NewItem()
        {
            Console.WriteLine("Would you like to add a new item to the menu?");
            string food;
            string foodDesc;
            double foodPrice;
            string input = Console.ReadLine().Trim();
            string user = Rgx(input);

            if (user == "yes")
            {
                Console.Clear();
                Console.WriteLine("What is the new item?");
                input = Console.ReadLine().Trim();
                food = Rgx(input);
                Console.WriteLine("What is the item's description?");
                input = Console.ReadLine().Trim();
                foodDesc = Rgx(input);
                Console.WriteLine("What is the item's price?");
                input = Console.ReadLine().Trim();
                foodPrice = Double.Parse(input);
                Console.Clear();
                MenuItem newItem = new MenuItem(food, foodDesc, foodPrice);
                Menu.PrintMenu();
                Console.WriteLine(Menu.newItems.FoodCatagories);
                Console.WriteLine($"{ food }\n{ foodDesc}\nPrice: ${ foodPrice}\n");
                
            }
        }
    }
        
        
    
  
}
