using System;

namespace EasyNetQ
{
    public class MessageQ
    {
        public string CreateTime = DateTime.Now.ToString();
        public int Type          = 0;
        public string Message    = "";
        public string FromTo     = "";
    }
}
