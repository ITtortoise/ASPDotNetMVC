using System;
using System.Collections.Generic;
using System.Text;

namespace BillderPattern
{
    public class PizzaBuilder
    {
        private Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public PizzaBuilder SetFlavour(string flavour)
        {
            _pizza.Flavour = flavour;
            return this;
        }

        public PizzaBuilder SetColour()
        {
            _pizza.HasColour = true;
            return this;
        }
        public PizzaBuilder SetSize()
        {
            _pizza.HasSize = true;
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}
