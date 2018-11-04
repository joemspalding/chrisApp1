using DbGenerator.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbGenerator.Abstract
{
    public interface IFactory
    {
        IFieldGeneratorStrategy GetFieldStrategy(string field);
    }
}
