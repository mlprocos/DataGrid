using Xamarin.Forms;

namespace Zumero
{
    public class Column : BindableObject
    {
        public static readonly BindableProperty WidthProperty =
            BindableProperty.Create<Column, double>(
                p => p.Width, 80);

        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); } // TODO disallow invalid values
        }

        public static readonly BindableProperty TemplateProperty =
            BindableProperty.Create<Column, DataTemplate>(
                p => p.Template, null);

        public DataTemplate Template
        {
            get { return (DataTemplate)GetValue(TemplateProperty); }
            set { SetValue(TemplateProperty, value); }
        }

        public static readonly BindableProperty HeaderViewProperty =
            BindableProperty.Create<Column, View>(
                p => p.HeaderView, null);

        public View HeaderView
        {
            get { return (View)GetValue(HeaderViewProperty); }
            set { SetValue(HeaderViewProperty, value); }
        }

    }

}
