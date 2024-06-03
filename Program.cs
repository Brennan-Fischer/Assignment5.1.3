namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determines if any values are input multiple times in a user array");
            Console.WriteLine("Input number of elements you wish to be contained");
            int size= Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[size];
            HashSet<int> userSet = new HashSet<int>();
            bool answer = false;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Input element {i} into the array");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < size; i++)
            {
                if (userSet.Contains(userArray[i]))
                {
                    answer = true;
                    Console.WriteLine($"True, at least value {userArray[i]} is in the array multiple times");
                }
                else
                {
                    userSet.Add(userArray[i]);
                }
            }
            if (answer==false)
            {
                Console.WriteLine($"False, no repeated values in array");
            }

        }
    }
    }
    

