using System;

namespace TaskRebuild
{
    interface ICreatureState
    {
        void Idle(Creature creature);
        void Move(Creature creature,char dir);
        void Block(Creature creature);
        void Jump(Creature creature);
        void Rollover(Creature creature);

    }

    class Creature
    {
        public ICreatureState _state = new IdleState();
        public ICreatureState State { get; set; }

        public Creature()
        {
            Console.WriteLine("Idle");
        }

        public void Jump()
        {
            State.Jump(this);
        }

        public void Move(Creature creature,char dir)
        {
            if(_state!=BlockState)
            State.Move(this,dir);
        }

        public void Block()
        {
            State.Block(this);
        }

        public void Rollover()
        {
            State.Rollover(this);
        }
        
        public static void Idle()
        {
            State.Idle(this);
        }
    }


    class IdleState : ICreatureState
    {
        public void Idle(Creature creature)
        {
        }
        public void Move(Creature creature, char dir)
        {
            switch (dir)
            {
                case 'A':
                    Console.WriteLine("Going left");
                    break;
                case 'W':
                    Console.WriteLine("Going forward");
                    break;
                case 'D':
                    Console.WriteLine("Going right");
                    break;
                case 'S':
                    Console.WriteLine("Going back");
                    break;
            }

            creature._state = new MoveState();
            {
                
            }
        }
        
    }


    class Move : ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }

        

        public void Block(Creature creature)
        {
            throw new NotImplementedException();
        }

        public void Jump(Creature creature)
        {
            throw new NotImplementedException();
        }

        public void Rollover(Creature creature)
        {
            throw new NotImplementedException();
        }

        public void MoveForw(Creature creature)
        {
        }

        public void MoveBack(Creature creature)
        {
            Console.WriteLine("Moving backward");
            creature.State = new MoveBackState();
        }

        public void MoveLeft(Creature creature)
        {
            Console.WriteLine("Moving left");
            creature.State = new MoveLeftState();
        }

        public void MoveRight(Creature creature)
        {
            Console.WriteLine("Moving right");
            creature.State = new MoveRightState();
        }
    }

    class MoveBackState : ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }

        public void MoveForw(Creature creature)
        {
            Console.WriteLine("Moving forward");
            creature.State = new MoveForwState();
        }

        public void MoveBack(Creature creature)
        {
        }

        public void MoveLeft(Creature creature)
        {
            Console.WriteLine("Moving left");
            creature.State = new MoveLeftState();
        }

        public void MoveRight(Creature creature)
        {
            Console.WriteLine("Moving right");
            creature.State = new MoveRightState();
        }
    }

    class MoveLeftState : ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }

        public void MoveForw(Creature creature)
        {
            Console.WriteLine("Moving forward");
            creature.State = new MoveForwState();
        }

        public void MoveBack(Creature creature)
        {
            Console.WriteLine("Moving backward");
            creature.State = new MoveBackState();
        }

        public void MoveLeft(Creature creature)
        {
        }

        public void MoveRight(Creature creature)
        {
            Console.WriteLine("Moving right");
            creature.State = new MoveRightState();
        }
    }

    class MoveRightState : ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
        }

        public void MoveForw(Creature creature)
        {
            Console.WriteLine("Moving forward");
            creature.State = new MoveForwState();
        }

        public void MoveBack(Creature creature)
        {
            Console.WriteLine("Moving backward");
            creature.State = new MoveBackState();
        }

        public void MoveLeft(Creature creature)
        {
            Console.WriteLine("Moving left");
            creature.State = new MoveLeftState();
        }

        public void MoveRight(Creature creature)
        {
        }
    }
}
