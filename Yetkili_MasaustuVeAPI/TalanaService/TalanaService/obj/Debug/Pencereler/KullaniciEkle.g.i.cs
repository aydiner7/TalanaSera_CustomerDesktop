﻿#pragma checksum "..\..\..\Pencereler\KullaniciEkle.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B8BEB53849F30C46508776D91878A426FB07448EB7351E0E8145C3383A22CB98"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
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
using TalanaService.Pencereler;


namespace TalanaService.Pencereler {
    
    
    /// <summary>
    /// KullaniciEkle
    /// </summary>
    public partial class KullaniciEkle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Pencereler\KullaniciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush kullaniciResim;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pencereler\KullaniciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Kodtxt;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pencereler\KullaniciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Adtxt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pencereler\KullaniciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sadtxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pencereler\KullaniciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox sifretxt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pencereler\KullaniciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button KaydetBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/TalanaService;component/pencereler/kullaniciekle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pencereler\KullaniciEkle.xaml"
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
            
            #line 25 "..\..\..\Pencereler\KullaniciEkle.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 29 "..\..\..\Pencereler\KullaniciEkle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.kullaniciResim = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 4:
            this.Kodtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Adtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Sadtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.sifretxt = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.KaydetBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Pencereler\KullaniciEkle.xaml"
            this.KaydetBtn.Click += new System.Windows.RoutedEventHandler(this.KaydetBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
