using System;
using System.Collections.Generic;

using static System.Console;

namespace CSClassLib
{
    public partial class Person : System.Object
    {
        // constants
        public const string Species = "Homo Sapien";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // set default values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // fields
        public string Name;
        public DateTime BirthDate;
        public WondersOfTheWorld FavoriteWonder;
        public WondersOfTheWorld BucketList;
        public List<Person> Children = new List<Person>();

        public override string ToString()
        {
            return String.Format(
                "{0} - {1:dddd, d MMMM yyyy}",
                Name,
                BirthDate
            );
        }

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {BirthDate:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true
        )
        {
            return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command, arg1: number, arg2: active);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            z = 99;
            x++; y++; z++;
        }

        // static method to "multiply"
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }
        // instance method to "multiply"
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        // method with a local function
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                $"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);
            int localFactorial(int localNumber) // local function
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        public int MethodIWantToCall(string input)
        {
            return input.Length; // it doesn't matter what this does
        }

        // event delegate field
        public event EventHandler Shout;

        // data field
        public int AngerLevel = 0;

        // method
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // // if something is listening...
                // if (Shout != null)
                // {
                //     // ...then call the delegate
                //     Shout(this, EventArgs.Empty);
                // }
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }
        
        public void TimeTravel(DateTime when)
        {
            if (when <= BirthDate)
            {
                throw new PersonException(
                    "If you travel back in time to a date earlier " +
                    "than your own birth, then the universe will explode!"
                );
            }
            else
            {
                WriteLine($"Welcome to {when:yyyy}!");
            }
        }

    }
    delegate int DelegateWithMatchingSignature(string s);

}