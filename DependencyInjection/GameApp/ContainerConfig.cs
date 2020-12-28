using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using GameLibraryDemo;
using System.Reflection; //For Assembly.Load
using System.Linq; //For FirstOrDefault

namespace ApplicationDemo
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Game>().As<IGame>();

            //If needed IPlayer, then return class Player
            builder.RegisterType<Player>().As<IPlayer>();
            builder.RegisterType<Inventory>().As<IInventory>();

           
            //Automation - Same as above, but for all classes that have Interfaces in a Folder
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(GameLibraryDemo)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I"+t.Name));

            //This stores the definition of all of the different classes to instantiate
            return builder.Build();

        }
    }
}
