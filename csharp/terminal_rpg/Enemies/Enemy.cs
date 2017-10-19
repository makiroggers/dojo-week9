using System;

namespace terminal_rpg
{
    // Base parent class
    public class Enemy
    {
        // Properties for Enemy class
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }

        // Constructor for Enemy class with default values added (only passes name as argument)
        public Enemy(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        // Constructor for Enemy class without default values (passes all stats as arguments)
        public Enemy(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        // Method to show the status of the current player
        public void ShowStatus()
        {
            System.Console.WriteLine("Name: {0}", Name);
            System.Console.WriteLine("Strength: {0}", Strength);
            System.Console.WriteLine("Intelligence: {0}", Intelligence);
            System.Console.WriteLine("Dexterity: {0}", Dexterity);
            System.Console.WriteLine("Health: {0}", Health);
        }

        // Method used to attack another player passed by reference
        public void Attack(object obj)
        {
            Human player = obj as Human;
            if (player == null)
            {
                System.Console.WriteLine("Attack failed. This player does not exist.");
            }
            else
            {
                player.Health -= Strength * 5;
            }
        }
    }
}