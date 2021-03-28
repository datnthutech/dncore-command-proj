using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{ID=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pan"},
                new Command{ID=1, HowTo="Cut bread", Line="Get a knife", Platform="Kettle & Pan"},
                new Command{ID=2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="Platform 3"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { ID = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }
    }

}