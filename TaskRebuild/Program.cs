using System;
using System.Diagnostics;
using System.Threading;

namespace TaskRebuild
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            ConsoleKeyInfo cki=default;
            Creature one = new Creature();
            while (true)
            {
                for (int i = 0; i < 35; i++)
                {
                    if (Console.KeyAvailable)
                    {
                        cki = Console.ReadKey(true);
                    }
                    Thread.Sleep(10);
                }
                one.Action(cki);
                cki = default;
            }
        }

        public virtual void Move()
        {
            
        }
    }
}