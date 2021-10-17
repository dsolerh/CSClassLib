using System;

namespace CSClassLib
{
    public partial class Person : IComparable<Person>
    {
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        public string Greeting => $"{Name} says 'Hello!'";

        public int Age => System.DateTime.Today.Year - BirthDate.Year;

        public string FavouriteIceScream { get; set; }

        private string favouritePrimaryColor;
        public string FavouritePrimaryColor
        {
            get { return favouritePrimaryColor; }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primary color. " +
                            $"Choose a color from: red green blue."
                        );
                }
            }
        }

        // indexers
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}