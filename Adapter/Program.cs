using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCAbstraction
{
    using System.Collections;

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new NLogAdapter();
            logger.Info("Логгер NLog подключен");

            logger = new Log4NetAdapter();
            logger.Info("Логгер Log4Net подключен");
        }
    }
}
