﻿using System; //means that we use classes from the System Namespace

namespace HelloWorld //used to orgnaize your code, and it is a container for lcasses and other namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World");
            Console.WriteLine("I am learning C#");
            Console.WriteLine("It is awesome.");
            Console.WriteLine(3 + 3);
            Console.Write("This won't insert a line after it"); //won't insert a line after like Console.WriteLine
            Console.WriteLine("Back to inserting a line");
            Console.WriteLine("Mmmk");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                /*
                 * This is a
                 * multiline
                 * comment
                 */
            }

            /*
             * 
             * Commenting this out for the time being
             * 
             * 
            string name = "Josh";
            Console.WriteLine("My name is, " + name + ".");

            int myNum = 15;
            myNum = 20; //This will change the value of myNum to 20
            Console.WriteLine(myNum);

            const int myNum2 = 30; // const will keep the variable from changing
            Console.WriteLine(myNum2);
            Console.WriteLine(myNum * myNum2);

            //Other variable types
            int myNum3 = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool mybool = true;
            float myfloat = 5.5f; //float example - stores 6-7 decimal points
            double myDouble = 5.555555d; //doubl example - stores 15 decimal points


            int x = 5, y = 10, z = 15;
            Console.WriteLine(x + y + z);
            string firstName = "Josh";
            string lastName = "Holly";
            Console.WriteLine(firstName+lastName);

            

     

            Console.WriteLine("Please enter your name");
            string enterName = Console.ReadLine();
            Console.WriteLine("Your name is, " + enterName);

            Console.WriteLine("please enter your age");
            int age = Convert.ToInt32(Console.ReadLine()); //converts from string input to integer
            Console.WriteLine("your age is, " + age);
           */

            //strings
            string txt = "adskfjalsdkjfa;lkdsjf";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            string firstName = "Josh ";
            string lastName = "Holly";
            string name = firstName + lastName; //combine strings
            Console.WriteLine(name);
            string nameTwo = string.Concat(firstName, lastName); //concatenate strings
            Console.WriteLine(nameTwo);

            string firstNameTwo = "John";
            string lastNameTwo = "Doe";
            string nameThree = $"My full name is: {firstNameTwo} {lastNameTwo}";
            Console.WriteLine(nameThree);
            Console.WriteLine(nameThree[0]); //prints first character in nameThree variable
            Console.WriteLine(nameThree.IndexOf('J')); //show the index place of 'J' - will print '17' as it is the 17th position of the index
            string txtTwo = "We are the so-called \"Vikings\" from the north."; // allows you to print with quotations without messing up the string variable
            Console.WriteLine("It\'s alright \nforcing a line break \n" + txtTwo); //allows you to use ' without error




        }
    }
}