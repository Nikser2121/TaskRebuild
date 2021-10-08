using System;

namespace TaskRebuild
{
    public abstract class CreatureState
    {
        
    }

    public class Creature
    {
        public CreatureState State = new IdleState();
        public virtual void Action(ConsoleKeyInfo cki)
        {
            switch (cki.Key)
            {
                case ConsoleKey.A:
                    if(State is not MoveState)
                        State=new MoveState(cki);
                    break;
                case ConsoleKey.W:
                    if(State is not MoveState)
                        State=new MoveState(cki);
                    break;
                case ConsoleKey.S:
                    if(State is not MoveState)
                        State=new MoveState(cki);
                    break;
                case ConsoleKey.D:
                    if(State is not MoveState)
                        State=new MoveState(cki);
                    break;
                case ConsoleKey.Spacebar:
                    if(State is not JumpState)
                        State= new JumpState();
                    break;
                case ConsoleKey.F:
                    if(State is not RolloverState)
                        State=new RolloverState();
                    break;
                case ConsoleKey.C:
                    if(State is not AttackState)
                        State=new AttackState();
                    break;
                default:
                    if(State is not IdleState)
                        State= new IdleState();
                    break;
            }
        }

    }


    class IdleState : CreatureState
    {
        public IdleState()
        {
            Console.WriteLine("Idle");
        }
    }


    class MoveState : CreatureState
    {
        public MoveState(ConsoleKeyInfo cki)
        {
            switch (cki.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine("Going left");
                    break;
                case ConsoleKey.W:
                    Console.WriteLine("Going forward");
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("Going right");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("Going back");
                    break;
            }
            
        }
    }

    class BlockState : CreatureState
    { 
        public void Move(Creature creature, ConsoleKeyInfo cki)
        {
            Console.WriteLine("Unable to move");
        }
        public BlockState()
        {
            Console.WriteLine("Blocking");
        }
    }

    class JumpState : CreatureState
    {
        public JumpState()
        {
            Console.WriteLine("Jumping");
        }
    }

    class RolloverState : CreatureState
    {
        
        public RolloverState()
        {
            Console.WriteLine("Rolling over");
        }

    }

    class AttackState:CreatureState
    {
        public AttackState()
        {
            Console.WriteLine("Attacking");
        }
    }
}
