using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfModernFlat.Controls
{
    /// <summary>
    /// A modern button!
    /// </summary>
    public partial class ModernButton : Button
    {
        public ButtonType Type
        {
            get { return (ButtonType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Type.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(ButtonType), typeof(ModernButton), new PropertyMetadata(ButtonType.Default));


        public ModernButton()
        {
        }
    }
}
