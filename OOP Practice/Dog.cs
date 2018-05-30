using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Dog
    {
        private int hairLength; //field names (Declare fields)
        private int height;
        private int runningSpeed;
        private int weight;

        public int HairLength //Declare properties (for each field)
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
         
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; } //field name goes here; must point it to field
            set { this.runningSpeed = value; }
        }
         
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        
        //Declare constructors

    public Dog() 
        {
            //default constructor
        }

        public Dog(int hairLength, int height, int runningSpeed, int weight) //loaded constructor
        {
            this.hairLength = hairLength; //this= needs to go to field
            this.height = height; //after equal sign is parameter
            this.runningSpeed = runningSpeed;
            this.weight = weight;

        }

        public void Run() //methods
        {
            Console.WriteLine("Your dog can run {0} miles per hour", runningSpeed);

        }



        public void Bark()
        {

        }
        

        public void Potty()
        {

        }

        public void Cuddle()
        {

        }

        public void FavFood(string[] food)
        {

            Console.WriteLine("{0} favorite foods are: ", Name);
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }
        }


    } 



                
           
           

