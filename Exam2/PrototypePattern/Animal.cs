using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Animal : ICloneable
    {
        public string Name { get; set; }
        public string Colour { get; set; }

        public Animal Clone()
        {
            return new Animal()
            {
                Name = this.Name,
                Colour = this.Colour
            };
        }

        object ICloneable.Clone()
        {
            return new Animal()
            {
                Name = this.Name,
                Colour = this.Colour
            };
        }
    }
}
