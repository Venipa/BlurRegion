using System;
using System.Windows;
using System.Windows.Input;

namespace BlurRegion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new WindowBlurEffect(this, AccentState.ACCENT_ENABLE_BLURBEHIND) { BlurOpacity = 100 };
        }
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenNewWindow(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
