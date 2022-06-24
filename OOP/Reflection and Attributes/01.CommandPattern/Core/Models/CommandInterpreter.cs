using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var commandArgs = args.Split().ToArray();

            var commandName = commandArgs[0];
            var fullCommandName = commandName + "Command";

            Type type = Assembly.GetCallingAssembly().GetTypes().Where(x => x.GetInterfaces().Any(x => x.Name == nameof(ICommand))).FirstOrDefault(x => x.Name == fullCommandName);

            if (type == null)
            {
                throw new ArgumentException("Invalid command!");
            }

            ICommand command = Activator.CreateInstance(type) as ICommand;

            var clearData = commandArgs.Skip(1).ToArray();

            return command.Execute(clearData); ;
        }
    }
}
