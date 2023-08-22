using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Chat.require;

namespace Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      
        public MainWindow()
        {
            InitializeComponent();
            List<FLI> FL = new()
            {
                new FLI(114514, "大傻逼", 1),
                new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),new FLI(10086, "小傻逼", 2),
                new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),
new FLI(10086, "小傻逼", 2),

            };            
            fl.ItemsSource = FL;

            title.SetBinding(TextBlock.TextProperty, new Binding("SelectedItem.Name") { Source = fl });
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //fl.Height = bg.ActualHeight;
        }
    }

    public class Message_DataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Send { get; set; }
        public DataTemplate Recv { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            CM.ChatMessage message = (CM.ChatMessage)item;

            if (message.Sender_Id == Var.user.Id) { return Send; }
            else { return Recv; }
        }
    }
}
