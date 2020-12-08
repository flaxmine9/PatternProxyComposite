using System;

namespace PatternProxyComposite.Composite
{
    class Meet : Component
    {
        Random random { get; set; }
        public Meet(string name) : base(name) 
        {
            random = new Random();
        }

        public override int GetPrice()
        {
            return random.Next(100, 400);
        }
    }
}
