using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class Armor
{
    public Armor(int maxHitPoints)
    {
        if (maxHitPoints <= 0)
        {
            throw new ArgumentException("maxHitPoints must be positive", nameof(maxHitPoints));
        }

        MaxHitPoints = maxHitPoints;
        CurrentHitPoints = maxHitPoints;
    }

    public int MaxHitPoints { get; }

    public int CurrentHitPoints { get; private set; }

    public bool IsAlive => CurrentHitPoints >= 0;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            throw new ArgumentException("damage must be positive", nameof(damage));
        }

        CurrentHitPoints -= damage;
    }
}