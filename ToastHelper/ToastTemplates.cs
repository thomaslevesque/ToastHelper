using Windows.UI.Notifications;

namespace ToastHelper
{
    public partial class ToastContent
    {
        /// <summary>
        /// An image and a single string wrapped across a maximum of three lines of text.
        /// </summary>
        public class ImageAndText01 : ToastContent
        {
            public ImageAndText01() : base(ToastTemplateType.ToastImageAndText01)
            {
            }
            public string Image
            {
                get { return GetImage(1); }
                set { SetImage(1, value); }
            }
            public string Text
            {
                get { return GetText(1); }
                set { SetText(1, value); }
            }
        }
        /// <summary>
        /// An image, one string of bold text on the first line (Title), one string of regular text wrapped across the second and third lines (Text).
        /// </summary>
        public class ImageAndText02 : ToastContent
        {
            public ImageAndText02() : base(ToastTemplateType.ToastImageAndText02)
            {
            }
            public string Image
            {
                get { return GetImage(1); }
                set { SetImage(1, value); }
            }
            public string Title
            {
                get { return GetText(1); }
                set { SetText(1, value); }
            }
            public string Text
            {
                get { return GetText(2); }
                set { SetText(2, value); }
            }
        }
        /// <summary>
        /// An image, one string of bold text wrapped across the first two lines (Title), one string of regular text on the third line (Text).
        /// </summary>
        public class ImageAndText03 : ToastContent
        {
            public ImageAndText03() : base(ToastTemplateType.ToastImageAndText03)
            {
            }
            public string Image
            {
                get { return GetImage(1); }
                set { SetImage(1, value); }
            }
            public string Title
            {
                get { return GetText(1); }
                set { SetText(1, value); }
            }
            public string Text
            {
                get { return GetText(2); }
                set { SetText(2, value); }
            }
        }
        /// <summary>
        /// An image, one string of bold text on the first line (Title), one string of regular text on the second line (Text1), one string of regular text on the third line (Text2).
        /// </summary>
        public class ImageAndText04 : ToastContent
        {
            public ImageAndText04() : base(ToastTemplateType.ToastImageAndText04)
            {
            }
            public string Image
            {
                get { return GetImage(1); }
                set { SetImage(1, value); }
            }
            public string Title
            {
                get { return GetText(1); }
                set { SetText(1, value); }
            }
            public string Text1
            {
                get { return GetText(2); }
                set { SetText(2, value); }
            }
            public string Text2
            {
                get { return GetText(3); }
                set { SetText(3, value); }
            }
        }
        /// <summary>
        /// A single string wrapped across a maximum of three lines of text.
        /// </summary>
        public class Text01 : ToastContent
        {
            public Text01() : base(ToastTemplateType.ToastText01)
            {
            }
            public string Text
            {
                get { return GetText(1); }
                set { SetText(1, value); }
            }
        }
        /// <summary>
        /// One string of bold text on the first line (Title), one string of regular text wrapped across the second and third lines (Text).
        /// </summary>
        public class Text02 : ToastContent
        {
            public Text02() : base(ToastTemplateType.ToastText02)
            {
            }
            public string Title
            {
                get { return GetText(1); }
                set { SetText(1, value); }
            }
            public string Text
            {
                get { return GetText(2); }
                set { SetText(2, value); }
            }
        }
        /// <summary>
        /// One string of bold text wrapped across the first and second lines (Title), one string of regular text on the third line (Text).
        /// </summary>
        public class Text03 : ToastContent
        {
            public Text03() : base(ToastTemplateType.ToastText03)
            {
            }
            public string Title
            {
                get { return GetText(1); }
                set { SetText(1, value); }
            }
            public string Text
            {
                get { return GetText(2); }
                set { SetText(2, value); }
            }
        }
        /// <summary>
        /// One string of bold text on the first line (Title), one string of regular text on the second line (Text1), one string of regular text on the third line (Text2).
        /// </summary>
        public class Text04 : ToastContent
        {
            public Text04() : base(ToastTemplateType.ToastText04)
            {
            }
            public string Title
            {
                get { return GetText(1); }
                set { SetText(1, value); }
            }
            public string Text1
            {
                get { return GetText(2); }
                set { SetText(2, value); }
            }
            public string Text2
            {
                get { return GetText(3); }
                set { SetText(3, value); }
            }
        }
    }
}
