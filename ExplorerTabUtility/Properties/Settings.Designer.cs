﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExplorerTabUtility.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool WindowHook {
            get {
                return ((bool)(this["WindowHook"]));
            }
            set {
                this["WindowHook"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool KeyboardHook {
            get {
                return ((bool)(this["KeyboardHook"]));
            }
            set {
                this["KeyboardHook"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ReuseTabs {
            get {
                return ((bool)(this["ReuseTabs"]));
            }
            set {
                this["ReuseTabs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"[{""Name"":""Home"",""HotKeys"":[91,69],""Scope"":0,""Action"":0,""Path"":"""",""IsHandled"":true,""IsEnabled"":true,""Delay"":0},{""Name"":""Duplicate"",""HotKeys"":[17,68],""Scope"":1,""Action"":1,""Path"":null,""IsHandled"":true,""IsEnabled"":true,""Delay"":0},{""Name"":""ReopenClosed"",""HotKeys"":[16,17,84],""Scope"":1,""Action"":2,""Path"":null,""IsHandled"":true,""IsEnabled"":true,""Delay"":0}]")]
        public string HotKeyProfiles {
            get {
                return ((string)(this["HotKeyProfiles"]));
            }
            set {
                this["HotKeyProfiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveProfilesOnExit {
            get {
                return ((bool)(this["SaveProfilesOnExit"]));
            }
            set {
                this["SaveProfilesOnExit"] = value;
            }
        }
    }
}
