using System;
using System.Collections.Generic;

namespace Substitution.Birds;

// Interface for birds that can fly
public interface IFlyable
{
    void Fly();
}

// Base class for all birds
public abstract class Bird
{
    public string Name { get; }

    protected Bird(string name)
    {
        Name = name;
    }

    // General move behavior
    public abstract void Move();

    public override string ToString()
    {
        return $"{GetType().Name} \"{Name}\"";
    }
}

// A flying bird implements IFlyable and uses Fly inside Move.
public class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine($"Little {Name} flaps and flies.");
    }

    public override void Move()
    {
        Fly();
    }
}

public class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine($"{Name} soars high in the sky.");
    }

    public override void Move()
    {
        Fly();
    }
}

// Non-flying birds override Move but do not implement IFlyable
public class Penguin : Bird
{
    public Penguin(string name) : base(name) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} swims (cannot fly).");
    }
}

public class Ostrich : Bird
{
    public Ostrich(string name) : base(name) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} runs fast");
    }
}

// A general zoo keeper class that works with all birds
public static class ZooKeeper
{
    public static void BirdsMove(IEnumerable<Bird> birds)
    {
        foreach (Bird b in birds)
        {
            Console.Write($"{b}: ");
            b.Move(); // every Bird implements Move
        }
    }
}