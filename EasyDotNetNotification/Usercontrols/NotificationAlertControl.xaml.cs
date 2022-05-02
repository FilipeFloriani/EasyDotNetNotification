using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace EasyDotNetNotification.Usercontrols
{
    public partial class NotificationAlertControl : UserControl
    {
        public NotificationAlertControl(int secondsOfDuration, string text, NotificationImage image, bool showCloseButton)
        {
            InitializeComponent();

            _secondsOfDuration = secondsOfDuration;
            _text = text;
            _image = image;
            _showCloseButton = showCloseButton;

            ExecuteControl();
        }

        public NotificationAlertControl(int secondsOfDuration, string title, string text, NotificationImage image, bool showCloseButton)
        {
            InitializeComponent();

            _secondsOfDuration = secondsOfDuration;
            _text = text;
            _title = title;
            _image = image;
            _showCloseButton = showCloseButton;

            ExecuteControl();
        }

        private int _secondsOfDuration;
        private bool _showCloseButton;
        private string _title = "";
        private string _text;
        private NotificationImage _image;

        private async void ExecuteControl()
        {
            TbNotificationContent.Text = _text;

            if (!string.IsNullOrEmpty(_title))
            {
                TbNotificationTitle.Text = _title;
            }
            else
            {
                (TbNotificationContent.Parent as Grid).RowDefinitions.RemoveAt(0);
            }

            ImgIcon.Source = ResolveImage();

            BtnCloseNotification.Visibility = _showCloseButton ? Visibility.Visible : Visibility.Hidden;

            await Task.Run(() =>
            {
                Thread.Sleep(new TimeSpan(0, 0, _secondsOfDuration));
            });

            try
            {
                (this.Parent as StackPanel).Children.Remove(this);
            }
            catch { }
        }

        private void CloseNotification_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as StackPanel).Children.Remove(this);
        }

        private ImageSource ResolveImage()
        {
            switch (_image)
            {
                case NotificationImage.undefined:
                    return null;
                case NotificationImage.check:
                    return new BitmapImage(new Uri(@"../src/img/check.png", UriKind.Relative));
                case NotificationImage.info:
                    return new BitmapImage(new Uri(@"../src/img/info.png", UriKind.Relative));
                case NotificationImage.warning:
                    return new BitmapImage(new Uri(@"../src/img/warning.png", UriKind.Relative));
                case NotificationImage.error:
                    return new BitmapImage(new Uri(@"../src/img/error.png", UriKind.Relative));
                default:
                    return null;
            }
        }
        
    }
}
