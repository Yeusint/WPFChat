using System;
using System.Collections.Generic;
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
            /*
             <ListViewItem Padding="0">
                    <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                        <Ellipse Cursor="Hand" Width="50" Height="50">
                            <Ellipse.Fill>
                                <ImageBrush  ImageSource="res/icon.png" />
                            </Ellipse.Fill>
                        </Ellipse>
                        <StackPanel Orientation="Vertical" VerticalAlignment="Center" Margin="5 0">
                            <TextBlock FontSize="15" Foreground="Black" Text="你没事吧" />
                            <TextBlock  Margin="0 2 0 0" FontSize="12" Text="我说了个114514" />
                        </StackPanel>
                    </StackPanel>
                </ListViewItem>
             */
            InitializeComponent();
            List<ListViewItem> d = new List<ListViewItem>()
            {
                new ListViewItem(){
                    Padding=new Thickness() { Bottom=0,Top=0, Right=0, Left=0},
                    Content=new StackPanel(){
                        Orientation=Orientation.Horizontal,
                        HorizontalAlignment=HorizontalAlignment.Center,
                        
                    }
                }
            };
            fl.ItemsSource = d;
            fl.DisplayMemberPath = "Name";
            Binding b = new Binding("SelectedItem.id") { Source = this.fl };
            tb.SetBinding(TextBlock.TextProperty, b);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            fl.Height = bg.ActualHeight;
        }

        private void fl_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        public class User
        {
            public int id { get; set; }
            public string Name { get; set; }
        }
    }
}
