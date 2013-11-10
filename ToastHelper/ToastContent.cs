using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace ToastHelper
{
    /// <summary>
    /// Helper to define the content of a toast notification.
    /// </summary>
    public partial class ToastContent
    {
        private readonly XmlDocument _document;
        private readonly ToastTemplateType _templateType;
        public ToastContent(ToastTemplateType templateType)
        {
            _templateType = templateType;
            _document = ToastNotificationManager.GetTemplateContent(templateType);
        }
        public ToastTemplateType TemplateType
        {
            get { return _templateType; }
        }

        public void SetText(int id, string value)
        {
            string xpath = string.Format("//text[@id={0}]", id);
            var node = _document.SelectSingleNode(xpath);
            node.InnerText = value;
        }
        public string GetText(int id)
        {
            string xpath = string.Format("//text[@id={0}]", id);
            var node = _document.SelectSingleNode(xpath);
            return node.InnerText;
        }
        public void SetImage(int id, string value)
        {
            string xpath = string.Format("//image[@id={0}]", id);
            var node = (XmlElement)_document.SelectSingleNode(xpath);
            node.SetAttribute("src", value);
        }
        public string GetImage(int id)
        {
            string xpath = string.Format("//image[@id={0}]", id);
            var node = (XmlElement)_document.SelectSingleNode(xpath);
            return node.GetAttribute("src");
        }
        public ToastNotification CreateNotification()
        {
            return new ToastNotification(_document);
        }
    }
}
