﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tooling.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class ColourIntegerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ColourIntegerSettings defaultInstance = ((ColourIntegerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ColourIntegerSettings())));
        
        public static ColourIntegerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255")]
        public int AlphaChannelValue {
            get {
                return ((int)(this["AlphaChannelValue"]));
            }
            set {
                this["AlphaChannelValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int RedChannelValue {
            get {
                return ((int)(this["RedChannelValue"]));
            }
            set {
                this["RedChannelValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int GreenChannelValue {
            get {
                return ((int)(this["GreenChannelValue"]));
            }
            set {
                this["GreenChannelValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int BlueChannelValue {
            get {
                return ((int)(this["BlueChannelValue"]));
            }
            set {
                this["BlueChannelValue"] = value;
            }
        }
    }
}
