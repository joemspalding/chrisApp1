using DbGenerator.Models;

namespace DbGenerator.Strategies
{
    class JoeFieldGenerator: IFieldGeneratorStrategy
    {
        public User GenerateField(User user)
        {
            user.LastName = "Hi, It's me! Joe";

            return user;
        }
    }
}
