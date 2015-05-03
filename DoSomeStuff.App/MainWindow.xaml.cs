using System.Windows;
using DoSomeStuff.Lib;

namespace DoSomeStuff.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly StuffDoer stuffDoer;

        public MainWindow()
        {
            InitializeComponent();
            stuffDoer = new StuffDoer();
        }

        private void DoStuff(object sender, RoutedEventArgs e)
        {
        }

        private void DoStuffAsync(object sender, RoutedEventArgs e)
        {
        }
    }
}
