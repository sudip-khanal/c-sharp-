// simple program to calculate the area and peremeter of rectangle...
using System;
public class Rectangle
{
    public static void Main( string [] args)
    {

        int Length;
        int Breadth;
        int Perimeter;
        int Area;

        Console.WriteLine("Enter the Length of a Rectangle: ");
             Length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Breadth of a Rectangle: ");
         Breadth = Convert.ToInt32(Console.ReadLine());

         Area = Length * Breadth;
            Console.WriteLine("Area of Rectangle is:" + Area);

         Perimeter = 2 * (Length + Breadth);
                Console.WriteLine("perimeter of Rectangle is:" + Perimeter);

        Console.ReadLine();
    }
}