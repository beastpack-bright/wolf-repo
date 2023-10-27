using System;


namespace WolfClasses
{

    //I like wolves still.
    public abstract class Wolf
    {
        public string name { get; set; }
        public int age { get; set; }

        public abstract string Sound();

        public void Eat()
        {
            Console.WriteLine("Wolf is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Wolf is sleeping.");
        }
    }

    public interface IHunt
    {
        string Hunt();
    }

    public interface IHowl
    {
        string Howl();
    }

 
    public class GreyWolf : Wolf, IHunt, IHowl
    {
        public override string Sound()
        {
            return "Howl";
        }

        public string Hunt()
        {
            return "Grey Wolf is hunting.";
        }

        public string Howl()
        {
            return "Grey Wolf is howling.";
        }
    }

    public class TimberWolf : Wolf, IHunt, IHowl
    {
        public override string Sound()
        {
            return "Howl";
        }

        public string Hunt()
        {
            return "Grrr. Bark bark!";
        }

        public string Howl()
        {
            return "AUUUUUUUUU";
        }
    }

    class Program
    {
        static void WolfMethod(object obj)
        {
            if (obj is Wolf wolf)
            {
                Console.WriteLine($"Wolf is making sounds!: {wolf.Sound()}");
                Console.WriteLine($"Wolf is eating:: {wolf.name} is eating.");
                Console.WriteLine($"Wolf is sleeping: {wolf.name} is sleeping.");
            }
            if (obj is IHunt hunting)
            {
                Console.WriteLine(hunting.Hunt());
            }
            if (obj is IHowl howling)
            {
                Console.WriteLine(howling.Howl());
            }
        }

        static void Main(string[] args)
        {
            GreyWolf greyWolf = new GreyWolf
            {
                name = "Grey Wolf -> Fluffy",
                age = 5
            };

            TimberWolf timberWolf = new TimberWolf
            {
                name = "Timber Wolf -> Fluffy Two",
                age = 7
            };

            WolfMethod(greyWolf);   
            Console.WriteLine();

            WolfMethod(timberWolf); 
        }
    }

}


