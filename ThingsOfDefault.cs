using System;
using System.Collections.Generic;

namespace CSClassLib
{
    public class ThingsOfDefault
    {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;
        public ThingsOfDefault()
        {
            Population = default; // C# 7.1 and later
            When = default;
            Name = default;
            People = default;
        }

        public override string ToString()
        {
            return String.Format(
                "{0}:{1}\n{2}:{3}\n{4}:{5}\n{6}:{7}",
                nameof(Population),
                Population,
                nameof(When),
                When,
                nameof(Name),
                Name,
                nameof(People),
                People
            );
        }
    }
}