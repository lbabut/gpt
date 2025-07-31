using System;
using System.Threading;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;
        while (true)
        {
            var pos = Cursor.Position;
            Console.SetCursorPosition(0, 0);
            Console.Write($"X: {pos.X}, Y: {pos.Y}   ");
            Thread.Sleep(50);
        }
    }
}
