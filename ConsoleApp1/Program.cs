using System;
using System.Linq;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter createdFile = new StreamWriter(@"C:\\Users\\" + Convert.ToString(Environment.UserName) + "\\Desktop\\Text.txt", true);
            createdFile.Close();

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
                        CodeMessage("");
                        Console.WriteLine("Message already coded");
                        break;
                    case 2:
                        Console.WriteLine("Write your Message in \"input.txt\", save and input smth");
                        Console.ReadKey();
                        DecodeMessage("");
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
            string path = @"C:\\Users\\"+Convert.ToString(Environment.UserName)+"\\Desktop\\Text.txt";
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
        public static void DecodeMessage(string Message)
        {
            string path = @"C:\\Users\\"+Convert.ToString(Environment.UserName)+"\\Desktop\\Text.txt";
            StreamReader myread = new StreamReader(path);

            string message = (myread.ReadToEnd());

            myread.Close();

            string newMessage = "";

            for (int i = 0; i<message.Length; i++) 
            {
                newMessage += Convert.ToChar(Convert.ToInt32(message[i]) -3);
            }

            StreamWriter mywrite = new StreamWriter(path, false);
            mywrite.Write(newMessage);
            mywrite.Close();
            Console.WriteLine("Your file with text has been already upgrated!");
            Console.WriteLine("Your message contain:"+newMessage);
        }
    }
}
