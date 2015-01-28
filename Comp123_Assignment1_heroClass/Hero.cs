using System;

namespace Comp123_Assignment1_heroClass
{
    class Hero
    {
        //PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int strength;
        private int speed;
        private int health;

        Random rnd = new Random();
        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string name;

        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name)
        {
            //take one parameter, name (string), and pass its value to the name property
            //call the generateAbilities method

            this.name = name;
            this.generateAbilities(); //Displays Hero's abilities
            
        }

        //PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void generateAbilities()
        {
            //randomly generates the ability numbers for the strength, speed & health properties (each ability will be an integer between 1-100)
            this.strength = this.rnd.Next(1, 101);
            this.speed = this.rnd.Next(1, 101);
            this.health = this.rnd.Next(1, 101);
        }
        private bool hitAttempt()
        {
            //randomly determine if the Hero hits (this should be 20% of the time)
            //otherwise, it will return false
            bool hit = false;
            int attempt = this.rnd.Next(1, 101);

            if (attempt < 21)
            {
                hit = true;
            }

            return hit; 
        }

        private int hitDamage()
        {
            //calculates the hitDamage the Hero causes to the target on a hit
            //the damage will be calculated by multiplying the Hero's strength property by a number between 1 and 6
            //the method will return this value

            int damage;
            damage = this.strength * this.rnd.Next(1, 7);

            return damage;
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void fight()
        {
            //calls the hitAttempt method
            //if hitAttempt returns true, then it will call the hitDamage method
            //the damage will then be displayed in a message on the Console

        }

        public void show() 
        {
            //method that will display the Hero's ability scores to the console
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Strength: {0}", this.strength);
            Console.WriteLine("Speed: {0}", this.speed);
            Console.WriteLine("Health: {0}", this.health);
            Console.WriteLine("+++++++++++++++++++++++++++++++");
        }

    }
}
