using System;

namespace CSClassLib
{
    public class GenericThing<T> where T : IComparable
    {
        public T Data = default;

        public string Process(T input)
        {
            if (Data.CompareTo(input) == 0)
            {
                return "Data and input are the same.";
            }
            else
            {
                return "Data and input are NOT the same.";
            }
        }

    }
}