using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 陣列 (Array) 是一種資料結構，可以用來儲存多個相同類型的資料。陣列的大小需要提前說，並且可以使用索引來存取其中的元素。
            // string[] myGroceryArray = {"Cheese", "Milk"};
            string[] myGroceryArray = ["Cheese", "Milk"];
            // string[] myGroceryArray = new string[2];

            // myGroceryArray[0] = "Cheese";
            // myGroceryArray[1] = "Milk";

            myGroceryArray[1] = "Yogurt";
            // myGroceryArray[2] = "Yogurt";

            // Console.WriteLine(myGroceryArray[0]);
            // Console.WriteLine(myGroceryArray[1]);


            // 清單 (List) 是一種資料結構，可以用來儲存多個相同類型的資料。清單的大小不需要提前說，並且可以使用索引來存取其中的元素。
            List<string> myGroceryList = ["Ice Cream", "Crackers"];
            // List<string> myGroceryList = new List<string>();

            // myGroceryList.Add("Ice Cream");
            // myGroceryList.Add("Crackers");

            // Console.WriteLine(myGroceryList[0]);
            // Console.WriteLine(myGroceryList[1]);


            // IEnumerable 可讀集合 (可用foreach迴圈讀取 但不能用for因為沒有index)
            IEnumerable<string> myGroceryEnumerable = myGroceryList;

            // 若有需要可以將IEnumerable轉換成List (才能使用索引、改值...等操作)
            List<string> mySecondGroceryList = myGroceryEnumerable.ToList();

            // 等同於PHP[][][] C#需要先定義陣列大小及維度
            int[,,] myMultiDimensionalArray = {
                { //0
                    {1, 2}, //0
                    {3, 4}, //1
                    {5, 6}  //2
                },
                { //1
                    {7, 8}, //0
                    {9, 10}, //1
                    {11, 12}  //2
                }
            };

            // Console.WriteLine(myMultiDimensionalArray[0,0,1]);
            // Console.WriteLine(myMultiDimensionalArray[1,2,1]);

            // Dictionary<TKey, TValue> 是 一種 key-value（鍵值對）資料結構，它可以用來存放一組有關聯的資料。 例如JSON格式的資料 (感覺蠻常會用到 可以當作php的object來使用)
            Dictionary<string, int> groceryPrices = new Dictionary<string, int>();

            groceryPrices["Cheese"] = 5;
            groceryPrices["Yogurt"] = 3;

            Console.WriteLine(groceryPrices["Cheese"]);
            Console.WriteLine(groceryPrices["Yogurt"]);
            // Console.WriteLine(groceryPrices["Random"]);


            // 資料操作語法
            // .ContainsKey("key") 判斷是否有這個key
            // .TryAdd(key, value) 嘗試新增一個key-value對，如果key已經存在則不會新增，並且返回false

        }
    }
}