﻿#pragma checksum "..\..\..\FlatBrowserPOC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "01ACB43D48FB8B4969C788D2007474C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Awesomium.Windows;
using Awesomium.Windows.Controls;
using Microsoft.Windows.Themes;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfModernFlat;
using WpfModernFlat.Controls;
using WpfModernFlatSampleApp;


namespace WpfModernFlatSampleApp {
    
    
    /// <summary>
    /// FlatBrowserPOC
    /// </summary>
    public partial class FlatBrowserPOC : WpfModernFlat.Controls.FlatWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas appbar_globe;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid toolBar;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfModernFlat.Controls.FlatButton btnBack;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas appbar_arrow_left;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfModernFlat.Controls.FlatButton btnForward;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas appbar_arrow_right;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfModernFlat.Controls.FlatTextBox flatTextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas appbar_refresh;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfModernFlat.Controls.FlatButton flatButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas appbar_globe2;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\FlatBrowserPOC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Awesomium.Windows.Controls.WebControl web;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfModernFlatSampleApp;component/flatbrowserpoc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FlatBrowserPOC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 18 "..\..\..\FlatBrowserPOC.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.appbar_heart_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.appbar_globe = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.toolBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.btnBack = ((WpfModernFlat.Controls.FlatButton)(target));
            
            #line 45 "..\..\..\FlatBrowserPOC.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.appbar_arrow_left = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.btnForward = ((WpfModernFlat.Controls.FlatButton)(target));
            
            #line 50 "..\..\..\FlatBrowserPOC.xaml"
            this.btnForward.Click += new System.Windows.RoutedEventHandler(this.btnForward_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.appbar_arrow_right = ((System.Windows.Controls.Canvas)(target));
            return;
            case 8:
            this.flatTextBox = ((WpfModernFlat.Controls.FlatTextBox)(target));
            
            #line 55 "..\..\..\FlatBrowserPOC.xaml"
            this.flatTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.flatTextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.appbar_refresh = ((System.Windows.Controls.Canvas)(target));
            
            #line 57 "..\..\..\FlatBrowserPOC.xaml"
            this.appbar_refresh.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.appbar_magnify_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.flatButton = ((WpfModernFlat.Controls.FlatButton)(target));
            
            #line 62 "..\..\..\FlatBrowserPOC.xaml"
            this.flatButton.Click += new System.Windows.RoutedEventHandler(this.flatButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.appbar_globe2 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 12:
            this.web = ((Awesomium.Windows.Controls.WebControl)(target));
            
            #line 76 "..\..\..\FlatBrowserPOC.xaml"
            this.web.DocumentReady += new Awesomium.Core.DocumentReadyEventHandler(this.web_DocumentReady);
            
            #line default
            #line hidden
            
            #line 76 "..\..\..\FlatBrowserPOC.xaml"
            this.web.AddressChanged += new Awesomium.Core.UrlEventHandler(this.web_AddressChanged);
            
            #line default
            #line hidden
            
            #line 76 "..\..\..\FlatBrowserPOC.xaml"
            this.web.LoadingFrameComplete += new Awesomium.Core.FrameEventHandler(this.web_LoadingFrameComplete);
            
            #line default
            #line hidden
            
            #line 76 "..\..\..\FlatBrowserPOC.xaml"
            this.web.LoadingFrame += new Awesomium.Core.LoadingFrameEventHandler(this.web_LoadingFrame);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
