using DbGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbGenerator.Strategies
{
    public interface IFieldGeneratorStrategy
    {
        User GenerateField(User user);
    }
}
