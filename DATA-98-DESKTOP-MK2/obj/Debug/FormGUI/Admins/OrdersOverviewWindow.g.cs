﻿#pragma checksum "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "93F045535BD02F13F6D7010110AF015282977A3FA1FB1A99E3009532631C27C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DATA_98_DESKTOP_MK2.FormGUI.Admins;
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


namespace DATA_98_DESKTOP_MK2.FormGUI.Admins {
    
    
    /// <summary>
    /// OrdersOverviewWindow
    /// </summary>
    public partial class OrdersOverviewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gdOrders;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuestionOrder;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIdleOrder;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAcceptOrder;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnApproveOrder;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDisapproveOrder;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMarkDone;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoToProfile;
        
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
            System.Uri resourceLocater = new System.Uri("/DATA-98;component/formgui/admins/ordersoverviewwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
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
            this.gdOrders = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnQuestionOrder = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
            this.btnQuestionOrder.Click += new System.Windows.RoutedEventHandler(this.btnQuestionOrder_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnIdleOrder = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
            this.btnIdleOrder.Click += new System.Windows.RoutedEventHandler(this.btnIdleOrder_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAcceptOrder = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
            this.btnAcceptOrder.Click += new System.Windows.RoutedEventHandler(this.btnAcceptOrder_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnApproveOrder = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
            this.btnApproveOrder.Click += new System.Windows.RoutedEventHandler(this.btnApproveOrder_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDisapproveOrder = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
            this.btnDisapproveOrder.Click += new System.Windows.RoutedEventHandler(this.btnDisapproveOrder_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnMarkDone = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
            this.btnMarkDone.Click += new System.Windows.RoutedEventHandler(this.btnMarkDone_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnGoToProfile = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\FormGUI\Admins\OrdersOverviewWindow.xaml"
            this.btnGoToProfile.Click += new System.Windows.RoutedEventHandler(this.btnGoToProfile_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

