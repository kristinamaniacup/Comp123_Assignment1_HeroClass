using System;

namespace Comp123_Assignment1_heroClass
{
    class Hero
    {
        //PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        int strength;
        int speed;
        int health;


        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        string name;

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
            Random rnd = new Random();
            //randomly generates the ability numbers for the strength, speed & health properties (each ability will be an integer between 1-100)
            this.strength = rnd.Next(1, 101);
            this.speed = rnd.Next(1, 101);
            this.health = rnd.Next(1, 101);
        }
        private void hitAttempt()
        {
            //randomly determine if the Hero hits (this should be 20% of the time)
            //otherwise, it will return false
        }

        private void hitDamage()
        {
            //calculates the hitDamage the Hero2 causes to the target on a hit
            //the damage will be calculated by multiplying the Hero's strength property by a number between 1 and 6
            //the method will return this value
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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(""); 
        }

    }
}
