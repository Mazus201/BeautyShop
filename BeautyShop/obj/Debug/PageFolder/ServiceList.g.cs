﻿#pragma checksum "..\..\..\PageFolder\ServiceList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E770FEBCAA05A104295FCFBA86EFF6AAFA31411595EBBE40F18F72FAE0CB17D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BeautyShop.PageFolder;
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


namespace BeautyShop.PageFolder {
    
    
    /// <summary>
    /// ServiceList
    /// </summary>
    public partial class ServiceList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\PageFolder\ServiceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SPService;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\PageFolder\ServiceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGetServ;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\PageFolder\ServiceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMoreInfo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\PageFolder\ServiceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEdit;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\PageFolder\ServiceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CBToDelete;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\PageFolder\ServiceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\PageFolder\ServiceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBacket;
        
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
            System.Uri resourceLocater = new System.Uri("/BeautyShop;component/pagefolder/servicelist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageFolder\ServiceList.xaml"
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
            this.SPService = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            
            #line 29 "..\..\..\PageFolder\ServiceList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnMoreInfo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnGetServ = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\PageFolder\ServiceList.xaml"
            this.BtnGetServ.Click += new System.Windows.RoutedEventHandler(this.BtnGetServ_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnMoreInfo = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\PageFolder\ServiceList.xaml"
            this.BtnMoreInfo.Click += new System.Windows.RoutedEventHandler(this.BtnMoreInfo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\PageFolder\ServiceList.xaml"
            this.BtnEdit.Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CBToDelete = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            
            #line 59 "..\..\..\PageFolder\ServiceList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\PageFolder\ServiceList.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnBacket = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\PageFolder\ServiceList.xaml"
            this.BtnBacket.Click += new System.Windows.RoutedEventHandler(this.BtnBacket_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

