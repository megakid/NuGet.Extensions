﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Extensions {
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
    internal class GetResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GetResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Extensions.GetResources", typeof(GetResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deletes all package directories underneath the package directory prior to doing the get..
        /// </summary>
        internal static string GetCommandCleanDescription {
            get {
                return ResourceManager.GetString("GetCommandCleanDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (NuGet extension command) Gets the latest packages based on the specified packages.config / solution folder.  Specify -Latest argument to fetch the latest version.  If no sources are specified, all sources defined in %AppData%\NuGet\NuGet.config are used.  If NuGet.config specifies no sources, uses the default NuGet feed..
        /// </summary>
        internal static string GetCommandDescription {
            get {
                return ResourceManager.GetString("GetCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Used package directories without version extensions..
        /// </summary>
        internal static string GetCommandExcludeVersionDescription {
            get {
                return ResourceManager.GetString("GetCommandExcludeVersionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If true, package dependencies will also be installed..
        /// </summary>
        internal static string GetCommandIncludeDependenciesDescription {
            get {
                return ResourceManager.GetString("GetCommandIncludeDependenciesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contains invalid package references..
        /// </summary>
        internal static string GetCommandInvalidPackageReference {
            get {
                return ResourceManager.GetString("GetCommandInvalidPackageReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checks the source to ensure that the latest package for each id is used..
        /// </summary>
        internal static string GetCommandLatestDescription {
            get {
                return ResourceManager.GetString("GetCommandLatestDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do NOT use a feed specific cache directory.
        /// </summary>
        internal static string GetCommandNoFeedSpecificCache {
            get {
                return ResourceManager.GetString("GetCommandNoFeedSpecificCache", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All packages listed in {0} are already installed..
        /// </summary>
        internal static string GetCommandNothingToInstall {
            get {
                return ResourceManager.GetString("GetCommandNothingToInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory to output the packages to..
        /// </summary>
        internal static string GetCommandOutputDirectoryDescription {
            get {
                return ResourceManager.GetString("GetCommandOutputDirectoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version string specified for package reference &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string GetCommandPackageReferenceInvalidVersion {
            get {
                return ResourceManager.GetString("GetCommandPackageReferenceInvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allow prerelease versions..
        /// </summary>
        internal static string GetCommandPrerelease {
            get {
                return ResourceManager.GetString("GetCommandPrerelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A comma delimeted list of package sources..
        /// </summary>
        internal static string GetCommandSourceDescription {
            get {
                return ResourceManager.GetString("GetCommandSourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows the override of the local machine cache..
        /// </summary>
        internal static string GetCommandUseCacheDescription {
            get {
                return ResourceManager.GetString("GetCommandUseCacheDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provides a &quot;get&quot; functionality to NuGet, including advanced version and package handling..
        /// </summary>
        internal static string UsageDescription {
            get {
                return ResourceManager.GetString("UsageDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provides a &quot;get&quot; functionality to NuGet, including advanced version and package handling..
        /// </summary>
        internal static string UsageSummary {
            get {
                return ResourceManager.GetString("UsageSummary", resourceCulture);
            }
        }
    }
}
