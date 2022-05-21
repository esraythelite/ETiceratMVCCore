using ETicaretBusiness.Abstract;
using ETicaretDataAccessLayer.Abstract;
using ETicaretEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBusiness.Concrete
{
    public class CommandManager : ICommandService
    {
        private ICommandDal commandDal;
        public CommandManager(ICommandDal _commandDal)
        {
            commandDal = _commandDal;
        }
        public void Add(Command entity)
        {
            commandDal.Add(entity);
        }

        public void Delete(Command entity)
        {
            commandDal.Delete(entity);
        }

        public Command? Get(int? entityId)
        {
            return commandDal.GetById(entityId);
        }

        public IEnumerable<Command> GetAll()
        {
            return commandDal.GetAll(); 
        }

        public void Update(Command entity)
        {
            commandDal.Update(entity);  
        }
    }
}
