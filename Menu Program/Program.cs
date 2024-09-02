using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Program
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________ITAEWON CLASS____________________");
            Console.WriteLine("...................KOREAN CUISINE!!..................");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("WWW.ITAEWONCLASS.Com");
            Console.WriteLine("011 257 1345");
            Console.WriteLine("");
            Console.WriteLine("");

            // Appetizers
            Console.WriteLine("_Appetizers_");
            Console.WriteLine("01) Toppokki - RS 1200.00");
            Console.WriteLine("02) Japchae - RS 800.00");
            Console.WriteLine("03) Chicken Nugget - RS 1500.00");
            Console.WriteLine("04) Fried Fish Ball - RS 700.00");
            Console.WriteLine("05) Onion Ring - RS 800.00");
            Console.WriteLine("");

            // Main course
            Console.WriteLine("_Main Course_ ");
            Console.WriteLine("01) Kimchi Fried Rice - RS 1450.00");
            Console.WriteLine("02) Bibimbap - RS 1500.00");
            Console.WriteLine("03) Kimchi Jjigae - RS 1300.00");
            Console.WriteLine("04) Bossam & Jokbal set - RS 4000.00 ");
            Console.WriteLine("05) Galbi - RS 5500.00");
            Console.WriteLine("06) Jjajangmyeon - RS 2500.00");
            Console.WriteLine("07) Gimbap - RS 1200.00");
            Console.WriteLine("08) Bulgogi - RS 3000.00");
            Console.WriteLine("");

            // Drinks
            Console.WriteLine("_Drinks_");
            Console.WriteLine("01) Milkshake - RS 800.00");
            Console.WriteLine("02) Ice Tea - Rs 600.00");
            Console.WriteLine("03) Coffee - RS 500.00");
            Console.WriteLine("04) Coke/Soda - Rs 400.00");
            Console.WriteLine("");

            // Variables
            float totalBill = 0;

            // Start ordering process
            for (int i = 0; i < int.MaxValue; i++) // Loop until break
            {
                Console.WriteLine("Enter your Dish Type: (A for Appetizers, M for Main Course, D for Drinks, X to Exit)");
                string orderType = Console.ReadLine().ToUpper();

                if (orderType == "X")
                {
                    // Exit the ordering process
                    break;
                }

                Console.WriteLine("Enter your order number:");
                string orderNo = Console.ReadLine();

                Console.WriteLine("Enter Quantity:");
                string quantity = Console.ReadLine();

                // Converting string to integer
                int qty = Convert.ToInt32(quantity);
                float unitPrice = 0;

                // Identify the type and calculate the unit price accordingly
                if (orderType == "A")
                {
                    if (orderNo == "01")
                        unitPrice = 1200;
                    else if (orderNo == "02")
                        unitPrice = 800;
                    else if (orderNo == "03")
                        unitPrice = 1500;
                    else if (orderNo == "04")
                        unitPrice = 700;
                    else if (orderNo == "05")
                        unitPrice = 800;
                    else
                    {
                        Console.WriteLine("Invalid Order Number.");
                        continue;
                    }
                }
                else if (orderType == "M")
                {
                    if (orderNo == "01")
                        unitPrice = 1450;
                    else if (orderNo == "02")
                        unitPrice = 1500;
                    else if (orderNo == "03")
                        unitPrice = 1300;
                    else if (orderNo == "04")
                        unitPrice = 4000;
                    else if (orderNo == "05")
                        unitPrice = 5500;
                    else if (orderNo == "06")
                        unitPrice = 2500;
                    else if (orderNo == "07")
                        unitPrice = 1200;
                    else if (orderNo == "08")
                        unitPrice = 3000;
                    else
                    {
                        Console.WriteLine("Invalid Order Number.");
                        continue;
                    }
                }
                else if (orderType == "D")
                {
                    if (orderNo == "01")
                        unitPrice = 800;
                    else if (orderNo == "02")
                        unitPrice = 600;
                    else if (orderNo == "03")
                        unitPrice = 500;
                    else if (orderNo == "04")
                        unitPrice = 400;
                    else
                    {
                        Console.WriteLine("Invalid Order Number.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Dish Type.");
                    continue;
                }

                // Calculate the price for the current order
                float price = unitPrice * qty;
                totalBill += price;

                Console.WriteLine("Order added! Current total: RS " + totalBill);
            }

            // Display final bill
            Console.WriteLine("Your final bill is: RS " + totalBill);
            Console.WriteLine("Thank you for your order!");

            Console.ReadLine();
        }
    }
}