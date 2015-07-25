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
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace WpfModernFlat.Controls
{
    /// <summary>
    /// Interaction logic for FlatWindow.xaml
    /// </summary>
    public class FlatWindow : Window
    {
        #region Brushes

        public Brush WindowTitleBrush
        {
            get { return (Brush)GetValue(WindowTitleBrushProperty); }
            set { SetValue(WindowTitleBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WindowTitleBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WindowTitleBrushProperty =
            DependencyProperty.Register("WindowTitleBrush", typeof(Brush), typeof(FlatWindow), new PropertyMetadata(Brushes.Black));

        public Brush WindowTitleForegroundBrush
        {
            get { return (Brush)GetValue(WindowTitleForegroundBrushProperty); }
            set { SetValue(WindowTitleForegroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WindowTitleForegroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WindowTitleForegroundBrushProperty =
            DependencyProperty.Register("WindowTitleForegroundBrush", typeof(Brush), typeof(FlatWindow), new PropertyMetadata(Brushes.White));

        public Brush MinimizeButtonBrush
        {
            get { return (Brush)GetValue(MinimizeButtonBrushProperty); }
            set { SetValue(MinimizeButtonBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinimizeButtonBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinimizeButtonBrushProperty =
            DependencyProperty.Register("MinimizeButtonBrush", typeof(Brush), typeof(FlatWindow), new PropertyMetadata(Brushes.Yellow));

        public Brush MaximizeButtonBrush
        {
            get { return (Brush)GetValue(MaximizeButtonBrushProperty); }
            set { SetValue(MaximizeButtonBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaximizeButtonBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaximizeButtonBrushProperty =
            DependencyProperty.Register("MaximizeButtonBrush", typeof(Brush), typeof(FlatWindow), new PropertyMetadata(Brushes.Green));

        public Brush CloseButtonBrush
        {
            get { return (Brush)GetValue(CloseButtonBrushProperty); }
            set { SetValue(CloseButtonBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseButtonBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseButtonBrushProperty =
            DependencyProperty.Register("CloseButtonBrush", typeof(Brush), typeof(FlatWindow), new PropertyMetadata(Brushes.Red));

        public Visual IconVisual
        {
            get { return (Visual)GetValue(IconVisualProperty); }
            set { SetValue(IconVisualProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconVisual.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconVisualProperty =
            DependencyProperty.Register("IconVisual", typeof(Visual), typeof(FlatWindow), new PropertyMetadata(null));


        #region Click events
        protected void MinimizeClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        protected void RestoreClick(object sender, RoutedEventArgs e)
        {
            WindowState = (WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }

        protected void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion

        #endregion

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, IntPtr lParam);

        protected void ResizeRectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle rectangle = sender as Rectangle;
            switch (rectangle.Name)
            {
                case "top":
                    Cursor = Cursors.SizeNS;
                    ResizeWindow(ResizeDirection.Top);
                    break;
                case "bottom":
                    Cursor = Cursors.SizeNS;
                    ResizeWindow(ResizeDirection.Bottom);
                    break;
                case "left":
                    Cursor = Cursors.SizeWE;
                    ResizeWindow(ResizeDirection.Left);
                    break;
                case "right":
                    Cursor = Cursors.SizeWE;
                    ResizeWindow(ResizeDirection.Right);
                    break;
                case "topLeft":
                    Cursor = Cursors.SizeNWSE;
                    ResizeWindow(ResizeDirection.TopLeft);
                    break;
                case "topRight":
                    Cursor = Cursors.SizeNESW;
                    ResizeWindow(ResizeDirection.TopRight);
                    break;
                case "bottomLeft":
                    Cursor = Cursors.SizeNESW;
                    ResizeWindow(ResizeDirection.BottomLeft);
                    break;
                case "bottomRight":
                    Cursor = Cursors.SizeNWSE;
                    ResizeWindow(ResizeDirection.BottomRight);
                    break;
                default:
                    break;
            }
        }

        private void ResizeWindow(ResizeDirection direction)
        {
            SendMessage(_hwndSource.Handle, 0x112, (IntPtr)(61440 + direction), IntPtr.Zero);
        }

        private enum ResizeDirection
        {
            Left = 1,
            Right = 2,
            Top = 3,
            TopLeft = 4,
            TopRight = 5,
            Bottom = 6,
            BottomLeft = 7,
            BottomRight = 8,
        }

        private HwndSource _hwndSource;

        protected override void OnInitialized(EventArgs e)
        {
            SourceInitialized += OnSourceInitialized;
            base.OnInitialized(e);
        }

        private void OnSourceInitialized(object sender, EventArgs e)
        {
            _hwndSource = (HwndSource)PresentationSource.FromVisual(this);
        }

        public FlatWindow()
        {
            PreviewMouseMove += OnPreviewMouseMove;
        }

        static FlatWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlatWindow),
        new FrameworkPropertyMetadata(typeof(FlatWindow)));
        }

        protected void OnPreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton != MouseButtonState.Pressed)
                Cursor = Cursors.Arrow;
        }

        protected void ResizeRectangle_MouseMove(Object sender, MouseEventArgs e)
        {
            Rectangle rectangle = sender as Rectangle;
            switch (rectangle.Name)
            {
                case "top":
                    Cursor = Cursors.SizeNS;
                    break;
                case "bottom":
                    Cursor = Cursors.SizeNS;
                    break;
                case "left":
                    Cursor = Cursors.SizeWE;
                    break;
                case "right":
                    Cursor = Cursors.SizeWE;
                    break;
                case "topLeft":
                    Cursor = Cursors.SizeNWSE;
                    break;
                case "topRight":
                    Cursor = Cursors.SizeNESW;
                    break;
                case "bottomLeft":
                    Cursor = Cursors.SizeNESW;
                    break;
                case "bottomRight":
                    Cursor = Cursors.SizeNWSE;
                    break;
                default:
                    break;
            }
        }

        public override void OnApplyTemplate()
        {
            var titleBar = GetTemplateChild("moveRectangle") as Rectangle;
            if (titleBar != null)
                titleBar.PreviewMouseDown += TitleBar_PreviewMouseDown;

            var minimizeEllipse = GetTemplateChild("btnMinimize") as Ellipse;
            if (minimizeEllipse != null)
                minimizeEllipse.MouseDown += MinimizeClick;

            var restoreEllipse = GetTemplateChild("btnMaximize") as Ellipse;
            if (restoreEllipse != null)
                restoreEllipse.MouseDown += RestoreClick;

            var closeEllipse = GetTemplateChild("btnClose") as Ellipse;
            if (closeEllipse != null)
                closeEllipse.MouseDown += CloseClick;

            Grid resizeGrid = GetTemplateChild("resizeGrid") as Grid;
            if (resizeGrid != null)
            {
                foreach (UIElement element in resizeGrid.Children)
                {
                    Rectangle resizeRectangle = element as Rectangle;
                    if (resizeRectangle != null)
                    {
                        resizeRectangle.PreviewMouseDown += ResizeRectangle_PreviewMouseDown;
                        resizeRectangle.MouseMove += ResizeRectangle_MouseMove;
                    }
                }
            }

            base.OnApplyTemplate();
        }

        private void TitleBar_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
