using System;

namespace Comp123_Assignment1_heroClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Dad");
            myHero.fight();
            myHero.show();
        }
    }
}
