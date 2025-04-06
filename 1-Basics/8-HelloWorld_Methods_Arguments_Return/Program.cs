using System;
using System.Text.RegularExpressions;

namespace HelloWorld{
    internal class Program{
        // Main 是靜態的 因此在內部只能調用靜態函式
        static void Main(string[] args){
            int[] intsToCompress = new int[] { 10, 15, 20, 25, 30, 12, 34 };

            // int totalValue = 0;

            // foreach(int intForCompression in intsToCompress)
            // {
            //     if (intForCompression > 20)
            //     {
            //         totalValue += intForCompression;
            //     }
            // }

            // Console.WriteLine(totalValue);

            DateTime startTime = DateTime.Now;

            int totalValue = intsToCompress[0] + intsToCompress[1]
                + intsToCompress[2] + intsToCompress[3]
                + intsToCompress[4] + intsToCompress[5]
                + intsToCompress[6];

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine(totalValue);


            //146

            totalValue = 0;

            startTime = DateTime.Now;

            for (int i = 0; i < intsToCompress.Length; i++)
            {
                totalValue += intsToCompress[i];
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine(totalValue);


            totalValue = 0;

            startTime = DateTime.Now;

            foreach (int intForCompression in intsToCompress)
            {
                totalValue += intForCompression;
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine(totalValue);

            // 希望函式回傳int
            // private int GetSum()
            // void GetSum() 不期待函式回傳值
            // private void GetSum() {
            //     foreach (int intForCompression in intsToCompress){
            //         totalValue += intForCompression;
            //     }
            //     return totalValue;
            // }


            totalValue = 0;

            startTime = DateTime.Now;

            int index = 0;

            while (index < intsToCompress.Length)
            {
                totalValue += intsToCompress[index];
                index++;
            }


            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine(totalValue);
            totalValue = 0;

            startTime = DateTime.Now;

            index = 0;

            do
            {
                totalValue += intsToCompress[index];
                index++;
            }
            while (index < intsToCompress.Length);

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine(totalValue);


            startTime = DateTime.Now;

            totalValue = 0;

            totalValue = intsToCompress.Sum();

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine(totalValue);


            startTime = DateTime.Now;

            totalValue = 0;

            totalValue = GetSum(intsToCompress);

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine(totalValue);

            int[] intsToCompress2 = new int[] { 23, 23, 53, 56, 83, 92 };

            totalValue = GetSum(intsToCompress2);

            Console.WriteLine(totalValue);

        }

        // 將GetSum命名成靜態 放入函式時需要給一個整數陣列命名成intsToCompress 並且會return一個int出去
        static private int GetSum(int[] intsToCompress)
        {
            // int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 34};
            int totalValue = 0;
            foreach (int intForCompression in intsToCompress)
            {
                totalValue += intForCompression;
            }
            return totalValue;
        }
    }
}