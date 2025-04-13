using System;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Computer
    {
        // private string _motherboard;
        // private string Motherboard { get{ return _motherboard; }; set { _motherboard = value }; };

        public string Motherboard { get; set; } = "default"; //設定預設值為空字串
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } = "default";//設定預設值為空字串

        // 也可以使用這個方法來設定預設值或是更改值
        // public Computer()
        // {
        //     if (VideoCard == null)
        //     {
        //         VideoCard = "";
        //     }
        //     if (Motherboard == null)
        //     {
        //         Motherboard = "";
        //     }
        // }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 由於上面有個public class Computer，所以這裡可以直接使用Computer這個類別
            Computer myComputer = new Computer()
            {
                Motherboard = "Z690",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 943.87m,
                // VideoCard = "RTX 2060"
            };
            // myComputer.HasWifi = false;
            Console.WriteLine(myComputer.Motherboard);
            Console.WriteLine(myComputer.HasWifi);
            Console.WriteLine(myComputer.ReleaseDate);
            Console.WriteLine(myComputer.VideoCard);
        }

    }
}


// namespace HelloWorld
// {
//     public class Computer
//     {
//         // private string _motherboard;
//         public string Motherboard { get; set; }
//         public int CPUCores { get; set; }
//         public bool HasWifi { get; set; }
//         public bool HasLTE { get; set; }
//         public DateTime ReleaseDate { get; set; }
//         public decimal Price { get; set; }
//         public string VideoCard { get; set; }

//         public Computer()
//         {
//             if (VideoCard == null)
//             {
//                 VideoCard = "";
//             }
//             if (Motherboard == null)
//             {
//                 Motherboard = "";
//             }
//         }
//     }
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Computer myComputer = new Computer()
//             {
//                 Motherboard = "Z690",
//                 HasWifi = true,
//                 HasLTE = false,
//                 ReleaseDate = DateTime.Now,
//                 Price = 943.87m,
//                 VideoCard = "RTX 2060"
//             };
//             myComputer.HasWifi = false;
//             Console.WriteLine(myComputer.Motherboard);
//             Console.WriteLine(myComputer.HasWifi);
//             Console.WriteLine(myComputer.ReleaseDate);
//             Console.WriteLine(myComputer.VideoCard);
//             // Console.WriteLine(myComputer.CPUCores);
//         }

//     }
// }