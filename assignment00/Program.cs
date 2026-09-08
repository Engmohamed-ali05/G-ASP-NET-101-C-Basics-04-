using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment00
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region   Q1        
            // Q1:1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).

            ///     double[] prices = { 25., 40.0, 33.75 };

            ///Console.WriteLine(prices[1]);
            #endregion

            #region
            ///  Q2 : 2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            /// shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            ///  int[,] shelfcopies =
            ///    {
            ///    { 3, 5 }, { 1, 4 }

            /// }; 

            /// Console.WriteLine ( shelfcopies [1, 0] );

            #endregion

            #region Q3
            /// q3 : 3-Write a method called PrintWelcomeMessage that takes no parameters and prints
            /// "Welcome to the Library!".Call it from Main.
            /// fun out of main 
            ///   static void printwelcomemessage()
            ///    {
            ///         Console.WriteLine("Welcometo Library !");
            ///     }

            /// this main 
            ///    static void Main(string[] args)
            ///   {
            ///      printwelcomemessage();
            ///   }



            #endregion

            #region     Q4

            /// q4 : 4-Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            /// "Clean Code".
            /// OUT OF MAIN 
            static void printbooktitle(string Title)
            {
                Console.WriteLine("booktitle: " + Title);
            }
            /// THIS MAIN 
            static void Main(string[] args)
            {
                printbooktitle("cleancode");
            }




            #endregion

































        }





    }
}
