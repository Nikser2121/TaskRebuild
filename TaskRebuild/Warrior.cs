using System;

namespace TaskRebuild
{
    public class Warrior:Creature
    {
        public override void Action(ConsoleKeyInfo cki)
        {
            switch (cki.Key)
            {
                case ConsoleKey.B:
                    State.Block(this);
                    break;
                default:
                    base.Action(cki);
                    break;
            }
        }
    }
}