﻿#pragma checksum "..\..\..\..\Views\Pages\pagTimesheetView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "22E20035A8945CAC4418E731716CD45C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OrganisationBitches.Views.Pages;
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


namespace OrganisationBitches.Views.Pages {
    
    
    /// <summary>
    /// pagTimesheetView
    /// </summary>
    public partial class pagTimesheetView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClockIn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBreakStart;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBreakStop;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClockOut;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTimesheets;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
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
            System.Uri resourceLocater = new System.Uri("/OrganisationBitches;component/views/pages/pagtimesheetview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
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
            
            #line 9 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
            ((OrganisationBitches.Views.Pages.pagTimesheetView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnClockIn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
            this.btnClockIn.Click += new System.Windows.RoutedEventHandler(this.btnClockIn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnBreakStart = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
            this.btnBreakStart.Click += new System.Windows.RoutedEventHandler(this.btnBreakStart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBreakStop = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
            this.btnBreakStop.Click += new System.Windows.RoutedEventHandler(this.btnBreakStop_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnClockOut = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
            this.btnClockOut.Click += new System.Windows.RoutedEventHandler(this.btnClockOut_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgTimesheets = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
            this.dgTimesheets.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgTimesheets_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\Views\Pages\pagTimesheetView.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

