using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfModernFlat.Controls
{
    public class FlatRadioButton : RadioButton
    {
        public FlatRadioButton()
        {

        }

        public UIType Type
        {
            get { return (UIType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Type.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(UIType), typeof(FlatRadioButton), new PropertyMetadata(UIType.Default));
    }
}
