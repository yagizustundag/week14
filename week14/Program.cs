

Dog goodBoy = new Dog("Good Boy");

Console.WriteLine($"Name {goodBoy.Name}; Level of happinness: {goodBoy.LevelOfHappinness}");

//goodBoy.Bark();

//Console.WriteLine($"Name {goodBoy.Name}; Level of happinness: {goodBoy.LevelOfHappinness}");

//goodBoy.Wag();

while (goodBoy.LevelOfHappinness < 5)
{
    goodBoy.Bark();
}

goodBoy.Wag();

class Dog
{
    public string Name;
    public int LevelOfHappinness;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappinness = 0;
        Console.WriteLine($"{Name} is your friend now.");
    }

    public void Bark()
    {
        LevelOfHappinness++;
        Console.WriteLine("Woof-woof!");
    }

    public void Wag()
    {
        Console.WriteLine($"{Name} starts wagging its tail.");
        Console.WriteLine("Whoosh-whosh!");
    }
}
