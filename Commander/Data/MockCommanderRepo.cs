using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        //min 26:52
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "boil an egg", Line = "boil water", Platform = "kettle pan" },
                new Command { Id = 2, HowTo = "cut bread", Line = "sharpen knif", Platform = "knife bread" },
                new Command { Id = 3, HowTo = "fix pc", Line = "read manual", Platform = "pc screw driver" }
            };

            return commands;
        }

        public Command getCommandById(int id)
        {
            var command = GetAllCommands().Where(c => c.Id == id).FirstOrDefault();
            return command;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
