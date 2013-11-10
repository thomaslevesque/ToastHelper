using Windows.UI.Notifications;
using Windows.UI.Xaml;
using ToastHelper;


namespace TestToast
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {

        private readonly ToastNotifier _notifier;
        public MainPage()
        {
            this.InitializeComponent();
            _notifier = ToastNotificationManager.CreateToastNotifier();
            cmbTemplate.ItemsSource = new ToastContent[]
                                      {
                                          new ToastContent.Text01(),
                                          new ToastContent.Text02(),
                                          new ToastContent.Text03(),
                                          new ToastContent.Text04(),
                                          new ToastContent.ImageAndText01(),
                                          new ToastContent.ImageAndText02(),
                                          new ToastContent.ImageAndText03(),
                                          new ToastContent.ImageAndText04()
                                      };
        }


        private void btnShowToast_Click(object sender, RoutedEventArgs e)
        {
            var content = cmbTemplate.SelectedItem as ToastContent;
            if (content == null)
                return;
            _notifier.Show(content.CreateNotification());
        }

        private void SampleToastToastContentClick(object sender, RoutedEventArgs e)
        {
            var content = new ToastContent(ToastTemplateType.ToastImageAndText02);
            content.SetImage(1, "ms-appx:///Images/dotnet.png");
            content.SetText(1, "Hello world!");
            content.SetText(2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            _notifier.Show(content.CreateNotification());
        }

        private void SampleToastStronglyTypedClick(object sender, RoutedEventArgs e)
        {
            var content = new ToastContent.ImageAndText02
                          {
                              Image = "ms-appx:///Images/dotnet.png",
                              Title = "Hello world!",
                              Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                          };
            _notifier.Show(content.CreateNotification());
        }
    }
}
