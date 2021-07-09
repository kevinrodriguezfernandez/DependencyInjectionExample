using InjectionXmlExample.Contracts;
using System;

namespace InjectionXmlExample
{
    public class BMWAutoService : AutoService
    {
        public void GetService()
        {
            Console.WriteLine("You chose BMW auto service");
        }
    }
}
