﻿#pragma checksum "C:\Users\panayiotis\Desktop\New folder\AnyPlace\AnyPlace\AnyPlace\MyLocationPoiControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A9E314EFBD5CC7C64F2D855B38C089C"
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
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AnyPlace {
    
    
    public partial class MyLocationPoiControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid grd_loc;
        
        internal System.Windows.Controls.TextBlock txt_direction;
        
        internal System.Windows.Controls.Button btn_source;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AnyPlace;component/MyLocationPoiControl.xaml", System.UriKind.Relative));
            this.grd_loc = ((System.Windows.Controls.Grid)(this.FindName("grd_loc")));
            this.txt_direction = ((System.Windows.Controls.TextBlock)(this.FindName("txt_direction")));
            this.btn_source = ((System.Windows.Controls.Button)(this.FindName("btn_source")));
        }
    }
}
