using EasyDotNetNotification.Usercontrols;

namespace EasyDotNetNotification
{
    public static class NotificationAlert
    {
        public static void CreateNotificationAlert(this NotificationAlertAreaControl notificationAlertAreaControl, int secondsOfDuration, string text, NotificationImage image = NotificationImage.undefined, bool showCloseButton = false)
        {
            notificationAlertAreaControl.NotificationArea.Children.Add(new NotificationAlertControl(secondsOfDuration, text, image, showCloseButton));
        }

        public static void CreateNotificationAlert(this NotificationAlertAreaControl notificationAlertAreaControl, int secondsOfDuration, string title, string text, NotificationImage image = NotificationImage.undefined, bool showCloseButton = false)
        {
            notificationAlertAreaControl.NotificationArea.Children.Add(new NotificationAlertControl(secondsOfDuration, title, text, image, showCloseButton));
        }
    }
}
