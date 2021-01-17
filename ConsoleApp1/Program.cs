using System;
using System.Linq;
using System.IO;

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
                        CodeMessage(Console.ReadLine());
                        Console.WriteLine("Message already coded");
                        break;
                    case 2:
                        Console.WriteLine("Write your Message in \"input.txt\", save and input smth");
                        Console.ReadKey();
                        string decodedMessage = DecodeMessage("C:\\input.txt");
                        Console.WriteLine("Message uncoded");
                        Console.WriteLine(decodedMessage);
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            }
        }

        //
        public static void CodeMessage(string Message)
        {
            string path = @"C:\\Users\\"+Convert.ToString(Environment.UserName)+"\\Desktop\\Coder-Decoder\\Text.txt";
            StreamReader myread = new StreamReader(path);

            string message = (myread.ReadToEnd());

            myread.Close();

            string newMessage = "";

            for (int i = 0; i<message.Length; i++) 
            {
                newMessage += Convert.ToChar(Convert.ToInt32(message[i]) + 3);
            }

            StreamWriter mywrite = new StreamWriter(path, false);
            mywrite.Write(newMessage);
            mywrite.Close();
        }
        public static string DecodeMessage(string pathToFile)
        {
            return "";
        }
    }
}
