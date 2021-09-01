using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks the user what they would like to do and gives brings them to the task if they hit q they quit
            bool Exit = false;
            while (Exit == false)
            {
                Console.WriteLine("Enter 1 2 or 3 for task  1,2,3 opr Q for Quit");
                string TheTask = Console.ReadLine();
                TheTask = TheTask.ToUpper();
                switch (TheTask)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "Q":
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("bad input");
                        break;
                }
            }

        }
        static void Task1()
        {
            //goes through a loop unless user hits q
            bool quit = false;
            while (quit == false)
            {
                //variables
                Console.WriteLine("Enter a String between 5 to 10 characters with one uppercase letter and one lowercase");
                string UserInputtedString = Console.ReadLine();
                string newString = "";
                bool contains1Upper = false;
                bool contains1Lower = false;

                if (UserInputtedString == "Q")
                {
                    quit = true;
                }
                //if user does not hit q check to see if input is correct if it is make upper characters lower and lower characters upper else say "bad input"
                else
                {
                    if (UserInputtedString.Length >= 5 && UserInputtedString.Length <= 10)
                    {
                        for (int i = 0; i < UserInputtedString.Length; i++)
                        {
                            if (64 < UserInputtedString[i] && UserInputtedString[i] < 91)
                            {
                                int theCharacter = UserInputtedString[i] + 32;
                                newString += (char)theCharacter;
                                contains1Upper = true;
                            }
                            if (97 <= UserInputtedString[i] && UserInputtedString[i] <= 122)
                            {
                                int theCharacter = UserInputtedString[i] - 32;
                                newString += (char)theCharacter;
                                contains1Lower = true;
                            }
                        }
                        if (contains1Upper && contains1Lower)
                        {
                            Console.WriteLine(newString);
                        }
                        else
                        {
                            Console.WriteLine("bad input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("bad input");
                    }
                }
            }

        }
        static void Task2()
        {
            //goes until user hits q
            bool quit = false;
            while (quit == false)
            {
                Console.WriteLine("Enter a String between 8 to 20 characters");
                string UserInputtedString = Console.ReadLine();
                string newString = "";
                if (UserInputtedString == "Q")
                {
                    quit = true;
                }
                //if user does not hit q verify input. If  is input good write new string in reverse else write "bad input"
                else
                {
                    if (UserInputtedString.Length >= 8 && UserInputtedString.Length <= 20)
                    {
                        newString = reversedTheString(UserInputtedString);
                        Console.WriteLine(newString);
                    }
                    else
                    {
                        Console.WriteLine("bad input");
                    }
                }
            }
        }
        static void Task3()
        {
            //if user hits q quit otherwise continue through the loop
            bool quit = false;
            while (quit == false)
            {
                Console.WriteLine("Enter a number that is 3 digits long");
                string UserInputtedString = Console.ReadLine();
                string reversedString = "";
                string newString = "";
                if (UserInputtedString == "Q")
                {
                    quit = true;
                }
                //make every number 1 higher and reverse it if input is good else give bad input
                else
                {
                    if (UserInputtedString.Length == 3)
                    {
                        try
                        {
                            int number = Int32.Parse(UserInputtedString);
                            for (int i = 0; i < UserInputtedString.Length; i++)
                            {
                                int num = number % 10;
                                num += 1;
                                if (num == 10)
                                {
                                    num = 0;
                                }
                                reversedString = reversedString + num.ToString();
                                number = number / 10;
                            }
                            newString = reversedTheString(reversedString);
                            Console.WriteLine(newString);
                        }
                        catch
                        {
                            Console.WriteLine("bad input");
                        }


                    }
                    else
                    {
                        Console.WriteLine("bad input");
                    }
                }
            }
        }

        static string reversedTheString(string stringToReverse)
        {
            //reverses the string
            string newString = "";
            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                newString += stringToReverse[i];
            }
            return newString;
        }



    }
}