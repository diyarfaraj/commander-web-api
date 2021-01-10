using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command getCommandById(int id)
        {
            var command =  _context.Commands.FirstOrDefault(c => c.Id == id);

            return command;
        }

        public bool SaveChanges()
        {
          return  (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            //NOTHING IS NEEDED HERE
            //if(cmd == null)
            //{
            //    throw new ArgumentNullException(nameof(cmd));
            //}

            //_context.Update(cmd);
        }
    }
}
