﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildPDF.csproj.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=AMSTORE-SQL-05;Database=ENGINEERING;Trusted_Connection=True;")]
        public string CutlistConnectionString {
            get {
                return ((string)(this["CutlistConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>A5-E1-C2-0B-16-EB-35-E9-62-D3-1D-18-94-F0-81-80</string>
  <string>C6-D1-82-65-2B-53-7C-4A-D6-74-BF-33-69-75-A1-3E</string>
  <string>3E-78-D8-47-DC-44-3C-93-6E-DB-E8-24-C3-63-22-FD</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection TableHashes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TableHashes"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50, 50")]
        public global::System.Drawing.Point MessageLocation {
            get {
                return ((global::System.Drawing.Point)(this["MessageLocation"]));
            }
            set {
                this["MessageLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800, 200")]
        public global::System.Drawing.Size MessageSize {
            get {
                return ((global::System.Drawing.Size)(this["MessageSize"]));
            }
            set {
                this["MessageSize"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("S:\\shared\\general\\KOHLS\\FINISHED GOOD DRAWING PACKET\\")]
        public string TargetPath {
            get {
                return ((string)(this["TargetPath"]));
            }
        }
    }
}
