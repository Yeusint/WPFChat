using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;

namespace Chat
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {        
        public Login()
        {
            InitializeComponent(); 
        }

        private void Login_button(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Id.Text) || string.IsNullOrWhiteSpace(pw.Password))
            {
                if (string.IsNullOrWhiteSpace(Id.Text)) { Id_tip.Content = "请输入Id."; } else { Id_tip.Content = ""; }
                if (string.IsNullOrWhiteSpace(pw.Password)) { pw_tip.Content = "请输入密码!!!"; } else { pw_tip.Content = ""; }
                return;
            }
            Id_tip.Content = ""; pw_tip.Content = "";
            login.IsEnabled = false;
            Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try { socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 999)); }
            catch (SocketException v)
            {
                MessageBox.Show($"服务器连接失败-_-\n错误码:{v.NativeErrorCode}", "真不巧", MessageBoxButton.OK, MessageBoxImage.Error);
                login.IsEnabled = true;
                return;
            }
            socket.Send(Encoding.UTF8.GetBytes($"Type:Login|Id:{Id.Text}|Password:{pw.Password}"));
            byte[] data = new byte[1024];
            int length = socket.Receive(data);
            string result = Encoding.UTF8.GetString(data, 0, length);

            socket.Close();
            login.IsEnabled=true;
        }

        private void Register_button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("看什么看,不给你注册-v-", "无注册渠道", MessageBoxButton.OK, MessageBoxImage.Stop);
        }
    }
}
