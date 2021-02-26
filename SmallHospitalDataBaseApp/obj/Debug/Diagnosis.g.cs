﻿#pragma checksum "..\..\Diagnosis.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "662788EADAFE842906D1CC03424A14FCACDDC0693F3C3B99FCB58C4A0DF15180"
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
    /// Diagnosis
    /// </summary>
    public partial class Diagnosis : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid diagnosisDataGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diagnosis_VisitIDTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diagnosis_IllnessNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_AddDiagnosis;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Cancel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diagnosis_DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diagnosis_VisitIDTextBox_Copy;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diagnosis_IllnessNameTextBox_Copy;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_AddDiagnosis_Copy;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diagnosis_DescriptionTextBox_Copy;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diagnosis_IDTextBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Diagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_delete;
        
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
            System.Uri resourceLocater = new System.Uri("/SmallHospitalDataBaseApp;component/diagnosis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Diagnosis.xaml"
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
            
            #line 10 "..\..\Diagnosis.xaml"
            ((SmallHospitalDataBaseApp.Diagnosis)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.diagnosisDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\Diagnosis.xaml"
            this.diagnosisDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.diagnosisDataGrid_Selection);
            
            #line default
            #line hidden
            return;
            case 3:
            this.diagnosis_VisitIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.diagnosis_IllnessNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.button_AddDiagnosis = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Diagnosis.xaml"
            this.button_AddDiagnosis.Click += new System.Windows.RoutedEventHandler(this.add_diagnosis_button);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Diagnosis.xaml"
            this.button_Cancel.Click += new System.Windows.RoutedEventHandler(this.cancel_button);
            
            #line default
            #line hidden
            return;
            case 7:
            this.diagnosis_DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.diagnosis_VisitIDTextBox_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.diagnosis_IllnessNameTextBox_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.button_AddDiagnosis_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\Diagnosis.xaml"
            this.button_AddDiagnosis_Copy.Click += new System.Windows.RoutedEventHandler(this.edit_diagnosis_button);
            
            #line default
            #line hidden
            return;
            case 11:
            this.diagnosis_DescriptionTextBox_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.diagnosis_IDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.button_delete = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\Diagnosis.xaml"
            this.button_delete.Click += new System.Windows.RoutedEventHandler(this.del_diagnosis_button);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

