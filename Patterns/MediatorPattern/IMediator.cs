using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.MediatorPattern
{
    public interface IMediator
    {
        public void AddUser(IUser user);
        public void RemoveUser(IUser user);
        public void SendMessage(IUser recipient, object? message);
    }
}
