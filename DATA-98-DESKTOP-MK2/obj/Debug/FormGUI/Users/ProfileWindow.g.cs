﻿#pragma checksum "..\..\..\..\FormGUI\Users\ProfileWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DEDA3289A4FE302327E019ECB99505D0C7E6412471ECEFE9D20DCC0A4D99047B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DATA_98_DESKTOP_MK2.FormGUI.Users;
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


namespace DATA_98_DESKTOP_MK2.FormGUI.Users {
    
    
    /// <summary>
    /// ProfileWindow
    /// </summary>
    public partial class ProfileWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNick;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegister;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoToAdmins;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoToAddOrder;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoToOrders;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewIssue;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoToPool;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRejectOrder;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoToRefuses;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gdProfileOrders;
        
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
            System.Uri resourceLocater = new System.Uri("/DATA-98;component/formgui/users/profilewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
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
            this.lblNick = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnRegister = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnRegister.Click += new System.Windows.RoutedEventHandler(this.btnGoToRegister_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnGoToAdmins = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnGoToAdmins.Click += new System.Windows.RoutedEventHandler(this.btnGoToAdmins_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnGoToAddOrder = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnGoToAddOrder.Click += new System.Windows.RoutedEventHandler(this.btnGoToAddOrder_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnGoToOrders = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnGoToOrders.Click += new System.Windows.RoutedEventHandler(this.btnGoToOrders_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnNewIssue = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnNewIssue.Click += new System.Windows.RoutedEventHandler(this.btnNewIssue_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnGoToPool = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnGoToPool.Click += new System.Windows.RoutedEventHandler(this.btnGoToPool_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnRejectOrder = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnRejectOrder.Click += new System.Windows.RoutedEventHandler(this.btnRejectOrder_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnGoToRefuses = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\FormGUI\Users\ProfileWindow.xaml"
            this.btnGoToRefuses.Click += new System.Windows.RoutedEventHandler(this.btnGoToRefuses_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.gdProfileOrders = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

