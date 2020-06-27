using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class IceCreamBuilder
    {
        private IceCream _iceCream;

        public IceCreamBuilder()
        {
            _iceCream = new IceCream();
        }

        public IceCreamBuilder SetFlavour(string flavour)
        {
            _iceCream.Flavour = flavour;
            return this;
        }

        public IceCreamBuilder SetCherry()
        {
            _iceCream.HasCherry = true;
            return this;
        }

        public IceCreamBuilder SetNuts()
        {
            _iceCream.HasNuts = true;
            return this;
        }

        public IceCreamBuilder SetChocolete()
        {
            _iceCream.HasChocolet = true;
            return this;
        }

        public IceCream Build()
        {
            return _iceCream;
        }
    }
}
