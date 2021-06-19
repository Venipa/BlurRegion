using System;
using System.Windows;
using System.Windows.Input;
using BlurRegion.Core;

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
            DataContext = new MainWindowView()
            {
                acrylManager = new WindowBlurEffect(this, AccentState.ACCENT_ENABLE_BLURBEHIND),
                borderColor = "#14ffffff"
            };
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

        private void Window_KeyDownUp(object sender, KeyEventArgs e)
        {
            var dataContext = (this.DataContext as MainWindowView);
            var isHightlight = Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.LeftCtrl);
            dataContext.borderColor = isHightlight ? "#00ff00" : "#14ffffff";
            dataContext.borderWidth = isHightlight ? 4 : 1;
            dataContext.resizeMode = Keyboard.IsKeyDown(Key.LeftShift) ? ResizeMode.NoResize : ResizeMode.CanResizeWithGrip;

        }
    }
}
