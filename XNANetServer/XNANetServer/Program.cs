using System;

namespace XNANetServer
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (XNANetServerGame game = new XNANetServerGame())
            {
                game.Run();
            }
        }
    }
#endif
}

