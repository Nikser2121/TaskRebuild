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
                    if (State is BlockState)
                    {
                        State = new IdleState();
                    }
                    else
                        State = new BlockState();
                    break;
                default:
                    if(State is not BlockState)
                        base.Action(cki);
                    break;
            }
        }
    }
}