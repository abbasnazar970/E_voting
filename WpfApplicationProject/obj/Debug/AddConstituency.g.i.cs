﻿#pragma checksum "..\..\AddConstituency.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7AF61CFB33E3A868516C125F6BAA4552FBA95376"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApplicationProject;


namespace WpfApplicationProject {
    
    
    /// <summary>
    /// AddConstituency
    /// </summary>
    public partial class AddConstituency : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label provincelabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label citylabel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label areacodelabel;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox provtext;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox citytext;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox areacodetext;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitbtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AddConstituency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button listbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplicationProject;component/addconstituency.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddConstituency.xaml"
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
            this.provincelabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.citylabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.areacodelabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.provtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.citytext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.areacodetext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.submitbtn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\AddConstituency.xaml"
            this.submitbtn.Click += new System.Windows.RoutedEventHandler(this.submitbtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\AddConstituency.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.listbtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\AddConstituency.xaml"
            this.listbtn.Click += new System.Windows.RoutedEventHandler(this.listbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

