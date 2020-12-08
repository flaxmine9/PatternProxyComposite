using System.Collections.Generic;

namespace PatternProxyComposite.Composite
{
    abstract class Component
    {
        protected string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }
        public abstract int GetPrice();
    }
}
