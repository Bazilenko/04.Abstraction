using System;
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Enter coordinates of the top left anger X,Y: ");
        double topleftX = double.Parse(Console.ReadLine());
        double topleftY = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinates of the buttom right anger X,Y:");
        double buttomRightX = double.Parse(Console.ReadLine());
        double buttomRightY = double.Parse(Console.ReadLine());
        Point topLeft = new Point(topleftX, buttomRightY);
        Point buttomRight = new Point(buttomRightX, buttomRightY);
        Rectangle rectangle = new Rectangle(topLeft, buttomRight);
        Console.WriteLine("Enter quantity of points: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Y:");
            int y = int.Parse(Console.ReadLine());
            Point point = new Point(x, y);
            bool exist = rectangle.Contains(point);
            Console.WriteLine($"exist");

        }

    }
}
