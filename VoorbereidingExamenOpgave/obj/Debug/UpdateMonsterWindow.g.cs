﻿#pragma checksum "..\..\UpdateMonsterWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02C22AE30690EC4573737D279F92FCF4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using VoorbereidingExamenOpgave;


namespace VoorbereidingExamenOpgave {
    
    
    /// <summary>
    /// UpdateMonsterWindow
    /// </summary>
    public partial class UpdateMonsterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label hpLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label attackLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label aliveLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox attackTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox aliveCheckBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hpTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UpdateMonsterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateButton;
        
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
            System.Uri resourceLocater = new System.Uri("/VoorbereidingExamenOpgave;component/updatemonsterwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UpdateMonsterWindow.xaml"
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
            this.hpLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.attackLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.aliveLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.nameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.attackTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.aliveCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.hpTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.updateButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\UpdateMonsterWindow.xaml"
            this.updateButton.Click += new System.Windows.RoutedEventHandler(this.updateButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

