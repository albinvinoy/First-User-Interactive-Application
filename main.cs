using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Starting");
        DrawCircle circle1 = new DrawCircle();
        Application.Run(circle1);
        System.Console.WriteLine("End");
    }
}
