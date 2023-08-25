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
            Message.Height = msg.ActualHeight - mi.ActualHeight;
        }

        public void SM(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            
            List<CMI> Cms = new();
            foreach (CMI i in Message.Items){Cms.Add(i);}
            Cms.Add(new CMI(DateTimeOffset.Now.ToUnixTimeSeconds(), Var.user.Id, box.Text,Var.user.Head_id, true));
            Message.ItemsSource = Cms;

        }
    }

    public class Message_DataTemplateSelector : DataTemplateSelector
    {        

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            CMI message = (CMI)item;
            FrameworkElement Fe = (FrameworkElement)container;

            if (message.IsSend) { return (DataTemplate)Fe.FindResource("Send"); }
            else { return (DataTemplate)Fe.FindResource("Recv"); }
        }
    }
}
