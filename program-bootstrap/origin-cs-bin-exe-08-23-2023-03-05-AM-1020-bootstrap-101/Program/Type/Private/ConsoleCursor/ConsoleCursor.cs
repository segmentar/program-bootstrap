using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void ConsoleCursor(Boolean reset)
        {
            if (reset)
            {
                Console.CursorLeft = 0;

                Console.CursorTop = 0;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }
            else
            {
                Console.CursorLeft = 16;

                Console.CursorTop = 23;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }

            return;
        }
    }
}
