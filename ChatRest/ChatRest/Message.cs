using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRest
{
    public class Message
    {
        public string _Message { get; set; }

        public Message()
        {
            
        }

        public Message(string message)
        {
            _Message = message;
        }

        public override string ToString()
        {
            return _Message;
        }
    }
}