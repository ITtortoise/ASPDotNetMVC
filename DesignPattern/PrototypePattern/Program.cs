using System;
using System.ComponentModel.DataAnnotations;

namespace PrototypePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Username = "Jalaluddin";


            Email email2 = email.Clone();
            Email email3 = email.Clone();

            email2.Username = "hasan";

        }
    }
}
