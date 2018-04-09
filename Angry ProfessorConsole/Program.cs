using System;

namespace Angry_ProfessorConsole
{
    class Program
    {
        private static string AngryProfessor(int k, int[] a)
        {
            // Complete this function
            int attendance = 0;
            foreach (var item in a)
            {
                if (item <= 0) { attendance++; }
            }
            //is class canceled?
            if (attendance>=k)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }

           
        }

        static void Main(String[] args)
        {
            Console.WriteLine("How many different input tests do you wish to try?");
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                Console.WriteLine("Write n: students in class and k: cancelation threshold. -space seperated");
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                Console.WriteLine("Write arrival times of students.  -space seperated");
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                string result = AngryProfessor(k, a);
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }
    }
}
