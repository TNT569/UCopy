using System;
using System.Collections.Generic;  
using System.Linq;  
using System.Text; 

namespace UCopy
{
    class Program
    {
            class Start
    {
        public void Run()
        {
            Console.Clear();
            Console.Title = "模式：启动";
            Console.WriteLine("\r\n模式1：启动");
            Console.WriteLine("按回车继续");
            Console.ReadLine();
        }
    }
        static void Main(string[] args)
        {
            Start R = new Start(); 
            string mode =null;
            Console.Title = "U盘静默拷贝工具";
            Console.WriteLine("选择模式");
            Console.Write("你选择的模式:");
            mode = Console.ReadLine().ToString();
            switch (mode)
            {
                case "1":
                R.Run();
                break;
                case "2":
                Console.WriteLine("Case 2");
                break;
            }
        }
    } 
 }
