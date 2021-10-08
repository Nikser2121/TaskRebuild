using System;
using System.Threading;

namespace TaskRebuild
{
    public class Archer : Creature
    {
        private int _ammo = 5;
        public override void Action(ConsoleKeyInfo cki)
        {
            switch (cki.Key)
            {
                case ConsoleKey.C:
                    if (_ammo>0)
                    {
                        _ammo--;
                        State=new AttackState();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Reloading");
                        Thread.Sleep(1000);
                        _ammo=5;
                        State=new IdleState();
                        break;
                    }
                default:
                    base.Action(cki);
                    break;
            }
        }
    }
}