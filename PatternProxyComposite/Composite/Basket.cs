using System.Collections.Generic;

namespace PatternProxyComposite.Composite
{
    class Basket : Component
    {
        List<Component> components = new List<Component>();

        public Basket(string name) : base(name)
        {
            
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override int GetPrice()
        {
            int sum = 0;

            foreach (Component component in components)
            {
                sum += component.GetPrice();
            }

            return sum;
        }
        
    }
}
