using System;
using System.Collections.Generic;
using System.Linq;



namespace PizzaShop
{ /*
    five pizza types, each pizza has four types of ingridients
    2 types of pizza dough
    add some additional items
    custom pizza: choose a custom pizza with four orders
    order more than one pizza
    confirm order
    display total
    */
    class Program
    {

        static void Main(string[] args)
        {
            
            {

                //Console.WriteLine(Pizza.Menu.Length);

                try
                {
                    List<Pizza> pizzaMenu = new List<Pizza>();
                    int i = 0;
                 while (i<4 )
                    {
                        Pizza.addItems(pizzaMenu);
                        i++;
                        
                    }
                    Pizza.showMenu(pizzaMenu);

                }
                catch (Exception exception)
                {
                    Console.WriteLine( exception);
                }
            }
            
        }

    }

    public class Pizza // layout of a PIZZA, add up a menu and define menu items
    {
        public string pizzaName { get; set; }


        public string dough { get; set; }
        public string size { get; set; }
        public double price { get; set; }

        public static List<string> ingridients { get; set; }

        public static List<Pizza> Menu { get; set; }

        public Pizza(string _name, List<string> _ingridients, string _dough, string _size, double _price)

        {
            pizzaName = _name;
            ingridients = _ingridients;
            dough = _dough;
            size = _size;
            price = _price;
        }

        public static void addItems(List<Pizza> menuList)
        {



            Console.WriteLine("What's the name of the pizza to be added to menu?");
            string name = Console.ReadLine();
            Console.WriteLine("What are the ingrideints you want to add");
            string input = Console.ReadLine();
            string[] listItems = input.Split(",");
            List<string> pizzaIngridients = listItems.ToList();
            Pizza.ingridients = pizzaIngridients;
            string pizzaDough = "ordinary";
            string pizzaSize = "normal";
            double pizzaPrice = 6.5;
            Pizza menuitem = new Pizza(name, pizzaIngridients, pizzaDough, pizzaSize, pizzaPrice);
            menuList.Add(menuitem);
            Menu = menuList;

        }


        public static void showMenu(List<Pizza> showableMenu)
        {

            List<string> printableMenu = Pizza.Menu.ConvertAll(x => x.ToString());
            printableMenu.ForEach(Console.WriteLine);

        }






    }
}
public class Additionals
{
    public List<string> additionals;
}


public class Orders
{

}
public class SumOrder
{
    
}
