//Theme Code ==================>>
using MaterialDesignThemes.Wpf;
using MySqlConnector;
//=============================>>
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
using static System.Net.Mime.MediaTypeNames;

namespace WPF_login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var imageBrush = new ImageBrush(new BitmapImage(new Uri("E:\\РПМ\\Задания Баинки\\WPF_login\\WPF_login\\Assets\\Images\\Fon.jpg", UriKind.Relative)));
            this.Background = imageBrush;
        }

        
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();
        

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);

                var imageBrush = new ImageBrush(new BitmapImage(new Uri("E:\\РПМ\\Задания Баинки\\WPF_login\\WPF_login\\Assets\\Images\\Fon.jpg", UriKind.Relative)));
                this.Background = imageBrush;

                


            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);

                var imageBrush = new ImageBrush(new BitmapImage(new Uri("E:\\РПМ\\Задания Баинки\\WPF_login\\WPF_login\\Assets\\Images\\Fon2.jpg", UriKind.Relative)));
                this.Background = imageBrush;

                

            }

            paletteHelper.SetTheme(theme);
            
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

    }
}
