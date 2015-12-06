using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfChildren = 0;
            int NumberOfAdults = 0;
            int NumberOfSeniors = 0;
            int TotalAttendies = 0;

            double TotalMovieCost = 0;

            int SmallSodaQty;
            int LargeSodaQty;
            int HotDogQty;
            int PopCornQty;
            int CandyQty;

            double TotalFoodPrice = 0;

            const double SmallSoda = 3.50;
            const double LargeSoda = 5.99;
            const double HotDog = 3.99;
            const double Popcorn = 4.50;
            const double Candy = 1.99;

            double GrandTotal = 0;

            int SodaCornDiscountQty = 0;
            int FreePopcornQty = 0;
            int CandyDiscountQty = 0;

            System.Console.WriteLine("Matinee Movie Prices");
            System.Console.WriteLine("Evening Movie Prices");
            Movie ChildMatinee = new Movie("Child Matinee Movie ", 3.99);
            Movie ChildEvening = new Movie("Child Evening Movie ", 6.99);
            ChildMatinee.Print();
            ChildEvening.Print();

            System.Console.WriteLine("Matinee Movie Prices");
            System.Console.WriteLine("Evening Movie Prices");
            Movie AdultMatinee = new Movie("Adult Matinee Movie ", 5.99);
            Movie AdultEvening = new Movie("Adult Evening Movie ", 10.99);
            AdultMatinee.Print();
            AdultEvening.Print();

            System.Console.WriteLine("Matinee Movie Prices");
            System.Console.WriteLine("Evening Movie Prices");
            Movie SeniorMatinee = new Movie("Senior Matinee Movie", 4.50);
            Movie SeniorEvening = new Movie("Senior Evening Movie", 8.50);
            SeniorMatinee.Print();
            SeniorEvening.Print();

            System.Console.WriteLine("Would you like to see a Matinee Showing?");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                System.Console.WriteLine("How many child tickets?");
                NumberOfChildren = int.Parse(System.Console.ReadLine());
                ChildMatinee.Pricing(NumberOfChildren);
                TotalMovieCost += ChildMatinee.MovieTotals();

                System.Console.WriteLine("How many adult tickets?");
                NumberOfAdults = int.Parse(System.Console.ReadLine());
                AdultMatinee.Pricing(NumberOfAdults);
                TotalMovieCost += AdultMatinee.MovieTotals();

                System.Console.WriteLine("How many senior tickets?");
                NumberOfSeniors = int.Parse(System.Console.ReadLine());
                SeniorMatinee.Pricing(NumberOfSeniors);
                TotalMovieCost += SeniorMatinee.MovieTotals();
            }
            else
            {
                System.Console.WriteLine("How many children tickets?");
                NumberOfChildren = int.Parse(System.Console.ReadLine());
                ChildEvening.Pricing(NumberOfChildren);
                TotalMovieCost += ChildEvening.MovieTotals();

                System.Console.WriteLine("How many adult tickets?");
                NumberOfAdults = int.Parse(System.Console.ReadLine());
                AdultEvening.Pricing(NumberOfAdults);
                TotalMovieCost += AdultEvening.MovieTotals();

                System.Console.WriteLine("How many senior tickets?");
                NumberOfSeniors = int.Parse(System.Console.ReadLine());
                SeniorEvening.Pricing(NumberOfSeniors);
                TotalMovieCost += SeniorEvening.MovieTotals();
            }


            System.Console.WriteLine("How many of each item you would like");

            System.Console.Write("Small Soda $" + SmallSoda + ": ");
            SmallSodaQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (SmallSodaQty * SmallSoda);

            System.Console.Write("Large Soda $" + LargeSoda + ": ");
            LargeSodaQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (LargeSodaQty * LargeSoda);

            System.Console.Write("Hot Dog    $" + HotDog + ": ");
            HotDogQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (HotDogQty * HotDog);

            System.Console.Write("Popcorn    $" + Popcorn + ": ");
            PopCornQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (PopCornQty * Popcorn);

            System.Console.Write("Candy      $" + Candy + ": ");
            CandyQty = int.Parse(System.Console.ReadLine());
            TotalFoodPrice += (CandyQty * Candy);

            System.Console.WriteLine("Totals before discounts applied");
            System.Console.WriteLine("Movie Cost: $" + TotalMovieCost);
            System.Console.WriteLine("Snack Cost: $" + TotalFoodPrice);
            GrandTotal = TotalMovieCost + TotalFoodPrice;
            System.Console.WriteLine("Total: $" + GrandTotal);

            {
                if (PopCornQty < LargeSodaQty)
                {
                    SodaCornDiscountQty = PopCornQty;
                }

                else if (LargeSodaQty > PopCornQty)
                {
                    SodaCornDiscountQty = LargeSodaQty;
                }
                else
                {
                    SodaCornDiscountQty = LargeSodaQty;
                }
            }

            TotalAttendies = NumberOfAdults + NumberOfChildren + NumberOfSeniors;

            if (TotalAttendies >= 3)
            {
                FreePopcornQty = TotalAttendies / 3;
            }

            if (CandyQty >= 4)
            {
                CandyDiscountQty = CandyQty / 4;
            }

            System.Console.WriteLine("Total Discounts Earned");
            System.Console.WriteLine("$2.00 off Tickets earned: " + SodaCornDiscountQty);
            System.Console.WriteLine("Number of Free Popcorn earned: " + FreePopcornQty);
            System.Console.WriteLine("Number of Free Candy earned: " + CandyDiscountQty);

            GrandTotal = GrandTotal - (SodaCornDiscountQty * 2) - (FreePopcornQty * Popcorn) - (CandyDiscountQty * Candy);

            System.Console.WriteLine("Total After Discounts Applied");
            System.Console.WriteLine("Total: $" + GrandTotal);

            System.Console.ReadKey();
        }


    }
}
