using System;
using System.Collections.Generic;
using System.Text;

namespace TypeTest
{
    public class User
    {
        public string Name { get; set; }
        public double CharactersPerMinute { get; set; }
        public double CharactersPerSecond { get; set; }
        public User(string name, double perMinute, double perSecond)
        {
            Name = name;
            CharactersPerMinute = perMinute;
            CharactersPerSecond = perSecond;
        }
        User()
        {

        }
        public override string ToString()
        {
            return $"{Name}: {CharactersPerMinute} символ. в минуту, {CharactersPerSecond} символ. в секунду";
        }
    }
}
