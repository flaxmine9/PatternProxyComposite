using System;

namespace PatternProxyComposite.Composite
{
    class Fruit : Component
    {
        Random random { get; set; }
        public Fruit(string name) : base(name) 
        {
            random = new Random();
        }

        public override int GetPrice()
        {
            return random.Next(70, 300);
        }
    }
}
