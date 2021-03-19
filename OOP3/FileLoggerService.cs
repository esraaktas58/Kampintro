using System;

namespace OOP3
{
    class FileLoggerService : IlogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
