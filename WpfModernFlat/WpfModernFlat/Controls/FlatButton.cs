using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace WpfModernFlat.Controls
{
    public class FlatButton : Button
    {
        public FlatButton()
        {

        }

        public UIType Type
        {
            get { return (UIType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Type.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(UIType), typeof(FlatButton), new PropertyMetadata(UIType.Default));

        public Brush SelectedForegroundBrush
        {
            get { return (Brush)GetValue(SelectedForegroundBrushProperty); }
            set { SetValue(SelectedForegroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedForegroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedForegroundBrushProperty =
            DependencyProperty.Register("SelectedForegroundBrush", typeof(Brush), typeof(FlatButton), new PropertyMetadata(Brushes.White));

    }
}
