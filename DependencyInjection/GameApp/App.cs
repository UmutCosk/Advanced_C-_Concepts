using System;
using ApplicationDemo;
using GameLibraryDemo;
using Autofac;

namespace ConsoleApp1
{
    class App
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            //Setuo a new scope for the instances that are being passed out
            using (var scope = container.BeginLifetimeScope())
            {
                //Give me IApplication manually 
                var app = scope.Resolve<IGame>();
                app.Run();
            }
        }
    }
}
