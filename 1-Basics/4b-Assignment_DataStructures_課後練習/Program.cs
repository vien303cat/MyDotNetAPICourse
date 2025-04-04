using System;

namespace HelloWorld
{
    internal class Program
    {

        /*
        上課練習
        Data Structures
        Inside of the RunExercise method of the Exercise class, create a dictionary with string keys and decimal values called "itemPrices".
        Set the price for "cheese" to 5.99 and the price for  "carrots" to 2.99.
        Don't forget to end your lines with semicolons (;), and put an "m" after the value you assign to your decimals.
        */

        static void Main(string[] args)
        {
            //Write Your Code Here
            Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>() {
                {"cheese", 5.99m},
                {"carrots", 2.99m}
            };
            // Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>();
            // itemPrices.Add("cheese", 5.99m);
            // itemPrices.Add("carrots", 2.99m);



            //Write You Code Above This Line
            Console.WriteLine(itemPrices["cheese"].GetType());
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);
        }
    }
}