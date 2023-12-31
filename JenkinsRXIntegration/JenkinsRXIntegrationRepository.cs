﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace JenkinsRXIntegration
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the JenkinsRXIntegrationRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("4a9e9dcf-7109-4f06-aa5e-a356a5aa5b6f")]
    public partial class JenkinsRXIntegrationRepository : RepoGenBaseFolder
    {
        static JenkinsRXIntegrationRepository instance = new JenkinsRXIntegrationRepository();

        /// <summary>
        /// Gets the singleton class instance representing the JenkinsRXIntegrationRepository element repository.
        /// </summary>
        [RepositoryFolder("4a9e9dcf-7109-4f06-aa5e-a356a5aa5b6f")]
        public static JenkinsRXIntegrationRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public JenkinsRXIntegrationRepository() 
            : base("JenkinsRXIntegrationRepository", "/", null, 0, false, "4a9e9dcf-7109-4f06-aa5e-a356a5aa5b6f", ".\\RepositoryImages\\JenkinsRXIntegrationRepository4a9e9dcf.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("4a9e9dcf-7109-4f06-aa5e-a356a5aa5b6f")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class JenkinsRXIntegrationRepositoryFolders
    {
    }
#pragma warning restore 0436
}
