using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferm
{
    internal class ConsoleLogger : ILogger
    {
        public void Message(string message)
        {
            Console.WriteLine($"Сообщение: {message}");
        }

        public void Message(string message, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            this.Message(message);
            Console.ResetColor();
        }
    }
}
