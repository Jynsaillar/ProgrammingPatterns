using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.MediatorPattern
{
    internal class ConcreteUser : IUser
    {
        public void ReceiveMessage(object message)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(object message)
        {
            throw new NotImplementedException();
        }
    }
}
