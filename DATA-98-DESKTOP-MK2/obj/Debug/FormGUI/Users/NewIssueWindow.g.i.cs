﻿#pragma checksum "..\..\..\..\FormGUI\Users\NewIssueWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07015F5110A865367CCD430CE072A262089B61C6814B34F59D3B8394A2FDF162"
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
    /// NewIssueWindow
    /// </summary>
    public partial class NewIssueWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\FormGUI\Users\NewIssueWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOrderDesc;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\FormGUI\Users\NewIssueWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRedeemIssue;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\FormGUI\Users\NewIssueWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelRedeem;
        
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
            System.Uri resourceLocater = new System.Uri("/DATA-98;component/formgui/users/newissuewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\FormGUI\Users\NewIssueWindow.xaml"
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
            this.tbOrderDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnRedeemIssue = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\FormGUI\Users\NewIssueWindow.xaml"
            this.btnRedeemIssue.Click += new System.Windows.RoutedEventHandler(this.btnRedeemIssue_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCancelRedeem = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\FormGUI\Users\NewIssueWindow.xaml"
            this.btnCancelRedeem.Click += new System.Windows.RoutedEventHandler(this.btnCancelRedeem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

