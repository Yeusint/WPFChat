using SuperSocket.ClientEngine;
using System;
using System.Windows;
using WebSocket4Net;

namespace Chat.require
{
    public class ChatServer
    {
        public string Addr { get; set; }
        private WebSocket Server { get; }

        public ChatServer(string addr, EventHandler<MessageReceivedEventArgs> Message_Received, EventHandler<ErrorEventArgs>? Sever_Error, EventHandler? Sever_Closed, EventHandler? Sever_Opened) {
            Addr = addr;
            Server = new WebSocket(addr);
            Server.Error += Sever_Error ?? ((sender, e) => { MessageBox.Show($"Error: {e}", "Error", MessageBoxButton.OK, MessageBoxImage.Error); });
            Server.Closed += Sever_Closed ?? ((sender, e) => { MessageBox.Show("Sever closed", "Message", MessageBoxButton.OK, MessageBoxImage.Information); });
            Server.Opened += Sever_Opened ?? ((sender, e) => { MessageBox.Show($"Success connect", "Message", MessageBoxButton.OK); });
            Server.MessageReceived += Message_Received;
        }

        public void Connect() { Server.Open(); }

        public void Close() { Server.Close(); }

        public void Send(string Message) { Server.Send(Message); }
    }
}
