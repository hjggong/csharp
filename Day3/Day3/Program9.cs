using System;
using System.IO;

namespace Day3
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        // delegate 선언
        public delegate void printStr();

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        public static void WriteToFile(string str)
        {
            fs = new FileStream("d:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(PrintString ps)
        {

        }

        static void Main(string[] args)
        {
            /*
            PrintString ps1 = new PrintString();
            PrintString ps2 = new PrintString(WriteToFile);
            SendString(ps1);
            SendString(ps2);
            Console.ReadKey();
            */
        }

    }
}
