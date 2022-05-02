using System.Windows;

namespace EasyDotNetNotification.Example
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NotificationArea.CreateNotificationAlert(4, "Test notification text");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NotificationArea.CreateNotificationAlert(4, "Título teste", "Notificação teste");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NotificationArea.CreateNotificationAlert(4, "Notificação teste", NotificationImage.check);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NotificationArea.CreateNotificationAlert(4, "Notificação teste", NotificationImage.warning, true);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NotificationArea.CreateNotificationAlert(7, "Notification title", "Notification text", NotificationImage.info, true);
        }
    }
}
