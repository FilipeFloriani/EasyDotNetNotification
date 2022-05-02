# EasyDotNetNotification
A simple way to display alert notifications

## Quick Start

1. Download EasyDotNetNotification from nuget

2. Import EasyDotNetNotification in XAML

```xaml
xmlns:NotificationArea="clr-namespace:EasyDotNetNotification.Usercontrols;assembly=EasyDotNetNotification"
```

3. The code below adds the base control for creating alerts

```xaml
<NotificationArea:NotificationAlertAreaControl x:Name="NotificationArea" VerticalAlignment="Bottom" HorizontalAlignment="Left"/>
```
![image](https://user-images.githubusercontent.com/41344707/166309371-323c7443-be95-4e4b-8096-eb01cbb6f65e.png)

4. Finally, just call the below function as per the desired overload

```c#
private void Button_Click(object sender, RoutedEventArgs e)
{
    NotificationArea.CreateNotificationAlert(4, "Test notification text");
}
```
![image](https://user-images.githubusercontent.com/41344707/166309981-c84dec7e-110f-4076-934b-6ff9bd354958.png)
![image](https://user-images.githubusercontent.com/41344707/166310248-03555245-824f-446c-b224-a53f8349d7a2.png)

```c#
NotificationArea.CreateNotificationAlert(7, "Notification title", "Notification text", NotificationImage.info, true);
```
![image](https://user-images.githubusercontent.com/41344707/166310595-c3a0b749-4577-4fe4-92bf-d5f15cd1e887.png)

Overloads include visibility time, title, text, image and manually close button visibility
