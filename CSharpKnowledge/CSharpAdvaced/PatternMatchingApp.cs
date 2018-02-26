using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class PatternMatchingApp
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching
        //https://en.wikipedia.org/wiki/Pattern_matching
        //https://blogs.msdn.microsoft.com/seteplia/2017/10/16/dissecting-the-pattern-matching-in-c-7/

        // INTRODUCED IN C# 7
        // - extended is keyword with autoamatic null safe assignment
        // - upgraded switch statement with a when statement

        public static void test()
        {
            Dog max = new Dog();
            max.DogName = "Max";
            Lion simba = new Lion();
            Snake solidSnake = new Snake();
            Lizard liz = new Lizard();
            AnimalSoundWithSwitchAndWhen(max);
            //AnimalSoundWithSwitch(simba);
            //AnimalSoundWithSwitch(solidSnake);
            //AnimalSoundWithSwitch(liz);

        }

        // using IS
        public static void AnimalSound(object animal)
        {
            if (animal is Dog)
                Console.WriteLine("Woof");
            else if (animal is Cat)
                Console.WriteLine("Meow");
            else if (animal is Lion)
                Console.WriteLine("Roarrrrr");
            else if (animal is Duck)
                Console.WriteLine("Quack");
            else if (animal is Snake)
                Console.WriteLine("Snakes are actually mute :D");
            else
                Console.WriteLine("Unknown animal");

        }
        // using SWITCH
        public static void AnimalSoundWithSwitch(object animal)
        {
            switch (animal)
            {
                case Dog d: Console.WriteLine("Woof"); break;
                case Cat c: Console.WriteLine("Meow"); break;
                case Lion l: Console.WriteLine("Roar"); break;
                case Duck u: Console.WriteLine("Quack"); break;
                case Snake s: Console.WriteLine("Snake is mute"); break;
                default: Console.WriteLine("Unknown animal"); break;
            }
        }
        // using SWITCH and WHEN
        public static void AnimalSoundWithSwitchAndWhen(object animal)
        {
            switch (animal)
            {
                case Dog d when d.DogName == null: Console.WriteLine("Name is not set"); break;
            }
        }
    }


    class Dog
    {
        // Woof Woof
        public string DogSound { get; set; }
        public string DogName { get; set; }
    }

    class Cat
    {
        // Meow Meow
        public string CatSound { get; set; }
        public string CatName { get; set; }
    }

    class Lion
    {
        //Roar
        public string LionSound { get; set; }
        public string LionName { get; set; }
    }

    class Duck
    {
        // Quack
        public string DuckSound { get; set; }
        public string DuckName { get; set; }
    }
    class Snake
    {
        // Silent
        public string SnakeSound { get; set; }
        public string SnakeName { get; set; }
    }
    class Lizard
    {

    }
}
