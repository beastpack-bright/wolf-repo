using System;


namespace WolfClasses
{
    internal class Program
    {
        //I like wolves.
        public abstract class Wolf
        {
            public string name { get; set; }
            public int age { get; set; }

            public abstract string Sound();

            public void Eat()
            {
                // Implementation for eating
            }

            public void Sleep()
            {
                // Implementation for sleeping
            }
        }

        // Prey class
        public abstract class WolfFood
        {
            public string type { get; set; }
            public double size { get; set; }

            public abstract void RunAway();
        }

        // Interfaces
        public interface IHunt
        {
            string Hunt();
        }

        public interface IHowl
        {
            string Howl();
        }

        // Classes
        public class GreyWolf : Wolf
        {
            public override string Sound()
            {
                return "Howl";
            }
        }

        public class TimberWolf : Wolf
        {
            public override string Sound()
            {
                return "Howl";
            }
        }

        // Prey classes
        public class Rabbit : WolfFood
        {
            public override void RunAway()
            {
                Console.WriteLine("AAAH! A wolf!");
            }
        }

        public class Deer : WolfFood
        {
            public override void RunAway()
            {
                Console.WriteLine("AAAH! A wolf!");
            }
        }
    }
}

