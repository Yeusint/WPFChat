using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
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

        public void SM(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox box = (TextBox)sender;

            List<CMI> Cms = new();
            foreach (CMI i in Message.Items) { Cms.Add(i); }
            Cms.Add(new CMI(DateTimeOffset.Now.ToUnixTimeSeconds(), Var.user.Id, box.Text, Var.user.Head_id, true));
            Message.ItemsSource = Cms;
            box.Text = "";
        }

        public void SM_n(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.Text += "\n";
            box.Focus();
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
