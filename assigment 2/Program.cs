using System;
namespace assigment_2
{
    class Program
    {
        static void Main()
        {
            string GoAgain;
            do
            {
                Calcs();              
                Console.WriteLine("Would you like to go again? Y/N");
                GoAgain = Console.ReadLine().ToUpper();
            } while (GoAgain == "Y");
            
            
        }
        static void Calcs()
        {
            for (int i = 0; i < 10; i++)
            {
             Random rnd = new Random();
             int iNum1 = rnd.Next(0, 10);
             int iNum2 = rnd.Next(0, 10);
             Incorrect:
             Console.WriteLine("What is " + iNum1 + " * " + iNum2 + "?");
             int bAnswer = int.Parse(Console.ReadLine());
             if(bAnswer == iNum1 * iNum2)
             {
                Console.WriteLine("Correct!");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
             }
             else
             {
                Console.WriteLine("Incorrect, try again");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                goto Incorrect;
             }
            }
            
        }
        
    }
}
