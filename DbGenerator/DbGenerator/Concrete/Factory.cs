using DbGenerator.Abstract;
using DbGenerator.Strategies;
using System;

namespace DbGenerator.Concrete
{
    public class Factory : IFactory
    {
        public IFieldGeneratorStrategy GetFieldStrategy(string field)
        {
            switch (field)
            {
                case "Joe":
                    return new JoeFieldGenerator();
                case "SSN":
                    return new SSNGeneratorStrategy();
                default:
                    throw new ArgumentException($"{field} is not a valid field on User.");
            }
        }
    }
}
