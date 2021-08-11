using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Dictionary
    {
        Dictionary<string, int> items = new Dictionary<string, int>();
        public void addItem()
        {
            try
            {
                Console.Write("Enter the Number of Items to add : ");
                int numberOfItem = Convert.ToInt32(Console.ReadLine());
                string item;
                int quantity;
                for (int i = 1; i <= numberOfItem; i++)
                {
                    Console.Write("Enter the Item Name : ");
                    item = Console.ReadLine();
                    Console.Write("Enter the Quantity : ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    items.Add(item, quantity);
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Invalid Input : {0}", e);
            }
        }
        public void storeItem()
        {
            Console.WriteLine("Items ---");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0} - {1}", items.Keys.ElementAt(i), items[items.Keys.ElementAt(i)]);
            }
        }
        public void purchaseItem()
        {
            try
            {
                Console.Write("Enter an Item to Purchase  : ");
                string purItem = Console.ReadLine();
                Console.Write("Enter the Quantity of an Item : ");
                int purQuantity = Convert.ToInt32(Console.ReadLine());
                if (items.ContainsKey(purItem))
                {
                    if (items[purItem] == 0)
                    {
                        items.Remove(purItem);
                        Console.WriteLine("Item can't be sold! Item is out of stock.");
                    }
                    else if (purQuantity <= items[purItem] && items[purItem] != 0)
                    {
                        items[purItem] -= purQuantity;
                        Console.WriteLine("{0} {1} purchased successfully!", purQuantity, purItem);
                    }
                    else
                    {
                        Console.WriteLine("Item running low on stock! Only \'{0}\' quantity is available", items[purItem]);
                    }
                }
                else
                {
                    Console.WriteLine("Item can't be sold! Item is out of stock.");
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Invalid Input : {0}", e);
            }
        }
        public static void Main(string[] args)
        {
            Dictionary ob = new Dictionary();
            ob.addItem();
            ob.storeItem();
            ob.purchaseItem();
            Console.ReadKey();
        }
    }
}