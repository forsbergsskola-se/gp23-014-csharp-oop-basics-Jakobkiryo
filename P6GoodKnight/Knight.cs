﻿
//Knights action
public class Knight
{
    public Sword Sword;
    public Shield Shield;

    public void TakeDamage(Sword sword)
    {
        if (this.Shield == null)
        {
            Console.WriteLine("The Enemys shield is destroyed and is damaged");
        }
        else
        {
            if (sword == null)
            {
                Console.WriteLine("Enemy Blocks The Attack with his Shield");
            }
            else
            {
                this.Shield = null;
                Console.WriteLine("Enemys Shield was pierced by the Sword");
            }
        }
    }

    public void Attack(Knight target)
    {
        string weapon = this.Sword != null ? "Sword" : "Bare Hands";
        
        Console.WriteLine($"Knight attacks Enemy with his {weapon}");

        target.TakeDamage(this.Sword);
    }
}