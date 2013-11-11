ToastHelper
===========

A strongly typed helper for toast notifications in Windows Store apps

It can be used like this:

```
var content = new ToastContent.ImageAndText02
{
    Image = "ms-appx:///Images/dotnet.png",
    Title = "Hello world!",
    Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
};
var notifier = ToastNotificationManager.CreateToastNotifier();
notifier.Show(content.CreateNotification());
```

Or, if you don't need strong typing but don't want to manipulate the XML directly, you can do this:

```
var content = new ToastContent(ToastTemplateType.ToastImageAndText02);
content.SetImage(1, "ms-appx:///Images/dotnet.png");
content.SetText(1, "Hello world!");
content.SetText(2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
var notifier = ToastNotificationManager.CreateToastNotifier();
notifier.Show(content.CreateNotification());
```
