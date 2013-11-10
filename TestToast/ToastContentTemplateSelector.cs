using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ToastHelper;

namespace TestToast
{
    public class ToastContentTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item)
        {
            var content = item as ToastContent;
            if (content == null)
                return base.SelectTemplateCore(item);
            return SelectTemplateForTemplateType(content.TemplateType);
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var content = item as ToastContent;
            if (content == null)
                return base.SelectTemplateCore(item, container);
            return SelectTemplateForTemplateType(content.TemplateType);
        }

        private static DataTemplate SelectTemplateForTemplateType(ToastTemplateType templateType)
        {
            return (DataTemplate) Application.Current.Resources[templateType.ToString()];
        }

    }
}
