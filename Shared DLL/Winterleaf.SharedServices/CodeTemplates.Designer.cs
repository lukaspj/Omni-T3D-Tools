﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Winterleaf.SharedServices {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CodeTemplates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CodeTemplates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Winterleaf.SharedServices.CodeTemplates", typeof(CodeTemplates).Assembly);
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
        ///   Looks up a localized string similar to #region ProxyObjects Operator Overrides
        ///
        ///        /// &lt;summary&gt;
        ///        /// 
        ///        /// &lt;/summary&gt;
        ///        /// &lt;param name=&quot;ts&quot;&gt;&lt;/param&gt;
        ///        /// &lt;param name=&quot;simobjectid&quot;&gt;&lt;/param&gt;
        ///        /// &lt;returns&gt;&lt;/returns&gt;
        ///        public static bool operator ==( #@!#CLASSNAME#@!# ts, string simobjectid)
        ///            {
        ///            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
        ///            }
        ///
        ///        /// &lt;summary&gt;
        ///        /// 
        ///        /// &lt; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ConversionCode {
            get {
                return ResourceManager.GetString("ConversionCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright (C) 2012 Winterleaf Entertainment L,L,C.
        ///
        ///
        ///using System.Text;
        ///using WinterLeaf.Engine.Classes.Interopt;
        ///
        ///namespace WinterLeaf.Engine
        ///{
        ///    sealed public partial class Omni
        ///    {
        ///	###INSERTAUTOGEN###
        ///	}
        ///}.
        /// </summary>
        public static string Omni_Auto_cs_txt {
            get {
                return ResourceManager.GetString("Omni_Auto_cs_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright (C) 2012 Winterleaf Entertainment L,L,C.
        ///
        ///using System;
        ///using System.Collections.Generic;
        ///using System.Globalization;
        ///using System.Security.RightsManagement;
        ///using System.Text;
        ///using System.Windows;
        ///using WinterLeaf.Engine.Containers;
        ///using WinterLeaf.Engine.Enums;
        ///using WinterLeaf.Engine.Classes.Extensions;
        ///
        ///
        ///namespace WinterLeaf.Engine.Classes.Interopt
        ///    {
        ///    /// &lt;summary&gt;
        ///    /// This class is a function organizer for the externs.  All calls to Torque from C# go through th [rest of string was truncated]&quot;;.
        /// </summary>
        public static string pInvokes_cs_txt {
            get {
                return ResourceManager.GetString("pInvokes_cs_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright (C) 2012 Winterleaf Entertainment L,L,C.
        ///
        ///
        ///using System;
        ///using System.Runtime.InteropServices;
        ///using System.Text;
        ///using WinterLeaf.Engine.Classes.Helpers;
        ///
        ///namespace WinterLeaf.Engine.Classes.Interopt
        ///    {
        ///
        ///    /// &lt;summary&gt;
        ///    /// Contains all of the externs available from T3D dll.
        ///    /// &lt;/summary&gt;
        ///
        ///    internal static class SafeNativeMethods
        ///        {
        ///
        ///        static internal bool consolemapped = false;
        ///
        ///        static internal void FreeDLL()
        ///            {
        ///           [rest of string was truncated]&quot;;.
        /// </summary>
        public static string SafeNativeMethods_cs_txt {
            get {
                return ResourceManager.GetString("SafeNativeMethods_cs_txt", resourceCulture);
            }
        }
    }
}
