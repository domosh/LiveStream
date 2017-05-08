using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRest
{
    public class Messages
    {
        public string Message { get; set; }

        public Messages()
        {
            
        }

        public Messages(string message)
        {
            Message = message;
        }
    }
}