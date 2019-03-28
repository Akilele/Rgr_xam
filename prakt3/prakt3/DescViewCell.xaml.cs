using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prakt3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DescViewCell : ViewCell
    {
        public static readonly BindableProperty DescriptonProperty = BindableProperty.Create("Descripton", typeof(string), typeof(DescViewCell), "");

        public string Descripton
        {
            get => (string)GetValue(DescriptonProperty);
            set
            {
                SetValue(DescriptonProperty, value);
                if (value.Length > 100) DescriptonLabel.Text = value.Substring(0, 100) + "...";
                else DescriptonLabel.Text = value;
            }
        }

        public DescViewCell()
        {
            InitializeComponent();
        }
    }
}