using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroOOP
{
    class Superhero
    {
        //Declare fields

        private string hasShield;
        private string hasSuit;
        private int speed;
        private int superPower;
        private string name;

        //Declare properties

        public string HasShield
        {
            get { return this.hasShield; }
            set { this.hasShield = value; }
        }

        public string HasSuit
        {
            get { return this.hasSuit; }
            set { this.hasSuit = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int SuperPower
        {
            get { return this.superPower; }
            set { this.superPower = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Superhero()
        {
            //Default constructor
        }

        public Superhero(int speed, int superPower) //Loaded constructor
        {
            this.speed = speed;
            this.superPower = superPower;
        }

        public Superhero(string hasShield, string hasSuit, string superPower) //Loaded constructor
        {
            this.hasShield = hasShield;
            this.hasSuit = hasSuit;
        }

        public void Fly() //when fly is method is called, health will decrement/decline
        {
            int[] health = new int[3];
            for (int i = 0; i < health.Length; i--)
            {
                Console.WriteLine(health[i]);
            }
        }

        public void EatsFood()
        {
            Console.WriteLine("After eating food, your power level has increased by {0} points.", superPower);
        }
    }
}