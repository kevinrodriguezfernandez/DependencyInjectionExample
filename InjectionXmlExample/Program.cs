using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;
using System;

namespace InjectionXmlExample
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            ConfigureContainer();
            Resolucion();
            Console.ReadLine();

        }
        public static void ConfigureContainer()
        {
            var config = new ConfigurationBuilder();
            config.AddXmlFile("AutoFac.xml");
            var module = new ConfigurationModule(config.Build());

            var builder = new ContainerBuilder();

            builder.RegisterModule(module);

            Container = builder.Build();

        }
        public static void Resolucion()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var bmw = scope.Resolve<BMWAutoService>();
                var ford = scope.Resolve<FordAutoService>();
                var honda = scope.Resolve<HondaAutoService>();
                AutoServiceCallerImp serviceCaller = new AutoServiceCallerImp(bmw, ford, honda);
                serviceCaller.CallAutoService();

            }
        }
    }
}
