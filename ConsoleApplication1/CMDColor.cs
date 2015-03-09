using System;

namespace ConsoleApplication1
{
    /// <summary>
    /// 控制台颜色控制
    /// </summary>
    public class CMDColor
    {
        private static void Time()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DateTime.Now.ToString() + "  ");
            Console.ResetColor();
        }

        public static void INFO(string text)
        {
            Time();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.WriteLine();
            Console.ResetColor();
        }
        public static void Warning(string text)
        {
            Time();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}

