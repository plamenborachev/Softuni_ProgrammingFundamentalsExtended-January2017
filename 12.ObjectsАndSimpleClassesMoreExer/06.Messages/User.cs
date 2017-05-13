using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    public class User
    {
        public string Username { get; set; }

        public List<Message> ReceivedMessages { get; set; }
    }
}
