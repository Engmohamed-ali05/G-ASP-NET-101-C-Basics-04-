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
            ///  static void printbooktitle(string Title)
            ///   {
            ///     Console.WriteLine("booktitle: " + Title);
            ///   }
            /// THIS MAIN 
            ///  static void Main(string[] args)
            ///   {
            ///     printbooktitle("cleancode");
            //   }




            #endregion


            #region Q5
            /// Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            ///  int pages = 400; and print pages afterward. What do you expect to see, and why?

            ///  static void addbonuspages(int Pages)
            /// {
            /// }
            /// static void Main(string[] args)

            ///  {
            ///    int Pages = 400;

            ///   addbonuspages(pages);

            ///    Console.WriteLine(pages);
            ///  }


            #endregion

            #region Q6
            ///Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            ///  with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            ///see, and why?


            ///   static void Applydiscount(double  []  prices)
            ///   {
            ///       prices[0] -= 5;
            ///   }
            ///  static void Main(string[] args)

            ///  {
            ///  double[]  Prices = {   25.5  ,  40.0   };

            ///     Applydiscount(  Prices  );

            /// Console.WriteLine(  Prices[0]);
            /// }





            #endregion

            #region Q7
            /// Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            /// Call it and print pages afterward. How is the result different from question 5 ?


            /// static void addbonuspagesbyref(ref int pages)
            /// {
            ///     pages += 50;
            ///  }

            /// static void Main(string[] args)
            /// {
            ///   int pages = 400;

            ///   addbonuspagesbyref(ref pages);
            ///   console.writeline(pages);
            /// }





            #endregion


            #region Q8 
            /// Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            /// new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            ///afterward.


            static void replacearray(ref double[] prices)
            {
                prices = new double[] { 10.0, 12.5, 15.0 };
            }

            static void Main(string[] args)
            {
                double[] prices = { 25.5, 40.0 };

                replacearray(ref prices);

Console.WriteLine( prices.Length ); 
            }



            #endregion





























        }





    }
}
