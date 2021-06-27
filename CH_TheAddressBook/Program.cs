using System;

namespace CH_TheAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, input number of contacts you need:");
            int count = int.Parse(Console.ReadLine());
            string[] names = new string[count];
            int[] phoneNumbers = new int[count];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Input  name: ");
                names[i] = Console.ReadLine();
                Console.Write("Input  phone number:");
                phoneNumbers[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: " + names[i] + "Phone nubmer: " + phoneNumbers[i]);

            }

            Console.ReadKey();
        }
    }
}
