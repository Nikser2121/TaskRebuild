using System;

namespace TaskRebuild
{
    public interface ICreatureState
    {
        void Idle(Creature creature);
        void Move(Creature creature,ConsoleKeyInfo cki);
        void Block(Creature creature);
        void Jump(Creature creature);
        void Rollover(Creature creature);
        void Attack(Creature creature);

    }

    public class Creature
    {
        public virtual void Action(ConsoleKeyInfo cki)
        {
            switch (cki.Key)
            {
                case ConsoleKey.A:
                    State.Move(this,cki);
                    break;
                case ConsoleKey.W:
                    State.Move(this,cki);
                    break;
                case ConsoleKey.S:
                    State.Move(this,cki);
                    break;
                case ConsoleKey.D:
                    State.Move(this,cki);
                    break;
                case ConsoleKey.Spacebar:
                    State.Jump(this);
                    break;
                case ConsoleKey.F:
                    State.Rollover(this);
                    break;
                case ConsoleKey.C:
                    State.Attack(this);
                    break;
                default:
                    State.Idle(this);
                    break;
            }
        }
        public ICreatureState State = new IdleState();

        public Creature()
        {
            Console.WriteLine("Idle");
        }
        
    }


    class IdleState : ICreatureState
    {
        public void Idle(Creature creature)
        {
        }
        public void Move(Creature creature, ConsoleKeyInfo cki)
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

            creature.State = new MoveState();
        }

        public void Block(Creature creature)
        {
            Console.WriteLine("Blocking");
            creature.State = new BlockState();
        }

        public void Jump(Creature creature)
        {
            Console.WriteLine("Jumping");
            creature.State = new JumpState();
        }

        public void Rollover(Creature creature)
        {
            Console.WriteLine("Rolling over");
            creature.State = new RolloverState();
        }

        public void Attack(Creature creature)
        {
            Console.WriteLine("Attacking");
            creature.State = new AttackState();
        }
    }


    class MoveState : ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }

        public void Move(Creature creature, ConsoleKeyInfo cki)
        {
        }
        
        public void Block(Creature creature)
        {
            Console.WriteLine("Blocking");
            creature.State = new BlockState();
        }

        public void Jump(Creature creature)
        {
            Console.WriteLine("Jumping");
            creature.State = new JumpState();
        }

        public void Rollover(Creature creature)
        {
            Console.WriteLine("Rolling over");
            creature.State = new RolloverState();
        }

        public void Attack(Creature creature)
        {
            Console.WriteLine("Attacking");
            creature.State = new AttackState();
        }
    }

    class BlockState : ICreatureState
    {
        public void Idle(Creature creature)
        {
        }

        public void Move(Creature creature, ConsoleKeyInfo cki)
        {
            Console.WriteLine("Unable to move");
        }
        public void Block(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }

        public void Jump(Creature creature)
        {
            Console.WriteLine("Jumping");
            creature.State = new JumpState();
        }

        public void Rollover(Creature creature)
        {
            Console.WriteLine("Rolling over");
            creature.State = new RolloverState();
        }

        public void Attack(Creature creature)
        {
            Console.WriteLine("Attacking");
            creature.State = new AttackState();
        }
    }

    class JumpState : ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }

        public void Move(Creature creature, ConsoleKeyInfo cki)
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

            creature.State = new MoveState();
        }

        public void Block(Creature creature)
        {
            Console.WriteLine("Blocking");
            creature.State = new BlockState();
        }

        public void Jump(Creature creature)
        {
        }

        public void Rollover(Creature creature)
        {
            Console.WriteLine("Rolling over");
            creature.State = new RolloverState();
        }

        public void Attack(Creature creature)
        {
            Console.WriteLine("Attacking");
            creature.State = new AttackState();
        }
    }

    class RolloverState : ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }
        public void Move(Creature creature, ConsoleKeyInfo cki)
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

            creature.State = new MoveState();
        }

        public void Block(Creature creature)
        {
            Console.WriteLine("Blocking");
            creature.State = new BlockState();
        }

        public void Jump(Creature creature)
        {
            Console.WriteLine("Jumping");
            creature.State = new JumpState();
        }

        public void Rollover(Creature creature)
        {
        }

        public void Attack(Creature creature)
        {
            Console.WriteLine("Attacking");
            creature.State = new AttackState();
        }
    }

    class AttackState:ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }
        public void Move(Creature creature, ConsoleKeyInfo cki)
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

            creature.State = new MoveState();
        }

        public void Block(Creature creature)
        {
            Console.WriteLine("Blocking");
            creature.State = new BlockState();
        }

        public void Jump(Creature creature)
        {
            Console.WriteLine("Jumping");
            creature.State = new JumpState();
        }

        public void Rollover(Creature creature)
        {
            Console.WriteLine("Rolling over");
            creature.State = new RolloverState();
        }

        public void Attack(Creature creature)
        {
        }
    }
}
