using System;

namespace BuilderPattern
{
    public class Program
    {
            public static void Main(string[] args)
            {
                string key = "236582";
                string secret = "ksksjhgkahvkj";
                APIRequestBuilder builder = new APIRequestBuilder("www.youtube.com", key, secret);
                builder.SetAddress("23,mirpur,Dhaka")
                       .SetCity("Dhaka");
               // Console.WriteLine(builder.GetUrl());

            var iceCream = new IceCreamBuilder().SetFlavour("Venilla")
                 .SetCherry()
                 .SetChocolete()
                 .Build();

            Console.WriteLine($"Flavour: {iceCream.Flavour}");
            Console.WriteLine($"Nuts: {iceCream.HasNuts}");
            Console.WriteLine($"Chocolete: {iceCream.HasChocolet}");
            Console.WriteLine($"Cherry: {iceCream.HasCherry}");


        }
        }
    }

