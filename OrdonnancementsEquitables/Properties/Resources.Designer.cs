﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdonnancementsEquitables.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OrdonnancementsEquitables.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;job_type&quot;: &quot;JobP&quot;,
        ///  &quot;job_list&quot;: [
        ///    {
        ///      &quot;time&quot;: &quot;1&quot;,
        ///      &quot;deadline&quot;: &quot;12&quot;,
        ///      &quot;profit&quot;: &quot;4&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;1&quot;,
        ///      &quot;deadline&quot;: &quot;10&quot;,
        ///      &quot;profit&quot;: &quot;3&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;1&quot;,
        ///      &quot;deadline&quot;: &quot;8&quot;,
        ///      &quot;profit&quot;: &quot;1&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;1&quot;,
        ///      &quot;deadline&quot;: &quot;7&quot;,
        ///      &quot;profit&quot;: &quot;6&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;1&quot;,
        ///      &quot;deadline&quot;: &quot;6&quot;,
        ///      &quot;profit&quot;: &quot;1&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;1&quot;,
        ///      &quot;deadline&quot;: &quot;5&quot;,
        ///      &quot;profit&quot;:  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string GloutonParProfits {
            get {
                return ResourceManager.GetString("GloutonParProfits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;job_type&quot;: &quot;Job&quot;,
        ///  &quot;job_list&quot;: [
        ///    {
        ///      &quot;time&quot;: &quot;6&quot;,
        ///      &quot;deadline&quot;: &quot;8&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;4&quot;,
        ///      &quot;deadline&quot;: &quot;9&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;7&quot;,
        ///      &quot;deadline&quot;: &quot;15&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;8&quot;,
        ///      &quot;deadline&quot;: &quot;20&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;3&quot;,
        ///      &quot;deadline&quot;: &quot;21&quot;
        ///    },
        ///    {
        ///      &quot;time&quot;: &quot;5&quot;,
        ///      &quot;deadline&quot;: &quot;22&quot;
        ///    }
        ///  ]
        ///}.
        /// </summary>
        public static string Hogdson {
            get {
                return ResourceManager.GetString("Hogdson", resourceCulture);
            }
        }
    }
}
