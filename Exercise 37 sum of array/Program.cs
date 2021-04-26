using System;

namespace Exercise_37_sum_of_array
{
    class Program
    {   
       
        static void Main(string[] args)
        {
            while (true)
            {
                string user_choice;

                double[] user_arr = new double[5];
                double sum = 0;
                double answer;

                for (int i = 0; i < user_arr.Length; i++)
                {
                    Console.Write("Enter a number <<");
                    user_arr[i] = Convert.ToDouble(Console.ReadLine());
                }

                for (int i = 0; i < user_arr.Length; i++)
                {
                    sum += user_arr[i];
                }

                answer = sum;

                Console.WriteLine(user_arr[0] + " + " + user_arr[1] + " + " + user_arr[2] + " + " + user_arr[3] +   " + " + user_arr[4] + " = " + sum);

                Console.WriteLine("Would you like to continue? y/n");
                user_choice = Console.ReadLine().ToLower();

                if (user_choice != "y")
                {
                    Console.WriteLine("Goodbye!!");
                    break;
                }



            }


        }
    }
}
