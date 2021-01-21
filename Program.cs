using System;

namespace Assignment5_StudentScores
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] toysScores = { 7, 6, 5, 4, 3,2 };
            student Toy = new student("Toy", 12, toysScores);

            
            student intouch = new student("Intouch", 12, 7, 7, 7, 7, 7);

            int[] intouchScores = intouch.GetScores();
            for(int i =0;i < intouchScores.Length; i++)
            {
                Console.WriteLine(intouchScores[i]);
            }
               
        }
    }
}
