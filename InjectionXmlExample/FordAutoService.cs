using InjectionXmlExample.Contracts;
using System;

namespace InjectionXmlExample
{
    public class FordAutoService: AutoService
    {
        public void GetService()
        {
            Console.WriteLine("You chose Ford auto service");
        }
    }
}
