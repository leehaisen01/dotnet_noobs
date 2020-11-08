using System;

namespace _01_Intro {
    class Program {
        static void Main(string[] args) {
            #region Introduction to Types
            // data types
            int x = 1;
            short s = 21345;
            float f = 12.222222f;
            double dbl = 12342;
            decimal ds = 12.2222222222222222222m;
            long l = 1238921;

            char c = 'a';
            string str = "This is a long long paragraph";

            bool iamyoung = true;
            DateTime today = DateTime.Now;
            #endregion

            #region Arrays, For Loop & Conditionals
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int n4 = 4;
            int n5 = 5;
            int n6 = 6;

            // arrays
            int[] bottles = new int[10]; // array
            bottles[0] = 1;
            bottles[1] = 10;
            bottles[2] = 500;
            bottles[3] = 800;
            bottles[4] = 800;
            bottles[5] = 800;
            bottles[6] = 800;

            Console.WriteLine(bottles.Length);

            // for loop
            for (int i = 0; i < bottles.Length; i++) {
                Console.WriteLine($"Bottle at Index[{i}] has value = {bottles[i]}");
                //Console.WriteLine("Bottle at Index[" + i + "] has value = " + bottles[i] + "");
            }

            // if else statment
            int age = 17;
            if (age > 18) {
                Console.WriteLine("Welcome To Website.");
            }
            else {
                Console.WriteLine("Sorry you are too young.");
            }


            if (age > 18) {
                Console.WriteLine("Welcome To Website.");
            }
            else if(age == 17) {
                Console.WriteLine("You have to wait one year for this.");
            }
            else {
                Console.WriteLine("Sorry you are too young.");
            }

            // console input 
            Console.Write("Enter A Number : ");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Entered {val}");
            // console output
            Console.Write("This");
            Console.Write(" is a sentence \n");
            Console.WriteLine("This doesn't need any escape character");
            #endregion
        }
    }
}
