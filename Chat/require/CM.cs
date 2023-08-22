using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.require
{
    /// <summary>
    /// Message Class
    /// Each message mode is in this file
    /// </summary>
    /// 
    public class CM
    {        
        public class ChatMessage
        {
            public int Sender_Id { get; set; }
            public int Friend_Id { get; set; }
            public long Time { get; set; }
            public string Message { get; set; } = String.Empty;            
        }
        public class UserOnline
        {
            public int Id { get; set; }
            public long Time { get; set; }
        }
        public class UserOffline
        {
            public int Id { get; set; }
            public long Time { get; set; }
        }
    }
}
