﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.Entities.Resources {
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
    public class Ent_GlobalResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Ent_GlobalResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Demo.Entities.Resources.Ent_GlobalResource", typeof(Ent_GlobalResource).Assembly);
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
        ///   Looks up a localized string similar to Por favor, ingrese un email válido.
        /// </summary>
        public static string Val_Msg_Invalid_Email {
            get {
                return ResourceManager.GetString("Val_Msg_Invalid_Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Este campo supera la longitud máxima permitida.
        /// </summary>
        public static string Val_Msg_MaxLength {
            get {
                return ResourceManager.GetString("Val_Msg_MaxLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} solo acepta caracteres numéricos.
        /// </summary>
        public static string Val_Msg_OnlyNumber {
            get {
                return ResourceManager.GetString("Val_Msg_OnlyNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Este campo es requerido.
        /// </summary>
        public static string Val_Msg_Required {
            get {
                return ResourceManager.GetString("Val_Msg_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo {0} debe tener una longitud máxima de {1} caracteres.
        /// </summary>
        public static string Val_Msg_StringLength {
            get {
                return ResourceManager.GetString("Val_Msg_StringLength", resourceCulture);
            }
        }
    }
}
