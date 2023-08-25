using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Chat.require
{
    public class FLI       //Friend List Item
    {
        public int Id { get; }
        public string Name { get; } = string.Empty;
        public BitmapImage Head { get; }      //Head ID      

        public FLI(int id, string name, int head)
        {
            Id = id;
            Name = name;
            BitmapImage map = new();
            map.BeginInit();
            map.UriSource = new Uri("res/user/head/" + head.ToString(), UriKind.Relative);
            map.EndInit();
            Head = map;
        }
    }

    public class User      //User Info
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BitmapImage Head { get; set; }
        public int Head_id { get; set; }
        public List<FLI> Friends { get; set; }
        
        public User(int id, string name, int head, List<FLI> friends)
        {
            Id = id;
            Name = name;
            BitmapImage map = new();
            map.BeginInit();
            map.UriSource = new Uri("res/user/head/" + head.ToString(), UriKind.Relative);
            map.EndInit();
            Head_id = head;
            Head = map;
            Friends = friends;
        }
        public long Send(int To, string Message, ChatServer server)
        {
            long time = DateTimeOffset.Now.ToUnixTimeSeconds();
            server.Send(JsonSerializer.Serialize(new CM.ChatMessage() { Friend_Id = To, Sender_Id = Id, Message = Message, Time = time }));
            return time;
        }
        public FLI? Get_friend(int id)
        {
            foreach(FLI friend in Friends)
            {
                if (friend.Id == id)
                {
                    return friend;
                }
            }
            return null;
        }
    }

    public class CMI       //Chat Message Item
    {
        public long Time { get; }
        public int User_Id { get; }
        public BitmapImage Head { get; }
        public int Head_id { get; }
        public string Message { get; }
        public bool IsSend { get; }
        public CMI(long time, int Id, string message, int head, bool isSend)
        {
            Time = time;
            BitmapImage map = new();
            map.BeginInit();
            map.UriSource = new Uri("res/user/head/" + head.ToString(), UriKind.Relative);
            map.EndInit();
            Head_id = head;
            Head = map;
            Message = message;
            IsSend = isSend;
            User_Id = Id;
        }
    }
}
