﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UAOOI.Networking.ReferenceApplication.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4840")]
        public int UDPPort {
            get {
                return ((int)(this["UDPPort"]));
            }
            set {
                this["UDPPort"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C1F53FFB-6552-4CCC-84C9-F847147CDC85")]
        public string AssociationConfigurationId {
            get {
                return ((string)(this["AssociationConfigurationId"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string RemoteHostName {
            get {
                return ((string)(this["RemoteHostName"]));
            }
            set {
                this["RemoteHostName"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d80d81dd-96e6-4560-850e-154f9181307c")]
        public string ProducerId {
            get {
                return ((string)(this["ProducerId"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4840")]
        public int RemoteUDPPortNumber {
            get {
                return ((int)(this["RemoteUDPPortNumber"]));
            }
            set {
                this["RemoteUDPPortNumber"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ConfigurationDataConsumer.xml")]
        public string ConsumerConfigurationFileName {
            get {
                return ((string)(this["ConsumerConfigurationFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ConfigurationDataProducer.xml")]
        public string ProducerConfigurationFileName {
            get {
                return ((string)(this["ProducerConfigurationFileName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("239.255.255.1")]
        public string DefaultMulticastGroup {
            get {
                return ((string)(this["DefaultMulticastGroup"]));
            }
            set {
                this["DefaultMulticastGroup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool JoinMulticastGroup {
            get {
                return ((bool)(this["JoinMulticastGroup"]));
            }
            set {
                this["JoinMulticastGroup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ReuseAddress {
            get {
                return ((bool)(this["ReuseAddress"]));
            }
            set {
                this["ReuseAddress"] = value;
            }
        }
    }
}
