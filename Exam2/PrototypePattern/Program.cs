using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Animal = new Animal();
            Animal.Name = "Crow";


            Animal Animal2 = Animal.Clone();
            Animal Animal3 = Animal.Clone();

            Animal2.Name = "Cuckoo";
        }
    }
}
