using System;

namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 7;
                while (true)
                {
                    x = (x / 2) / x;
                }
            }
            catch (Exception ex)
            {
                var logger = ErrorLogger.GetLogger();
                logger.WriteLog(ex.Message);
            }
        }
    }
}
