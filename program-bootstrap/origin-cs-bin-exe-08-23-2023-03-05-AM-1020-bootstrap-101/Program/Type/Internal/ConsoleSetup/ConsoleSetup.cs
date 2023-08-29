using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void ConsoleSetup()
        {
            ConsoleCursor(true);

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();

            do
            {
                Console.Clear();

                Console.Out.WriteLine(ConsoleDescriptor());

                ConsoleCursor(false);

                var line = Console.In.ReadLine();

                ConsoleSplit(line);

                var lower = line.ToLower();

                Boolean isEscape;

                isEscape = lower is "escape";

                if (isEscape is true)
                {
                    Console.Clear();

                    break;
                }
                else
                    "false".ToString();

                continue;

            } while (true);

            return;
        }
    }
}
