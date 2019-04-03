
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prakt3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DescViewCell : ViewCell
    {
        public static readonly BindableProperty DescriptonProperty = BindableProperty.Create("Descripton", typeof(string), typeof(DescViewCell), "");
        public static readonly BindableProperty MaxLenghtProperty = BindableProperty.Create("MaxLenght", typeof(int), typeof(DescViewCell), 100);

        public int MaxLenght
        {
            get => (int)GetValue(MaxLenghtProperty);
            set => SetValue(MaxLenghtProperty, value);
        }

        public string Descripton
        {
            get => (string)GetValue(DescriptonProperty);
            set => SetValue(DescriptonProperty, value);
        }

        public DescViewCell()
        {
            InitializeComponent();
        }


        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            if (BindingContext != null)
            {
                if (Descripton.Length > MaxLenght) DescriptonLabel.Text = Descripton.Substring(0, MaxLenght) + "...";
                else DescriptonLabel.Text = Descripton;
            }
        }

    }
}