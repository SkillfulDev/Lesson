using System;

namespace CH_TheAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, input number of contacts you need:");
            int count;
            string str = Console.ReadLine();
            bool countTryParse = int.TryParse(str, out count);
            if (countTryParse)
            {
                string[] names = new string[count];
                int[] phoneNumbers = new int[count];
                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write("Input  name: ");
                    names[i] = Console.ReadLine();
                    Console.Write("Input  phone number:");
                    string srtPhoneNumber = Console.ReadLine();
                    int PhoneNumber;
                    bool isPhoneCorrectlyFormat = int.TryParse(srtPhoneNumber, out PhoneNumber);

                    if (isPhoneCorrectlyFormat)
                    {
                        phoneNumbers[i]=PhoneNumber;
                    }
                    else
                    {
                        Console.WriteLine("It isnt correctly Phone number");
                    }

                }
                Console.WriteLine("");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Name: " + names[i] + "Phone nubmer: " + phoneNumbers[i]);
                }
            }
            else
            {
                Console.WriteLine("It isn`t a number");
            }
            Console.ReadLine();


        }
    }
}
