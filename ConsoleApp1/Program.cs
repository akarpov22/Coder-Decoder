using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte action = 1;
            while (action != 0) 
            {
                Console.WriteLine("Choose what you wanna do");
                Console.WriteLine("1) Code");
                Console.WriteLine("2) Decode");
                Console.WriteLine("0) Exit");
                action = Convert.ToByte(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        CodeMessege(Console.ReadLine());
                        Console.WriteLine("Messege already coded");
                        break;
                    case 2:
                        Console.WriteLine("Write your messege in \"input.txt\", save and input smth");
                        Console.ReadKey();
                        string decodedMessege = DecodeMessege("C:\\input.txt");
                        Console.WriteLine("Messege ucoded");
                        Console.WriteLine(decodedMessege);
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            }
        }


        public static void CodeMessege(string messege)
        {

        }
        public static string DecodeMessege(string pathToFile)
        {
            return "";
        }
    }
}
