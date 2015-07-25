using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfModernFlat.Controls
{
    public class FlatTabItem : TabItem
    {
        public FlatTabItem()
            : base()
        {

        }

        public System.Windows.Media.Visual IconVisual
        {
            get { return (System.Windows.Media.Visual)GetValue(IconVisualProperty); }
            set { SetValue(IconVisualProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconVisual.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconVisualProperty =
            DependencyProperty.Register("IconVisual", typeof(System.Windows.Media.Visual), typeof(FlatTabItem), new PropertyMetadata(null));

        public System.Windows.Media.Brush MouseOverForegroundBrush
        {
            get { return (System.Windows.Media.Brush)GetValue(MouseOverForegroundBrushProperty); }
            set { SetValue(MouseOverForegroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverForegroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverForegroundBrushProperty =
            DependencyProperty.Register("MouseOverForegroundBrush", typeof(System.Windows.Media.Brush), typeof(FlatTabItem), new PropertyMetadata(System.Windows.Media.Brushes.White));

        public System.Windows.Media.Brush SelectedBackgroundBrush
        {
            get { return (System.Windows.Media.Brush)GetValue(SelectedBackgroundBrushProperty); }
            set { SetValue(SelectedBackgroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedBackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedBackgroundBrushProperty =
            DependencyProperty.Register("SelectedBackgroundBrush", typeof(System.Windows.Media.Brush), typeof(FlatTabItem), new PropertyMetadata(System.Windows.Media.Brushes.White));

        public System.Windows.Media.Brush SelectedForegroundBrush
        {
            get { return (System.Windows.Media.Brush)GetValue(SelectedForegroundBrushProperty); }
            set { SetValue(SelectedForegroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedForegroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedForegroundBrushProperty =
            DependencyProperty.Register("SelectedForegroundBrush", typeof(System.Windows.Media.Brush), typeof(FlatTabItem), new PropertyMetadata(System.Windows.Media.Brushes.White));

        public object LeftContent
        {
            get { return (object)GetValue(LeftContentProperty); }
            set { SetValue(LeftContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftContentProperty =
            DependencyProperty.Register("LeftContent", typeof(object), typeof(FlatTabItem), new PropertyMetadata(null));

        public object RightContent
        {
            get { return (object)GetValue(RightContentProperty); }
            set { SetValue(RightContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RightContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RightContentProperty =
            DependencyProperty.Register("RightContent", typeof(object), typeof(FlatTabItem), new PropertyMetadata(null));

    }
}
