using System;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {

           

        }



        private static void ForeachLoop()
        {
            int[] array = new int[] { 1, 2, 2, 3, 4, 5, 6 };

            int? arrayLength = array?.Length;

            int firstElemen = (array != null && array.Length > 0)
                ? array[0]
                : -1;

            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                Console.Write($"{element}, ");
            }

            Console.WriteLine();

            if (array is null)
            {
                //mesaj
            }
            else
            {
                foreach (int element in array ?? new int[] { })
                {
                    Console.Write($"{element}, ");
                }
            }


            Console.WriteLine();
        }

        private static void WhileLoop()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            int inx = 0;
            while (inx < array.Length)
            {
                Console.Write($"{array[inx]}, ");
                inx++;
            }

            Console.WriteLine();
        }

        private static void IsAuthenticated()
        {

            string correctUser = "admin";
            string correctPassword = "pass123";
            string userName = string.Empty;


            bool isAuthenticated = false;


            while (!isAuthenticated)
            {
                Console.Write("Username=");
                userName = Console.ReadLine();

                Console.Write("Password=");
                string password = Console.ReadLine();

                isAuthenticated = !string.Equals(correctUser, userName, StringComparison.OrdinalIgnoreCase) &&
                                  !string.Equals(password, correctPassword, StringComparison.OrdinalIgnoreCase);

                if (!isAuthenticated)
                {
                    Console.WriteLine("Ne pare rau, mai incercati o data!");
                }
            }

            Console.WriteLine($"Bine ai venit, {userName}");
        }

        /// <summary>
        /// Checks wheather the inserted userName and password are correct
        /// </summary>
        private static void IsAuthenticatedDoWhile()
        {
            string correctUser = "admin";
            string correctPassword = "pass123";
            string userName = string.Empty;


            bool isAuthenticated;


            do
            {
                Console.Write("Username=");
                userName = Console.ReadLine();

                Console.Write("Password=");
                string password = Console.ReadLine();

                isAuthenticated = !string.Equals(correctUser, userName, StringComparison.OrdinalIgnoreCase) &&
                                  !string.Equals(password, correctPassword, StringComparison.OrdinalIgnoreCase);

                if (!isAuthenticated)
                {
                    Console.WriteLine("Ne pare rau, mai incercati o data!");
                }
            } while (!isAuthenticated);

            Console.WriteLine($"Bine ai venit, {userName}");
        }
    }
}
