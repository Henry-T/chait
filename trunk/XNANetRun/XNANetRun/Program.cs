using System;

namespace XNANetRun
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (XNANetClientGame game = new XNANetClientGame())
            {
                game.Run();
            }
        }
    }
#endif
}

