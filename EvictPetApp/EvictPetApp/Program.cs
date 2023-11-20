using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

interface IPet
{
    void Eat();
    void Play();
    string Name { get; set; }
    int Age { get; set; }
}

interface IDog : IPet
{
    void Bark();
    void NeedWalk();
    void GotoVet();
    string License { get; }
}

interface ICat : IPet
{
    void Scratch();
    void Purr();
    void Evicted();
}

class Pet : IPet
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Pet() { }

    public Pet(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name}: Yummy, I will eat anything!");
    }

    public virtual void Play()
    {
        Console.WriteLine($"{Name}: Playing");
    }
}

class Dog : Pet, IDog
{
    public string License { get; }

    public Dog(string name, int age, string license) : base(name, age)
    {
        License = license;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name}: Woof woof!");
    }

    public override void Play()
    {
        Console.WriteLine($"{Name}: Throw the ball, throw the ball!");
    }

    public void NeedWalk()
    {
        Console.WriteLine($"{Name}: Woof woof, I need to go out.");
    }

    public void GotoVet()
    {
        Console.WriteLine($"{Name}: Whimper, whimper, no vet!");
    }

    public static void EvictCat(object source, ElapsedEventArgs e)
    {
        Console.WriteLine("EvictCat method called!");

        if (Program.pets.Count > 0)
        {
            Console.WriteLine($"Number of pets: {Program.pets.Count}");

            List<IDog> dogs = Program.pets.OfType<IDog>().ToList();
            List<ICat> cats = Program.pets.OfType<ICat>().ToList();

            if (dogs.Count > 0 && cats.Count > 0)
            {
                IDog firstDog = dogs.First();
                ICat firstCat = cats.First();

                Console.WriteLine($"First Dog: {firstDog.Name}");
                Console.WriteLine($"First Cat: {firstCat.Name}");

                firstDog.Play(); // Check if Play() method is invoked for the first dog

                firstCat.Play(); // Check if Play() method is invoked for the first cat

                Console.WriteLine($"{firstDog.Name}: You will be a homeless furball, {firstCat.Name}");
                firstCat.Evicted();

                // Remove the first cat from the pets list
                Program.pets.Remove(firstCat);
            }
            else
            {
                Console.WriteLine("No dog or cat found.");
            }
        }
        else
        {
            Console.WriteLine("No pets available.");
        }
    }


}

class Cat : Pet, ICat
{
    public Cat() { }

    public Cat(string name, int age) : base(name, age) { }

    public void Scratch()
    {
        Console.WriteLine($"{Name}: Hiss!");
    }

    public override void Play()
    {
        Console.WriteLine($"{Name}: Where's that mouse...");
    }

    public void Purr()
    {
        Console.WriteLine($"{Name}: purrrrrrrrrrrrrrrrrr...");
    }

    public void Evicted()
    {
        Console.WriteLine($"{Name}: AAAAAAAAAAAAAAAAAAAAAAH! Help me, I don't like the cold!");
    }
}

class Pets : IEnumerable<IPet>
{
    private List<IPet> petList = new List<IPet>();

    public IEnumerator<IPet> GetEnumerator()
    {
        return petList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count
    {
        get { return petList.Count; }
    }

    public void Add(IPet pet)
    {
        petList.Add(pet);
    }

    public void Remove(IPet pet)
    {
        petList.Remove(pet);
    }

    public void RemoveAt(int petEl)
    {
        if (petEl >= 0 && petEl < petList.Count)
        {
            petList.RemoveAt(petEl);
        }
    }

    public IPet this[int petEl]
    {
        get
        {
            if (petEl >= 0 && petEl < petList.Count)
            {
                return petList[petEl];
            }
            return null;
        }

        set
        {
            if (petEl >= 0 && petEl < petList.Count)
            {
                petList[petEl] = value;
            }
            else
            {
                petList.Add(value);
            }
        }
    }
}

class Program
{
    public static Pets pets = new Pets();

    static void Main(string[] args)
    {
        IPet thisPet = null;
        Dog dog = null;
        Cat cat = null;
        IDog iDog = null;
        ICat iCat = null;
        Pets pets = new Pets();

        Random rand = new Random();
        Timer myTimer = new Timer(20000);
        myTimer.Elapsed += new ElapsedEventHandler(Dog.EvictCat);
        myTimer.Start();

        for (int i = 0; i < 50; i++)
        {
            if (rand.Next(1, 11) == 1)
            {
                if (rand.Next(0, 2) == 0)
                {
                    Console.WriteLine("You bought a dog!");
                    Console.Write("Dog's Name => ");
                    string name = Console.ReadLine();

                    int age = 0;
                    bool validAge = false;
                    do
                    {
                        Console.Write("Age => ");
                        string ageInput = Console.ReadLine();

                        try
                        {
                            age = int.Parse(ageInput);
                            validAge = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid age input. Please enter a valid number for age.");
                        }
                    } while (!validAge);

                    Console.Write("License => ");
                    string license = Console.ReadLine();
                    dog = new Dog(name, age, license);
                    pets.Add(dog);
                }
                else
                {
                    Console.WriteLine("You bought a cat!");
                    Console.Write("Cat's Name => ");
                    string name = Console.ReadLine();

                    int age = 0;
                    bool validAge = false;
                    do
                    {
                        Console.Write("Age => ");
                        string ageInput = Console.ReadLine();

                        try
                        {
                            age = int.Parse(ageInput);
                            validAge = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid age input. Please enter a valid number for age.");
                        }
                    } while (!validAge);

                    cat = new Cat(name, age);
                    pets.Add(cat);
                }
            }
            else
            {
                if (pets.Count > 0)
                {
                    int petIndex = rand.Next(0, pets.Count);
                    thisPet = pets[petIndex];

                    if (thisPet == null)
                        continue;

                    if (thisPet is IDog)
                    {
                        iDog = (IDog)thisPet;
                        int activity = rand.Next(1, 6);
                        switch (activity)
                        {
                            case 1:
                                iDog.Eat();
                                break;
                            case 2:
                                iDog.Bark();
                                break;
                            case 3:
                                iDog.NeedWalk();
                                break;
                            case 4:
                                iDog.GotoVet();
                                break;
                            case 5:
                                iDog.Play();
                                break;
                        }
                    }
                    else if (thisPet is ICat)
                    {
                        iCat = (ICat)thisPet;
                        int activity = rand.Next(1, 4);
                        switch (activity)
                        {
                            case 1:
                                iCat.Eat();
                                break;
                            case 2:
                                iCat.Scratch();
                                break;
                            case 3:
                                iCat.Purr();
                                break;
                        }
                    }
                }
            }
        }
    }
}