using System;

namespace UCopy
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string mode;
            Console.Title = "U盘静默拷贝工具";
            Console.WriteLine("选择模式");
            Console.Write("你选择的模式:");
            mode = Console.ReadLine().ToString();
        }
    }
}
