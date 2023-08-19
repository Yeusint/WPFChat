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

        public class FLI       //Friend List Item
        {
            public int Id { get;}
            public string Name { get; } = string.Empty;
            public BitmapImage Head { get; }      //Head ID      
            
            public FLI(int id, string name, int head)
            {                
                Id = id;
                Name = name;
                BitmapImage map = new();
                map.BeginInit();
                map.UriSource = new Uri("res/" + head.ToString(), UriKind.Relative);
                map.EndInit();
                Head = map;
            }
        }

        
    }
}
