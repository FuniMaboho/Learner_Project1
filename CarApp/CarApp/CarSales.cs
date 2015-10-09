using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class CarSales
    {
        public int i, j;

        string[,] car = new string[5, 2] { { "Toyota Tazz", "59000" }, { "Toyota Yaris", "95000" }, { "Toyota Corolla", "119000" }, { "Toyota RAV4", "139000" }, { "Toyota Auris", "129000" } };
        string[,] sound = new string[5, 2] { { "Panasonic", "11000" }, { "Sony", "15000" }, { "Samsung", "19000" }, { "LG", "12000" }, { "Hisense", "9000" } };
        string[,] Wheels = new string[5, 2] { { "Continental", "12000" }, { "Bridgestone", "15000" }, { "Firestone", "9000" }, { "Toyo", "8000" }, { "Tiger", "19000" } };
        string[,] rims = new string[5, 2] { { "Painted", "10000" }, { "Polished", "5500" }, { "Machine brushed", "9000" }, { "Two-Toned", "29000" }, { "Chrome", "19000" } };
        string[,] brakes = new string[5, 2] { { "Disc Brake", "5000" }, { "Drum", "6000" }, { "Power Brake", "9000" }, { "Centre-Pull Brake", "4000" }, { "Dise-Pull Brake", "4500" } };
        string[,] engine = new string[5, 2] { { "V6 engine", "4500" }, { "V8 engine", "5000" }, { "V12 engine", "9000" }, { "Petrol engine", "3500" }, { "Diesel engine", "4000" } };

        public void choiceChosen(string selection, string [,] arr)
        {
            int price = 0;
            
                if (arr == car)
                {

                    while (selection == "0")
                    {
                        Console.WriteLine("You have not selected a car. Please select a car");
                        selection = Console.ReadLine();
                       
                    }
                    

                }
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("You have selected a " + arr[0, 0] + " for the price of R" + arr[0, 1]);
                        price = Convert.ToInt32(arr[0, 1]);
                    break;

                    case "2":
                        Console.WriteLine("You have selected a " + arr[1, 0] + " for the price of R" + arr[1, 1]);
                        price = Convert.ToInt32(arr[1, 1]);
                    break;

                    case "3":
                        Console.WriteLine("You have selected a " + arr[2, 0] + " for the price of R" + arr[2, 1]);
                        price = Convert.ToInt32(arr[2, 1]);
                    break;

                    case "4":
                        Console.WriteLine("You have selected a " + arr[3, 0] + " for the price of R" + arr[3, 1]);
                        price = Convert.ToInt32(arr[3, 1]);
                    break;

                    case "5":
                        Console.WriteLine("You have selected a " + arr[4, 0] + " for the price of R" + arr[4, 1]);
                        price = Convert.ToInt32(arr[4, 1]);
                    break;

                    case "0":
                        Console.WriteLine("You have not selected an item");
                        price += 0;
                    break;

                    default:

                        Console.WriteLine("You have entered an incorrect value ");

                        price += 0;
                    selection = Console.ReadLine();


                        break;
                }

                price += total_price(price);
            
           


        }

        public void display(string [,] arr)
        {
            for (j = 0; j < 5; j++)
            {
                Console.WriteLine("");

                for (i = 0; i < 2; i++)
                {
                    Console.Write(arr[j, i] + "\t");
                }

            }
        }

        public int total_price(int total_price)
        {
            int price = 0;
            
                price += total_price;
            

            Console.WriteLine("\nThe Total Amount that you owe after adding extras is: " + Convert.ToString(price));
            return price;
        }

        public void output(string carSelection)
        {

            display(car);

            Console.Write("\n\n=>> ");
            carSelection = Console.ReadLine();



            choiceChosen(carSelection, car);

            display(sound);

            Console.Write("\n\n=>> ");
            carSelection = Console.ReadLine();
            choiceChosen(carSelection, sound);

            display(Wheels);

            Console.Write("\n\n=>> ");
            carSelection = Console.ReadLine();
            choiceChosen(carSelection, Wheels);

            display(rims);

            Console.Write("\n\n=>> ");
            carSelection = Console.ReadLine();
            choiceChosen(carSelection, rims);


            display(engine);

            Console.Write("\n\n=>> ");
            carSelection = Console.ReadLine();
            choiceChosen(carSelection, engine);

            display(brakes);

            Console.Write("\n\n=>> ");
            carSelection = Console.ReadLine();
            choiceChosen(carSelection, brakes);

        }
    }
}
