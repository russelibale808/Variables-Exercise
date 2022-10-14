namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Lessons

            //Declaring variables

            double turtleWeight;

            int turtleAge;

            string turtleName;

            string turtleLastName;

            char turtleLegs;

            decimal turtleSize;

            bool myTurtle;

            //Initializing variables

            turtleWeight = 8.5;

            turtleAge = 8;

            turtleName = "Bobo";

            turtleLastName = "Chomper";

            turtleLegs = '3';

            turtleSize = 16.25m;

            myTurtle = true;

            //Declard & Initialized at the same time

            string fullName = turtleName + " " + turtleLastName;

            string weightAndLength = turtleWeight + " and is " + turtleSize;

            string lazy = "Is my turle active or lazy? True or False?. " + myTurtle;

            Console.WriteLine($"My turtles name is {fullName}, He is {turtleAge} years old." +
                              $" He weighs {weightAndLength} in length." +
                              $" He also has {turtleLegs} legs." +
                              $" {lazy}, my turtle is lazy.");
        }
    }
}