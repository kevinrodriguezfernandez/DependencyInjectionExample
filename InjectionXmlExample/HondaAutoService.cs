using InjectionXmlExample.Contracts;
using System;

namespace InjectionXmlExample
{
    public class HondaAutoService:AutoService
    {
        public void GetService()
        {
            Console.WriteLine("You chose Honda auto service");
        }
    }
}
