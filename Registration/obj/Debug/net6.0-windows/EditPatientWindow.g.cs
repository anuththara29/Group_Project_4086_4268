﻿#pragma checksum "..\..\..\EditPatientWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B8389D3F364F3CF2E9AFAC7ACCE21B5F4C345EB8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Registration;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Registration {
    
    
    /// <summary>
    /// EditPatientWindow
    /// </summary>
    public partial class EditPatientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\EditPatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserIdBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\EditPatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\EditPatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserAgeTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\EditPatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserAddressTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\EditPatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserRegistered_DateTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\EditPatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserContactNoTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\EditPatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserDiseaseTextBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\EditPatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Registration;component/editpatientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditPatientWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserIdBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.UserNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.UserAgeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.UserAddressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.UserRegistered_DateTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.UserContactNoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.UserDiseaseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\EditPatientWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

