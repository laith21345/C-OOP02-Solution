using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;
using Program.Encapsulation;

namespace Program
{
    internal class Program
    {
        static void Main(/*string[] args*/)
        {
            //Assignment OOP02 C# 

            #region Q1
            //1. Define a struct "Person" with properties "Name" and "Age". Create an array of
            //   three "Person" objects and populate it with data.Then, write a C# program to
            //   display the details of all the persons in the array.

            //Person[] people ={

            //    new Person("ali",23),
            //    new Person("ahmed",19),
            //    new Person("mohammed",25)
            //};

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Person {i+1}:\n{people[i]}\n");
            //}

            #endregion

            #region Q2 

            //2. Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //   Write a C# program that takes two points as input from the user and calculates
            //   the distance between them.

            //Encapsulation.Point[] points = new Encapsulation.Point[2];
            //int x, y;

            //for (int i = 0; i < 2; ++i)
            //{
            //    Console.WriteLine($"for {(Ordered_Steps)i + 1} point:");
            //    bool isParsed;
            //    do
            //    {
            //        Console.Write("enter the value of x :");
            //        isParsed = int.TryParse(Console.ReadLine(), out x);
            //    } while (!isParsed);

            //    do
            //    {
            //        Console.Write("enter the value of y :");
            //        bool yIsParsed = int.TryParse(Console.ReadLine(), out y);
            //    } while (!isParsed);

            //    Console.Write('\n');
            //    points[i].x = x;
            //    points[i].y = y;

            //}
            //Console.Clear();



            //double distance = Math.Sqrt(
            //                            Math.Pow(points[1].x - points[0].x, 2)
            //                            + Math.Pow(points[1].y - points[0].y, 2)
            //                          );
            //if (distance < 0)
            //{
            //    distance *= -1;
            //}

            //Console.WriteLine($"the distance between them = {distance}");

            #endregion

            #region Q3

            //3. Create a struct called "Person" with properties "Name" and "Age".
            //   Write a C# program that takes details of 3 persons as input from the user
            //   and displays the name and age of the oldest person.

            //Person[] people = new Person[3];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"enter the data for the {(Ordered_Steps)i + 1} person :)");
            //    Console.Write($"enter the name: ");
            //    people[i].Name = Console.ReadLine() ?? "Laith";

            //    Console.Write($"enter the age: ");
            //    people[i].Age = byte.Parse(Console.ReadLine());
            //}
            //Console.Clear();

            //byte oldestPersonIndex = 0;
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[oldestPersonIndex].Age < people[i].Age)
            //        oldestPersonIndex = (byte)i;
            //}

            //Console.WriteLine($"the oldest person :\nName: {people[0].Name}\nAge: {people[0].Age}");

            #endregion

            #region Q4

            //4. Create a struct named Rectangle that represents a rectangle with the following
            //   fields:
            //          width(type: double)
            //          height(type: double)
            //
            // Implement encapsulation by making the fields private and provide public properties access and modify these values.Ensure the following conditions are met:
            // The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.
            // Implement a public read-only property Area that calculates and returns the area of the rectangle(Area = width * height).
            // 
            // Implement a method DisplayInfo that prints the rectangle's dimensions and area.
            // Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.

            //Encapsulation.Rectangle myRec = new Encapsulation.Rectangle();

            //myRec.Height = -23;// error message will be print 
            //myRec.Height = 23;// Accepted

            //myRec.Width = -50;// error message will be print 
            //myRec.Width = 50;// Accepted
            //Console.WriteLine();

            //myRec.DisplayInfo();

            #endregion
        }
    }
}
