﻿#pragma checksum "..\..\..\Pages\Depretion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0FDF04B40449C7D55369A23BA59833B4F78B5C09E15576074D04FA6A344A26A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using AntiVirusApp.Pages;
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


namespace AntiVirusApp.Pages {
    
    
    /// <summary>
    /// Depretion
    /// </summary>
    public partial class Depretion : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\Depretion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\Depretion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WhatSecurity;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\Depretion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Deception;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\Depretion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Methods;
        
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
            System.Uri resourceLocater = new System.Uri("/AntiVirusApp;component/pages/depretion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Depretion.xaml"
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
            this.frame = ((System.Windows.Controls.Frame)(target));
            
            #line 12 "..\..\..\Pages\Depretion.xaml"
            this.frame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.Frame_Navigated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WhatSecurity = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Pages\Depretion.xaml"
            this.WhatSecurity.Click += new System.Windows.RoutedEventHandler(this.NaviButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Deception = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Pages\Depretion.xaml"
            this.Deception.Click += new System.Windows.RoutedEventHandler(this.NaviButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Methods = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\Depretion.xaml"
            this.Methods.Click += new System.Windows.RoutedEventHandler(this.NaviButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

