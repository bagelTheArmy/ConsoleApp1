using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            Console.WriteLine("0");
            while (Exit == false)
            {
                Console.WriteLine("What Task?");
                string TheTask = Console.ReadLine();
                TheTask = TheTask.ToUpper();
                /*switch (TheTask)
                {
                    case '1':
                        Task1();
                    case  "2":
                        Task2();
                    case "3":
                        Task3();
                    case "Q":
                        Exit = true;
                }*/
            }
            Console.WriteLine("1");
            for (; ; );
        }
        static void Task1()
        {

        }
        static void Task2()
        {

        }
        static void Task3()
        {

        }



    }
}
