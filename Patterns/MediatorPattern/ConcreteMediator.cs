using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.MediatorPattern
{
    public class ConcreteMediator: IMediator
    {
        private List<IUser> _users;

        public ConcreteMediator(List<IUser> users)
        {
            _users = users;
        }

        public ConcreteMediator(IEnumerable<IUser> users)
        {
            _users = users.ToList();
        }

        public void AddUser(IUser user)
        {
            if (!_users.Contains(user))
            {
                _users.Add(user);
            }
        }

        public void RemoveUser(IUser user)
        {
            if(_users.Contains(user))
            {
                _users.Remove(user);
            }
        }

        public void SendMessage(IUser recipient, object? message)
        {
            if (message != null)
            {
                recipient?.SendMessage(message);
            }
        }
    }
}
