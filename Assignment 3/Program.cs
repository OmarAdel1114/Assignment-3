namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 01
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Question 02
            //int[,] shelfCopies = {
            //    { 3,5 },
            //    { 1,4 }
            //};
            //Console.WriteLine(shelfCopies[1,0]);

            #endregion

            #region Question 03
            //PrintWelcomeMessage();
            #endregion

            #region Question 04
            //PrintBookTitle("Clean Code");
            #endregion

            #region Question 05
            //int pages = 400;
            //Console.WriteLine(pages);   
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            // I am Expecting no change in the value of pages
            // because the method AddBonusPages is passing the value of pages by value and prices is a value type so the original value of pages will not change
            #endregion

            #region Question 06
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine(prices[0]);
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // I am Expecting that the value of prices[0] will change because we are passing by value but prices here is of type array which is reference type
            #endregion

            #region Question 07
            //int pages = 400;    
            //Console.WriteLine(pages);
            //AddBonusPages(ref pages);
            //Console.WriteLine(pages);
            // this time we are passing by reference so the oringinal pages value will change

            #endregion

            #region Question 08
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion

            #region Question 09
            //string title = "Clean Code";
            //double price;
            //TryGetPrice(title, out price);
            //Console.WriteLine(price);
            #endregion

            #region Question 10
            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Clean Code", 300);

            #endregion

            #region Question 11
            //PrintBookInfo(pages: 250, title: "Clean Code");
            #endregion

            #region Question 12
            //string[] title = { "Clean Code", "C# Basics", "OOP" };
            //PrintAllTitles(title);
            #endregion


        }

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        public static void PrintBookTitle(string title) 
        { 
            Console.WriteLine("Book Title: " + title);
        }
        public static void AddBonusPages(ref int pages) 
        {
            pages += 50;   
        }
        public static void ApplyDiscount(double[] prices) 
        {
            prices[0] -= 5;
        }
        public static void ReplaceArray(ref double[] prices) 
        {
            prices = [10.0, 12.5, 15.0];

        }
        public static bool TryGetPrice(string title, out double price) 
        {
            if (title == "Clean Code") 
            {
                price = 25.5;
                return true;
            }   
            else
                price = 0;
                return false;
        }
        public static void PrintBookInfo(string title, int pages = 300) 
        { 
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }
        public static void PrintAllTitles(params string[] titles) {
            foreach (string title in titles) { 
                Console.WriteLine(title);
            } 
        }




    }
}
