﻿#pragma checksum "..\..\SpelSelectiePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BAB61A2654FDDB96A9C9D5B45B28F486291DAD3E25EE17D1D2726C3583844B03"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Memory;
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


namespace Memory {
    
    
    /// <summary>
    /// SpelSelectiePage
    /// </summary>
    public partial class SpelSelectiePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 196 "..\..\SpelSelectiePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BacktoSpelbtn;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\SpelSelectiePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BeginSpelbtn;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\SpelSelectiePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label speler1label;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\SpelSelectiePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxspeler1;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\SpelSelectiePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textboxspeler2;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\SpelSelectiePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ToggleSwitchSpeler;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\SpelSelectiePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label speler1label_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Memory;component/spelselectiepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SpelSelectiePage.xaml"
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
            this.BacktoSpelbtn = ((System.Windows.Controls.Button)(target));
            
            #line 196 "..\..\SpelSelectiePage.xaml"
            this.BacktoSpelbtn.Click += new System.Windows.RoutedEventHandler(this.BacktoSpelbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BeginSpelbtn = ((System.Windows.Controls.Button)(target));
            
            #line 198 "..\..\SpelSelectiePage.xaml"
            this.BeginSpelbtn.Click += new System.Windows.RoutedEventHandler(this.BeginSpelbtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.speler1label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.textboxspeler1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Textboxspeler2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ToggleSwitchSpeler = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 207 "..\..\SpelSelectiePage.xaml"
            this.ToggleSwitchSpeler.Checked += new System.Windows.RoutedEventHandler(this.ToggleSwitchSpeler_Checked);
            
            #line default
            #line hidden
            
            #line 207 "..\..\SpelSelectiePage.xaml"
            this.ToggleSwitchSpeler.Unchecked += new System.Windows.RoutedEventHandler(this.ToggleSwitchSpeler_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.speler1label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

