using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace MousePositionApp
{
    class Program
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        static void Main(string[] args)
        {
            Console.WriteLine("Press Ctrl+C to exit.");
            while (true)
            {
                if (GetCursorPos(out POINT point))
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write($"Current Position: {point.X}, {point.Y}   ");
                }
                Thread.Sleep(100);
            }
        }
    }
}
