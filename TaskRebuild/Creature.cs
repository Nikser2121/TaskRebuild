using System;

namespace TaskRebuild
{
    interface ICreatureState
    {
        void Idle(Creature creature);
        void MoveForw(Creature creature);
        void MoveBack(Creature creature);
        void MoveLeft(Creature creature);
        void MoveRight(Creature creature);

    }

    class Creature
    {
        public ICreatureState State { get; set; }

        public Creature(ICreatureState cs)
        {
            Console.WriteLine("Idle");
            State = cs;
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }

        public void MoveForw()
        {
            State.MoveForw(this);
        }

        public void MoveBack()
        {
            State.MoveBack(this);
        }

        public void MoveLeft()
        {
            State.MoveLeft(this);
        }

        public void MoveRight()
        {
            State.MoveRight(this);
        }

        public void Idle()
        {
            State.Idle(this);
        }
    }


    class IdleState : ICreatureState
    {
        public void Idle(Creature creature)
        {
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
            Console.WriteLine("Moving right");
            creature.State = new MoveRightState();
        }
    }


    class MoveForwState : ICreatureState
    {
        public void Idle(Creature creature)
        {
            Console.WriteLine("Idle");
            creature.State = new IdleState();
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
