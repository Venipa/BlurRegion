using BlurRegion.Core;
using System.Windows;

namespace BlurRegion
{
    public class MainWindowView : ViewModelBase
    {
        public WindowBlurEffect acrylManager { get; set; }
        public string borderColor { get; set; }
        public int borderWidth { get; set; } = 1;
        public ResizeMode resizeMode { get; set; } = ResizeMode.CanResizeWithGrip;

    }
}
