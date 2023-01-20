internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Student chmo = new Student("Чмо", 21);


        for (int i = 0; i < 50; i++)
        {
            chmo.Eat(new Shit()
            {
                Marka = "Собачье говно"
            });
        }
    }
}

class Student
{

    public string Name { get; set; }
    public int Age { get; set; }


    public int ShitEating;

    public void Eat(Food food)
    {
        Console.WriteLine($"{Name} покушал {food.Marka}");
    }

    public void Eat(Shit food)
    {
        ShitEating++;

        if(ShitEating >= 6)
        {
            Console.WriteLine($"{Name} отравился {food.Marka}");
            return;
        }

        Console.WriteLine($"{Name} покушал {food.Marka}");
    }


    public Student(string name, int age)
    {
        Name = name; Age = age;
    }
    
}

class Food {

    public string Marka { get; set; }
}

class Shit :Food
{
    
}