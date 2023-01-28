using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatterns.Patterns.MediatorPattern
{
    internal interface IUser
    {
        public void ReceiveMessage(object message);
        public void SendMessage(object message);
    }
}
