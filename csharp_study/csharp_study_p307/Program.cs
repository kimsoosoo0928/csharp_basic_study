using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_study_p307
{
    class Program
    {
        interface ILogger
        {
            void writeLog(string message) : 
        }

        interface IFormattableLogger : ILogger
        {
            void WriteLog(string format, params Object[] args);
        }
        
        class ConsoleLogger2 : IFormattableLogger
        {
            public void WriteLog(string message)
            {
                Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
            }
            
            public void WriteLog(string  format, params Object[] args)
            {
                String message = String.Format(format, args);
                Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
            }
        }

        class MainApp
        {
            static void Main(string[] args)
            {
                IFormattableLogger = new ConsoleLogger2();
                logger.WriteLog("The world is not flat.");
                ConsoleLogger2.WriteLog("{0} + {1} = {2}", 1, 1, 2)
                
            }
        }
    }
}
