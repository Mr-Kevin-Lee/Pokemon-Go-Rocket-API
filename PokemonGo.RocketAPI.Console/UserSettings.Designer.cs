﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokemonGo.RocketAPI.Console {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class UserSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static UserSettings defaultInstance = ((UserSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UserSettings())));
        
        public static UserSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GoogleRefreshToken {
            get {
                return ((string)(this["GoogleRefreshToken"]));
            }
            set {
                this["GoogleRefreshToken"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double DefaultAltitude {
            get {
                return ((double)(this["DefaultAltitude"]));
            }
            set {
                this["DefaultAltitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("85")]
        public float KeepMinIVPercentage {
            get {
                return ((float)(this["KeepMinIVPercentage"]));
            }
            set {
                this["KeepMinIVPercentage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int KeepMinCP {
            get {
                return ((int)(this["KeepMinCP"]));
            }
            set {
                this["KeepMinCP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public double WalkingSpeedInKilometerPerHour {
            get {
                return ((double)(this["WalkingSpeedInKilometerPerHour"]));
            }
            set {
                this["WalkingSpeedInKilometerPerHour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ptc")]
        public string AuthType {
            get {
                return ((string)(this["AuthType"]));
            }
            set {
                this["AuthType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Jarolon")]
        public string PtcUsername {
            get {
                return ((string)(this["PtcUsername"]));
            }
            set {
                this["PtcUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5dfM56Rh")]
        public string PtcPassword {
            get {
                return ((string)(this["PtcPassword"]));
            }
            set {
                this["PtcPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("48.78")]
        public double DefaultLatitude {
            get {
                return ((double)(this["DefaultLatitude"]));
            }
            set {
                this["DefaultLatitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9.18274")]
        public double DefaultLongitude {
            get {
                return ((double)(this["DefaultLongitude"]));
            }
            set {
                this["DefaultLongitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EvolveAllPokemonWithEnoughCandy {
            get {
                return ((bool)(this["EvolveAllPokemonWithEnoughCandy"]));
            }
            set {
                this["EvolveAllPokemonWithEnoughCandy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TransferDuplicatePokemon {
            get {
                return ((bool)(this["TransferDuplicatePokemon"]));
            }
            set {
                this["TransferDuplicatePokemon"] = value;
            }
        }
    }
}
