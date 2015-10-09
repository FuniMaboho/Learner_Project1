using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
          //  int price = 0;
            string carSelection;

            CarSales car_purchase = new CarSales();

             Console.WriteLine("Welcome to Toyota!!\nPlease select a car from the list below to purchase:");
                Console.WriteLine("(write a number from 1 to 5 as your selection key)");
            //Console.ReadKey();

            carSelection = Console.ReadLine();
            car_purchase.output(carSelection);

           // price += car_purchase.total_price(price);
          //  Console.WriteLine("price: " + price);
            Console.ReadKey();
        }
    }
}
