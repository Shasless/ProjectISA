﻿#pragma checksum "..\..\..\..\..\MVM\View\GraphView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A08E836DED0618391323463776C501B0319B13A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using projet.MVM.View;


namespace projet.MVM.View {
    
    
    /// <summary>
    /// GraphView
    /// </summary>
    public partial class GraphView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\MVM\View\GraphView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GraphTitle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\MVM\View\GraphView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock highMaxAmount;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\MVM\View\GraphView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock highMinAmount;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\MVM\View\GraphView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lowMaxAmount;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\MVM\View\GraphView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lowMinAmount;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\MVM\View\GraphView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GraphHigh;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\MVM\View\GraphView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GraphLow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/projet;component/mvm/view/graphview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVM\View\GraphView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GraphTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.highMaxAmount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.highMinAmount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.lowMaxAmount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.lowMinAmount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.GraphHigh = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.GraphLow = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

