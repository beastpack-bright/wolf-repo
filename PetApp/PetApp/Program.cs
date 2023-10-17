using System;
using System.Collections.Generic;
//Rest unnecessary, I believe? 

interface IPet //Setting up the interface
{
    void Eat(); 
    void Play();
    string Name { get; set; }
    int Age { get; set; }
}

interface IDog : IPet //I:Dog inside I:Pet
{
    void Bark();
    void NeedWalk();
    void GotoVet();
    string License { get; } //getting license value
}

interface ICat : IPet //Cat is inside Pet too- Eat and Play already included in base class
{
    void Scratch();
    void Purr();
}

class Pet : IPet //pet main
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Pet() { }

    public Pet(string name, int age) //Since Eat and Play are in both Dog and Cat, added them to Pet instead so new classes not needed for each. 
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

class Dog : Pet, IDog //Same as cat but with dogs
{
    public string License { get; }

    public Dog(string name, int age, string license) : base(name, age)
    {
        License = license;
    }

    public void Bark() //Dog related statements
    {
        Console.WriteLine($"{Name}: Woof woof!");
    }
    public override void Play() //Overridinhg Play
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
}

class Cat : Pet, ICat //Cat is part of Pet is part of ICat
{
    public Cat() { } //Meow!

    public Cat(string name, int age) : base(name, age) { } //Setting up Cat

    public void Scratch() //What will be said if cat scratches
    {
        Console.WriteLine($"{Name}: Hiss!");
    }
    public override void Play() //Overriding Play
    {
        Console.WriteLine($"{Name}: Where's that mouse...");
    }

    public void Purr() //What will be stated if cat purrs
    {
        Console.WriteLine($"{Name}: purrrrrrrrrrrrrrrrrr..."); //meowwwww
    }
}

class Pets
{
    private List<Pet> petList = new List<Pet>();

    public Pet this[int petEl] //main pet statement
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

    public int Count //counts the pets in list
    {
        get { return petList.Count; }
    }

    public void Add(Pet pet) //adds a pet
    {
        petList.Add(pet);
    }

    public void Remove(Pet pet) //bye bye!  removes pet from list
    {
        petList.Remove(pet);
    }

    public void RemoveAt(int petEl) //removes pet from list at value
    {
        if (petEl >= 0 && petEl < petList.Count)
        {
            petList.RemoveAt(petEl);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {//Setting up values in Main
        Pet thisPet = null;
        Dog dog = null;
        Cat cat = null;
        IDog iDog = null;
        ICat iCat = null;
        //setting up classes
        Pets pets = new Pets();
        Random rand = new Random();

        for (int i = 0; i < 50; i++) //Will loop 50 times
        {
            if (rand.Next(1, 11) == 1) //randomizing
            {
                if (rand.Next(0, 2) == 0)
                {
                    Console.WriteLine("You bought a dog!");
                    Console.Write("Dog's Name => ");
                    string name = Console.ReadLine();

                    int age = 0; // Setting age to default value
                    bool validAge = false;
                    do //Try-catch in a do to make sure strings entered for age do not break code. 
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

                    int age = 0; // Setting age to default value
                    bool validAge = false;
                    do //Try-catch in a do to make sure strings entered for age do not break code. 
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

                    cat = new Cat(name, age); //Adds new cat
                    pets.Add(cat);
                }
            }
            else
            {
                if (pets.Count > 0) //More than 0 pets, so no randomizing if no pets are added
                {
                    int petIndex = rand.Next(0, pets.Count);
                    thisPet = pets[petIndex];

                    if (thisPet == null)
                        continue;

                    if (thisPet is IDog) //Picking a random activity using cases
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
                    else if (thisPet is ICat) //Picking a random activity using cases
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
//Copied in-assignment text as closely as possible. 