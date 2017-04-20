using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ErrorLogger : AbstractLogger
    {

        public ErrorLogger(int level)
        {
            this.level = level;
        }

        protected override void write(String message)
        {
            Console.WriteLine("Error Console::Logger: " + message);
        }
    }
}
