/*Authors Name: Kristina Maniacup
 * Date Last Modified: Tuesday, January 27, 2015
 * Program Description: This program contains a Hero class. 
 *                      Within the Hero class, there are both private and public abilities/methods.
 *                      Hero's abilities are generated randomly from 1-100, 
 *                      hitAttempt method is generated randomly (hit is successful 20% of the time)
 *                      hitDamage is calculated by multiply Hero's strength by a number between 1 and 6
 *                      fight method calls hitAttempt method and hitDamage method; if hit attempt is true then it will call hitDamage
 *                      show method displays the ability scores on the console
 *                      
 * Revision History:
 * 01/26/2015: created the Hero class and made the layout of what was needed to be done
 *             made the public and private properties
 *             made the constructor
 *             made the show method
 *             started coding the generateAbilities method
 *             
 * 01/27/2015: finished coding the generateAbilities method
 *             created the Random instance
 *             created the hitAttempt method
 *             created the hitDamage method
 *             created the fight method
 *             created program header which indicates: author, date last modified, program description and revision history
 *             
 * 01/30/2015: Add additional comments
 *             Played around with hitAttempt method 
 *             
*/
using System;

namespace Comp123_Assignment1_heroClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Dad");
            myHero.show();
            myHero.fight();
            
        }
    }
}
