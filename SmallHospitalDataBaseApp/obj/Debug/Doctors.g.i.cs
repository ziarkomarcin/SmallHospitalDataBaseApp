﻿#pragma checksum "..\..\Doctors.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB95F2F346583B8687334EB51A6D8345E97259750E7E51210829F85FADF1689E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SmallHospitalDataBaseApp;
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


namespace SmallHospitalDataBaseApp {
    
    
    /// <summary>
    /// Doctors
    /// </summary>
    public partial class Doctors : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid doctorDataGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctor_NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctor_SurnameTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker doctor_EmploymentTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker doctor_ReleaseTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_AddDoctor;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Cancel;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctor_EditNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctor_EditSurnameTextBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker doctor_EditEmploymentTextBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_EditRelease;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Doctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctor_idTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SmallHospitalDataBaseApp;component/doctors.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Doctors.xaml"
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
            
            #line 10 "..\..\Doctors.xaml"
            ((SmallHospitalDataBaseApp.Doctors)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.doctorDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\Doctors.xaml"
            this.doctorDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.doctorDataGrid_SEL);
            
            #line default
            #line hidden
            return;
            case 3:
            this.doctor_NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.doctor_SurnameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.doctor_EmploymentTextBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.doctor_ReleaseTextBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.button_AddDoctor = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Doctors.xaml"
            this.button_AddDoctor.Click += new System.Windows.RoutedEventHandler(this.add_doctor_button);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Doctors.xaml"
            this.button_Cancel.Click += new System.Windows.RoutedEventHandler(this.cancel_button);
            
            #line default
            #line hidden
            return;
            case 9:
            this.doctor_EditNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.doctor_EditSurnameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.doctor_EditEmploymentTextBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 12:
            this.button_EditRelease = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\Doctors.xaml"
            this.button_EditRelease.Click += new System.Windows.RoutedEventHandler(this.edit_button);
            
            #line default
            #line hidden
            return;
            case 13:
            this.doctor_idTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

