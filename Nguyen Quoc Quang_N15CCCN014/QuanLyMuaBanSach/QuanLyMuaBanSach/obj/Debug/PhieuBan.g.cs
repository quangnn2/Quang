﻿#pragma checksum "..\..\PhieuBan.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E2DBCC8176BDF6ECB1E9A1D1B4D90FDCDD504372"
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
using QuanLyMuaBanSach;
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


namespace QuanLyMuaBanSach {
    
    
    /// <summary>
    /// PhieuBan
    /// </summary>
    public partial class PhieuBan : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\PhieuBan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tblId;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PhieuBan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTenSach;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\PhieuBan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKhachHang;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PhieuBan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tblSoLuong;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PhieuBan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tblGia;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PhieuBan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker pdNgay;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PhieuBan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyMuaBanSach;component/phieuban.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PhieuBan.xaml"
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
            this.tblId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cbTenSach = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cbKhachHang = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.tblSoLuong = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tblGia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.pdNgay = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            
            #line 28 "..\..\PhieuBan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btThem);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 29 "..\..\PhieuBan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btXoa);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 30 "..\..\PhieuBan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btSua);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 31 "..\..\PhieuBan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.datagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\PhieuBan.xaml"
            this.datagrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datagrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

